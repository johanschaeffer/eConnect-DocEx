using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using EConnectApi.Definitions;
using EConnectApi.Helpers;
using System.IO;
using EConnectDocEx;
using EConnectDocEx.Properties;
using System.Text.RegularExpressions;


namespace EConnectDocEx
{
    public partial class MainForm : Form
    {
        // APIclient initiation
        EConnectApi.EConnectClient APIclient = new EConnectApi.EConnectClient(new EConnectApi.EConnectClientConfigBase()
        {
            ConsumerKey = Properties.Settings.Default.OAUThAppKey,
            ConsumerSecret = Properties.Settings.Default.OAUThSecret,
            RequesterId = Properties.Settings.Default.AccountContactID
        });
        // GridTable initiaton
        DataTable fileDocTable = GridTables.CreateDataTable(typeof(GridTables.FileDoc));
        DataTable inboxDocTable = GridTables.CreateDataTable(typeof(GridTables.InboxDoc));
        DataTable outboxDocTable = GridTables.CreateDataTable(typeof(GridTables.OutboxDoc));

        public MainForm()
        {
            InitializeComponent();

            // Bind it to grid
            this.dataGridViewFileDocTable.DataSource = fileDocTable;
            this.dataGridViewFileDocTable.AllowDrop = true;
            this.dataGridViewFileDocTable.AllowUserToAddRows = false;
            this.dataGridViewFileDocTable.AutoResizeColumns();
            // Bind it to grid
            this.dataGridViewInboxDocTable.DataSource = inboxDocTable;
            this.dataGridViewInboxDocTable.AllowDrop = true;
            this.dataGridViewInboxDocTable.AllowUserToAddRows = false;
            this.dataGridViewInboxDocTable.AutoResizeColumns();
            // Bind it to grid
            this.dataGridViewOutboxDocTable.DataSource = outboxDocTable;
            this.dataGridViewOutboxDocTable.AllowDrop = true;
            this.dataGridViewOutboxDocTable.AllowUserToAddRows = false;
            this.dataGridViewOutboxDocTable.AutoResizeColumns();
        }

        public void StatusUpdate(string Status)
        {
            listBoxLog.Items.Insert(0, System.DateTime.Now.ToString() + "  " + Status);
            toolStripStatusLabel.Text = Status + "...";
            Application.DoEvents(); //Force to update the statuslabel
        }

        public Boolean NewFile(string filePathString)
        {
            // File exists
            if  (File.Exists(filePathString) == false) return false;

            //// Well-formed: The XML code must be syntactically correct or the XML parser will raise an error.
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                var xmlString = File.ReadAllText(filePathString);
                var xmlFinalString = RemoveNamespaces.RemoveAllNamespaces(xmlString); //Regex.Replace(xmlString, @"<(/?)\w+:(\w+/?)>", "<$1$2>");

                xmlDoc.LoadXml(xmlFinalString);
            }
            catch
            {
                StatusUpdate("No XML document: " + filePathString);
                return false;
            }

            // File can be added to the grid
            GridTables.FileDoc df = new GridTables.FileDoc();

            FileInfo file = new FileInfo(filePathString);
            df.FileName = file.Name;
            df.FullFilePath = filePathString;
            df.FileSize = (file.Length / 1024).ToString() + "kb";
            df.FileCreationDate = file.LastAccessTime;

            // Valid:       If the XML file has an associated XML Schema,
            //              the elements must appear in the defined structure and the content
            //              of the individual elements must conform to the declared data types specified in the schema.
            try
            {
                df.InvoiceID = xmlDoc.SelectSingleNode("Invoice/ID").InnerText;
                df.TotalAmount = xmlDoc.SelectSingleNode("Invoice/LegalMonetaryTotal/PayableAmount").InnerText;

                df.ValidInvoice = false;
                if ((df.InvoiceID.Equals("") == false) && (df.TotalAmount.Equals("") == false))
                    df.ValidInvoice = true;
            }
            catch
            {
                StatusUpdate("No valid XML elements: " + filePathString);
                return false;
            }

            // Has PDF primary image file?
            string pdfFileName = file.DirectoryName + @"\" + Path.GetFileNameWithoutExtension(file.Name) + ".PDF";

            if (File.Exists(pdfFileName) == true)
                StatusUpdate(String.Format("Primary image (PDF) detected: {0}", pdfFileName));
            //TODO SAVE and process!

