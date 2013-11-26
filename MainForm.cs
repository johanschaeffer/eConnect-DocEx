using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using EConnectApi.Definitions;
using EConnectApi.Helpers;
using System.IO;
using EConnectDocEx;
using EConnectDocEx.Properties;


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

        public Boolean NewFile(string filePath)
        {
            // File exists
            if  (File.Exists(filePath) == false) return false;

            StatusUpdate("Reading: " + filePath);

            // Well-formed: The XML code must be syntactically correct or the XML parser will raise an error.
            try
            {
                XDocument xd1 = new XDocument();
                xd1 = XDocument.Load(filePath);
            }
            catch
            {
                StatusUpdate("No XML document: " + filePath);
                return false;
            }

            StatusUpdate("Validating: " + filePath + "...");

            // Valid:       If the XML file has an associated XML Schema,
            //              the elements must appear in the defined structure and the content
            //              of the individual elements must conform to the declared data types specified in the schema.
            // *****TODO*****

            // File can be added to the grid
            GridTables.FileDoc df = new GridTables.FileDoc();

            FileInfo file = new FileInfo(filePath);
            df.FileName = file.Name;
            df.FullFilePath = filePath;
            df.FileSize = (file.Length / 1024).ToString() + "kb";
            df.FileCreationDate = file.LastAccessTime;

            fileDocTable.Rows.Add(GridTables.makeRow(df, fileDocTable));

            StatusUpdate("Loaded: " + filePath);

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

            StatusUpdate("Done downloading list of inboxdocuments...");

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

            StatusUpdate("Done Downloading list of outboxdocuments...");

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
                {
                    ValidFiles++;
                }
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
                            Recipient = "XCNL10027", //"johanschaeffer@gmail.com",
                            //RecipientEmailId = "thieme@selmit.nl",
                            Payload = XElement.Parse(System.IO.File.ReadAllText(DocFile)),
                            DocumentAsFile = new DocumentAsFile() { FileContents = "T3JkZXIgRGV0YWlscyBmb3IgUGFydG5lcldvcmxkIExpY2Vuc2U=", FileName = "order.txt" }
                        };

                    StatusUpdate(APIclient.SendDocument(docRequest).ExternalId + " " + APIclient.SendDocument(docRequest).ConsignmentId); 
                    
                }
                StatusUpdate("Done sending...");
            }
        }

        private void buttonSelectAllValid_Click(object sender, EventArgs e)
        {
            this.dataGridViewFileDocTable.SelectAll();
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



    }
   
}



//var doc = new SendDocument()
//{
//    DocumentTemplateId = "GLDT9223370666504283001RA000000006DTP2000001",
//    Subject = "Afas test factuur",
//    Recipient = "thieme@selmit.nl",
//    RecipientEmailId = "thieme@selmit.nl",
//    Payload = XElement.Parse(System.IO.File.ReadAllText(@"E:\eVerbinding app\Test files\UBLWITHATTACHEMENT.txt")),
//    DocumentAsFile = new DocumentAsFile() { FileContents = "T3JkZXIgRGV0YWlscyBmb3IgUGFydG5lcldvcmxkIExpY2Vuc2U=", FileName = "order.txt" }
//};
//var res = ApiProxy.SendDocument(doc, "thieme@selmit.nl");
//MessageBox.Show(res.ConsignmentId);
//// TODO:
//var docs = ApiProxy.GetDocuments(new GetDocuments() { GroupId = "XGI11384895851735740", Limit = 10, Startrowrange = 0}, "thieme@selmit.nl");
//return;


//MessageBox.Show("Verbinding maken met eVerbinding...");
//var oAuthUtils = new OAuthConsumer();
//SignatureMethod SigningProvider = SignatureMethod.HMACSHA1;

// Requesting request token
//var RequestToken = oAuthUtils.GetOAuthRequestToken(
//                                    Settings.Default.EndPointRequestToken,
//                                    Settings.Default.Realm,
//                                    Settings.Default.OAUThAppKey,
//                                    Settings.Default.OAUThSecret,
//                                    "Unused",
//                                    "SEND_DOC",
//                                    SigningProvider);
//// Opslaan in debug tabs
////eConnect_DocEx.MainForm.textBoxLog.Text = 'dd';

//// Requesting access token using request token
//var AccessToken = oAuthUtils.GetOAuthAccessToken(
//                                    Settings.Default.EndPointAccessToken,
//                                    Settings.Default.Realm,
//                                    Settings.Default.OAUThAppKey,
//                                    Settings.Default.OAUThSecret,
//                                    RequestToken.Token.ToString(),
//                                    "Unused",
//                                    RequestToken.TokenSecret.ToString(),
//                                    "SEND_DOC",
//                                    SigningProvider);


// Opslaan in debug tabs


// This must be filtered out of the payload: <?xml version="1.0" encoding="UTF-8"?>

// Invoice DocumentTemplateId: GLDT9223370666504283001RA000000006DTP2000001
// Simpele tekst DocumentTemplateId: GLDT9223370666592418249RA000000001DTP3000002

// Sending document using access token
//string payload =
//    "<SOAP:Envelope xmlns:SOAP=\"http://schemas.xmlsoap.org/soap/envelope/\">"
//    + "<SOAP:Body>"
//    + "<SendDocument xmlns=\"http://ws.vg.pw.com/external/1.0\">"
//    + "<DocumentTemplateId>GLDT9223370666504283001RA000000006DTP2000001</DocumentTemplateId>"
//    + "<Subject>Afas test factuur</Subject>"
//    + "<Recipient>thieme@selmit.nl</Recipient>"
//    // Document As File = de representatie van het document
//    + "<DocumentAsFile fileName=\"order.txt\">T3JkZXIgRGV0YWlscyBmb3IgUGFydG5lcldvcmxkIExpY2Vuc2U=</DocumentAsFile>"
//    + "<RecipientEmailId>thieme@selmit.nl</RecipientEmailId>"
//    //+ "<SendViaGroup>XCNL10027</SendViaGroup>"
//    + "<Payload>"
//    //  + System.IO.File.ReadAllText(@"E:\eVerbinding app\Test files\Abonnementsfactuur V2705714 - kopie.ubl")
//         + System.IO.File.ReadAllText(@"C:\Users\Thieme\Documents\SelmIT\eVerbinding\ExampleApp\Test files\UBLWITHATTACHEMENT.txt")
//    //+ System.IO.File.ReadAllText(@"E:\eVerbinding app\Test files\Factureren Factuur 10000 20130052 (2013-10-31 10-42-21)_000.xml")
//    + "</Payload>"
//    + "</SendDocument></SOAP:Body></SOAP:Envelope>";
//var result = oAuthUtils.send("https://platform.everbinding.nl/api/accessresource", "platform.everbinding.nl", Settings.Default.OAUThAppKey, Settings.Default.OAUThSecret, AccessToken.Token.ToString(), AccessToken.TokenSecret.ToString(), "SEND_DOC", payload, "thieme@selmit.nl", SigningProvider);

//MessageBox.Show("Done. Result: " + result);