            // Add filedoc to grid
            fileDocTable.Rows.Add(GridTables.makeRow(df, fileDocTable));

            StatusUpdate("Valid XML document: " + filePathString);

            return true;
        }
        
        public void LoadInboxDocuments()
        {
            StatusUpdate("Downloading list of inboxdocuments...");
            
            // Load documents with selection
            var APIdocs = APIclient.GetInboxDocuments(new GetInboxDocumentsFromEntity()
            {
                EntityId = Settings.Default.EntityID,
                Limit = 25,
                Startrowrange = string.Empty
            });

            if (APIdocs.Equals(null))
            {
                StatusUpdate("Done downloading. There are no inboxdocuments...");
                return;
            }
            else
            {
                StatusUpdate(String.Format("Done downloading list of {0} inboxdocuments...", APIdocs.Documents.Count()));
            }

            // Build grid
            foreach (DocumentBase apibasedoc in APIdocs.Documents)
            {
                // Add document to the grid
                GridTables.InboxDoc idoc = new GridTables.InboxDoc();

                idoc.ExternalId = apibasedoc.ExternalId;
                idoc.Subject = apibasedoc.Subject;
                idoc.ConsignmentName = apibasedoc.ConsignmentName;
                idoc.SenderAccountName = apibasedoc.SenderAccountName;
                idoc.SenderEntityName = apibasedoc.SenderEntityName;
                idoc.LatestStatus = apibasedoc.LatestStatus;
                idoc.CreatedDateTime = apibasedoc.CreatedDateTime;

                inboxDocTable.Rows.Add(GridTables.makeRow(idoc, inboxDocTable));
            }
            this.dataGridViewInboxDocTable.AutoResizeColumns();

            //StatusUpdate("Downloading inboxdocuments...");
            //// 
            //foreach (DocumentBase apibasedoc in APIdocs.Documents)
            //{
            //    try
            //    {
            //        var apidoc = APIclient.GetInboxDocument(new GetInboxDocument()
            //        {
            //            ConsignmentId = apibasedoc.ConsignmentId
            //        });
            //        StatusUpdate("De apidoc die de payload heeft..." + apidoc..Subject);
            //    } catch(Exception ex) {
            //        StatusUpdate(ex.Message.ToString());
            //    };
            //}
            //StatusUpdate("Done loading inboxdocuments");
        }

        public void LoadOutboxDocuments()
        {
            StatusUpdate("Downloading list of outboxdocuments...");

            // Load documents with selection
            var APIdocs = APIclient.GetOutboxDocuments(new GetOutboxDocumentsesFromEntity()
            //var APIdocs = APIclient.GetOutboxDocuments(new GetOutboxDocumentsFromEntity()
            {
                EntityId = Settings.Default.EntityID,
                Limit = 25,
                Startrowrange = string.Empty
            });

            // Check of existing documents
            if (APIdocs.Equals(null))
            {
                StatusUpdate("Done downloading. There are no outboxdocuments...");
                return;
            }
            else
            {
                StatusUpdate(String.Format("Done downloading list of {0} outboxdocuments...", APIdocs.DocumentsBase.Count()));
            }

            // Build grid
            foreach (DocumentBase apibasedoc in APIdocs.DocumentsBase)
            //foreach (DocumentBase apibasedoc in APIdocs.Documents)
            {
                // Add document to the grid
                GridTables.OutboxDoc odoc = new GridTables.OutboxDoc();

                odoc.ExternalId = apibasedoc.ExternalId;
                odoc.Subject = apibasedoc.Subject;
                odoc.ConsignmentName = apibasedoc.ConsignmentName;
                odoc.SenderAccountName = apibasedoc.SenderAccountName;
                odoc.SenderEntityName = apibasedoc.SenderEntityName;
                odoc.LatestStatus = apibasedoc.LatestStatus;
                odoc.CreatedDateTime = apibasedoc.CreatedDateTime;

                outboxDocTable.Rows.Add(GridTables.makeRow(odoc, outboxDocTable));
            }
            this.dataGridViewOutboxDocTable.AutoResizeColumns();
        }

        // =======BUTTONS

        private void buttonDialog_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                textBoxDirectory.Text = folderBrowserDialog.SelectedPath;
                Settings.Default.Save();
            }
        }

        private void btnGetFiles_Click(object sender, EventArgs e)
        {
            int ValidFiles = 0;
            string[] filesPath = Directory.GetFiles(textBoxDirectory.Text);
            foreach (string path in filesPath)
            {
                Boolean Succes = NewFile(path);
                if (Succes == true)
                    ValidFiles++;
            }
            this.dataGridViewFileDocTable.AutoResizeColumns();

            string text = string.Format("Done reading {0} files and validating {1} XML documents.", filesPath.Count(), ValidFiles);
            StatusUpdate(text);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewFileDocTable.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a row first.", "No row selected", MessageBoxButtons.OK);
                StatusUpdate("No row selected. Please select a row first.");
            }
            else
            {
                StatusUpdate("Connecting...");
                foreach (DataGridViewRow row in this.dataGridViewFileDocTable.SelectedRows)
                {
                    string DocFile = row.Cells["FullFilePath"].Value.ToString();

                    StatusUpdate("Sending: " + DocFile);

                    var docRequest = new SendDocument()
                        {
                            DocumentTemplateId = "GLDT9223370666504283001RA000000006DTP2000001",
                            Subject = "API exchange test",
                            SendViaGroup = Settings.Default.EntityID,
                            Recipient = "XCNL10201", //"XCNL10027", //"johanschaeffer@gmail.com",
                            RecipientEmailId = "johanschaeffer@hotmail.com", //"thieme@selmit.nl",
                            Payload = XElement.Parse(System.IO.File.ReadAllText(DocFile)),
                            DocumentAsFile = new DocumentAsFile() { FileContents = "T3JkZXIgRGV0YWlscyBmb3IgUGFydG5lcldvcmxkIExpY2Vuc2U=", FileName = "order.txt" }
                        };

                    StatusUpdate(String.Format("ExternalID: {0}   ConsignmentID: {1}",APIclient.SendDocument(docRequest).ExternalId,APIclient.SendDocument(docRequest).ConsignmentId)); 

                    // TODO ARCHIVE!
                }
                StatusUpdate("Done sending...");
            }
        }

        private void buttonSelectAllValid_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow dgRow in this.dataGridViewFileDocTable.Rows)
            {
                if (dgRow.Cells["ValidInvoice"].Value.Equals(true) == true)
                    dgRow.Selected = true;
                else
                    dgRow.Selected = false;             
            }
        }

        private void buttonInboxRefresh_Click(object sender, EventArgs e)
        {
            LoadInboxDocuments();
        }

        // =======BEHAVIOUR

        private void dataGridViewDocs_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (var filePath in files)
                {
                    NewFile(filePath);
                }
                this.dataGridViewFileDocTable.AutoResizeColumns();
            }
        }

        private void dataGridViewDocs_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm mySettingsForm = new SettingsForm();

            mySettingsForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxeConnect myAboutBoxeConnect = new AboutBoxeConnect();

            myAboutBoxeConnect.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadOutboxDocuments();
        }

        private void dataGridViewOutboxDocTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //StatusUpdate("Connecting...");
            //foreach (DataGridViewRow row in this.dataGridViewFileDocTable.SelectedRows)
            //{
            //    string DocFile = row.Cells["FullFilePath"].Value.ToString();

            //    StatusUpdate("Downloading payload: " + DocFile);

            //    var docRequest = new SendDocument()
            //    {
            //        DocumentTemplateId = "GLDT9223370666504283001RA000000006DTP2000001",
            //        Subject = "API exchange test",
            //        SendViaGroup = Settings.Default.EntityID,
            //        Recipient = "XCNL10201", //"XCNL10027", //"johanschaeffer@gmail.com",
            //        RecipientEmailId = "johanschaeffer@hotmail.com", //"thieme@selmit.nl",
            //        Payload = XElement.Parse(System.IO.File.ReadAllText(DocFile)),
            //        DocumentAsFile = new DocumentAsFile() { FileContents = "T3JkZXIgRGV0YWlscyBmb3IgUGFydG5lcldvcmxkIExpY2Vuc2U=", FileName = "order.txt" }
            //    };

            //    StatusUpdate(String.Format("ExternalID: {0}   ConsignmentID: {1}", APIclient.SendDocument(docRequest).ExternalId, APIclient.SendDocument(docRequest).ConsignmentId));

            //}
            //StatusUpdate("Done downloading payload...");
        }

    }
   
}
