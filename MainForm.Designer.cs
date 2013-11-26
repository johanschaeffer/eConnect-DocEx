namespace EConnectDocEx
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.connectAndRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabManualSend = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelintop = new System.Windows.Forms.Panel();
            this.groupActions = new System.Windows.Forms.GroupBox();
            this.buttonSelectAllValid = new System.Windows.Forms.Button();
            this.buttonSendDoc = new System.Windows.Forms.Button();
            this.groupBoxFilesFromFiler = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.buttonDialog = new System.Windows.Forms.Button();
            this.btnGetFiles = new System.Windows.Forms.Button();
            this.dataGridViewFileDocTable = new System.Windows.Forms.DataGridView();
            this.tabControlDocuments = new System.Windows.Forms.TabControl();
            this.tabInbox = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelInboxTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonInboxRefresh = new System.Windows.Forms.Button();
            this.tabOutbox = new System.Windows.Forms.TabPage();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabLogFeed = new System.Windows.Forms.TabPage();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.tabPagePayload = new System.Windows.Forms.TabPage();
            this.textBoxPayload = new System.Windows.Forms.TextBox();
            this.tabPageRequest = new System.Windows.Forms.TabPage();
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.tabPageResponse = new System.Windows.Forms.TabPage();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridViewInboxDocTable = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewOutboxDocTable = new System.Windows.Forms.DataGridView();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tabManualSend.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelintop.SuspendLayout();
            this.groupActions.SuspendLayout();
            this.groupBoxFilesFromFiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileDocTable)).BeginInit();
            this.tabControlDocuments.SuspendLayout();
            this.tabInbox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelInboxTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabOutbox.SuspendLayout();
            this.tabResults.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabLogFeed.SuspendLayout();
            this.tabPagePayload.SuspendLayout();
            this.tabPageRequest.SuspendLayout();
            this.tabPageResponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInboxDocTable)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutboxDocTable)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 665);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabel.Text = "......";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectAndRefreshToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // connectAndRefreshToolStripMenuItem
            // 
            this.connectAndRefreshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.connectAndRefreshToolStripMenuItem.Name = "connectAndRefreshToolStripMenuItem";
            this.connectAndRefreshToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.connectAndRefreshToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabManualSend
            // 
            this.tabManualSend.Controls.Add(this.tableLayoutPanel1);
            this.tabManualSend.Location = new System.Drawing.Point(4, 22);
            this.tabManualSend.Margin = new System.Windows.Forms.Padding(2);
            this.tabManualSend.Name = "tabManualSend";
            this.tabManualSend.Padding = new System.Windows.Forms.Padding(2);
            this.tabManualSend.Size = new System.Drawing.Size(976, 615);
            this.tabManualSend.TabIndex = 3;
            this.tabManualSend.Text = "Manual send";
            this.tabManualSend.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panelintop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewFileDocTable, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 611);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panelintop
            // 
            this.panelintop.Controls.Add(this.groupActions);
            this.panelintop.Controls.Add(this.groupBoxFilesFromFiler);
            this.panelintop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelintop.Location = new System.Drawing.Point(3, 3);
            this.panelintop.Name = "panelintop";
            this.panelintop.Size = new System.Drawing.Size(966, 69);
            this.panelintop.TabIndex = 6;
            // 
            // groupActions
            // 
            this.groupActions.Controls.Add(this.buttonSelectAllValid);
            this.groupActions.Controls.Add(this.buttonSendDoc);
            this.groupActions.Location = new System.Drawing.Point(416, 3);
            this.groupActions.Name = "groupActions";
            this.groupActions.Size = new System.Drawing.Size(225, 63);
            this.groupActions.TabIndex = 11;
            this.groupActions.TabStop = false;
            this.groupActions.Text = "Actions";
            // 
            // buttonSelectAllValid
            // 
            this.buttonSelectAllValid.Location = new System.Drawing.Point(6, 23);
            this.buttonSelectAllValid.Name = "buttonSelectAllValid";
            this.buttonSelectAllValid.Size = new System.Drawing.Size(99, 29);
            this.buttonSelectAllValid.TabIndex = 2;
            this.buttonSelectAllValid.Text = "Select all valid";
            this.buttonSelectAllValid.UseVisualStyleBackColor = true;
            this.buttonSelectAllValid.Click += new System.EventHandler(this.buttonSelectAllValid_Click);
            // 
            // buttonSendDoc
            // 
            this.buttonSendDoc.Location = new System.Drawing.Point(111, 23);
            this.buttonSendDoc.Name = "buttonSendDoc";
            this.buttonSendDoc.Size = new System.Drawing.Size(102, 29);
            this.buttonSendDoc.TabIndex = 1;
            this.buttonSendDoc.Text = "Send selected";
            this.buttonSendDoc.UseVisualStyleBackColor = true;
            this.buttonSendDoc.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBoxFilesFromFiler
            // 
            this.groupBoxFilesFromFiler.Controls.Add(this.label1);
            this.groupBoxFilesFromFiler.Controls.Add(this.textBoxDirectory);
            this.groupBoxFilesFromFiler.Controls.Add(this.buttonDialog);
            this.groupBoxFilesFromFiler.Controls.Add(this.btnGetFiles);
            this.groupBoxFilesFromFiler.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFilesFromFiler.Name = "groupBoxFilesFromFiler";
            this.groupBoxFilesFromFiler.Size = new System.Drawing.Size(407, 63);
            this.groupBoxFilesFromFiler.TabIndex = 10;
            this.groupBoxFilesFromFiler.TabStop = false;
            this.groupBoxFilesFromFiler.Text = "Documents from folder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Folder";
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EConnectDocEx.Properties.Settings.Default, "DefaultDocumentDirectory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDirectory.Location = new System.Drawing.Point(9, 32);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(223, 20);
            this.textBoxDirectory.TabIndex = 8;
            this.textBoxDirectory.Text = global::EConnectDocEx.Properties.Settings.Default.DefaultDocumentDirectory;
            // 
            // buttonDialog
            // 
            this.buttonDialog.Location = new System.Drawing.Point(238, 32);
            this.buttonDialog.Name = "buttonDialog";
            this.buttonDialog.Size = new System.Drawing.Size(23, 20);
            this.buttonDialog.TabIndex = 9;
            this.buttonDialog.Text = "...";
            this.buttonDialog.UseVisualStyleBackColor = true;
            this.buttonDialog.Click += new System.EventHandler(this.buttonDialog_Click);
            // 
            // btnGetFiles
            // 
            this.btnGetFiles.Location = new System.Drawing.Point(281, 16);
            this.btnGetFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetFiles.Name = "btnGetFiles";
            this.btnGetFiles.Size = new System.Drawing.Size(105, 36);
            this.btnGetFiles.TabIndex = 6;
            this.btnGetFiles.Text = "Load files form folder";
            this.btnGetFiles.UseVisualStyleBackColor = false;
            this.btnGetFiles.Click += new System.EventHandler(this.btnGetFiles_Click);
            // 
            // dataGridViewFileDocTable
            // 
            this.dataGridViewFileDocTable.AllowDrop = true;
            this.dataGridViewFileDocTable.AllowUserToAddRows = false;
            this.dataGridViewFileDocTable.AllowUserToResizeRows = false;
            this.dataGridViewFileDocTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFileDocTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFileDocTable.Location = new System.Drawing.Point(3, 78);
            this.dataGridViewFileDocTable.Name = "dataGridViewFileDocTable";
            this.dataGridViewFileDocTable.ReadOnly = true;
            this.dataGridViewFileDocTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFileDocTable.Size = new System.Drawing.Size(966, 530);
            this.dataGridViewFileDocTable.TabIndex = 11;
            this.dataGridViewFileDocTable.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewDocs_DragDrop);
            this.dataGridViewFileDocTable.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridViewDocs_DragEnter);
            // 
            // tabControlDocuments
            // 
            this.tabControlDocuments.Controls.Add(this.tabManualSend);
            this.tabControlDocuments.Controls.Add(this.tabInbox);
            this.tabControlDocuments.Controls.Add(this.tabOutbox);
            this.tabControlDocuments.Controls.Add(this.tabResults);
            this.tabControlDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDocuments.Location = new System.Drawing.Point(0, 24);
            this.tabControlDocuments.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlDocuments.Name = "tabControlDocuments";
            this.tabControlDocuments.SelectedIndex = 0;
            this.tabControlDocuments.Size = new System.Drawing.Size(984, 641);
            this.tabControlDocuments.TabIndex = 5;
            // 
            // tabInbox
            // 
            this.tabInbox.Controls.Add(this.tableLayoutPanel2);
            this.tabInbox.Location = new System.Drawing.Point(4, 22);
            this.tabInbox.Margin = new System.Windows.Forms.Padding(2);
            this.tabInbox.Name = "tabInbox";
            this.tabInbox.Padding = new System.Windows.Forms.Padding(2);
            this.tabInbox.Size = new System.Drawing.Size(976, 615);
            this.tabInbox.TabIndex = 0;
            this.tabInbox.Text = "Inbox";
            this.tabInbox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panelInboxTop, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewInboxDocTable, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(972, 611);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panelInboxTop
            // 
            this.panelInboxTop.Controls.Add(this.groupBox2);
            this.panelInboxTop.Controls.Add(this.groupBox1);
            this.panelInboxTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInboxTop.Location = new System.Drawing.Point(3, 3);
            this.panelInboxTop.Name = "panelInboxTop";
            this.panelInboxTop.Size = new System.Drawing.Size(966, 69);
            this.panelInboxTop.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonInboxRefresh);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 63);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // buttonInboxRefresh
            // 
            this.buttonInboxRefresh.Location = new System.Drawing.Point(6, 19);
            this.buttonInboxRefresh.Name = "buttonInboxRefresh";
            this.buttonInboxRefresh.Size = new System.Drawing.Size(99, 29);
            this.buttonInboxRefresh.TabIndex = 2;
            this.buttonInboxRefresh.Text = "Refresh";
            this.buttonInboxRefresh.UseVisualStyleBackColor = true;
            this.buttonInboxRefresh.Click += new System.EventHandler(this.buttonInboxRefresh_Click);
            // 
            // tabOutbox
            // 
            this.tabOutbox.Controls.Add(this.tableLayoutPanel3);
            this.tabOutbox.Location = new System.Drawing.Point(4, 22);
            this.tabOutbox.Margin = new System.Windows.Forms.Padding(2);
            this.tabOutbox.Name = "tabOutbox";
            this.tabOutbox.Padding = new System.Windows.Forms.Padding(2);
            this.tabOutbox.Size = new System.Drawing.Size(976, 615);
            this.tabOutbox.TabIndex = 1;
            this.tabOutbox.Text = "Outbox";
            this.tabOutbox.UseVisualStyleBackColor = true;
            // 
            // tabResults
            // 
            this.tabResults.BackColor = System.Drawing.Color.Transparent;
            this.tabResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabResults.Controls.Add(this.tabControl2);
            this.tabResults.Location = new System.Drawing.Point(4, 22);
            this.tabResults.Margin = new System.Windows.Forms.Padding(2);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(2);
            this.tabResults.Size = new System.Drawing.Size(976, 615);
            this.tabResults.TabIndex = 2;
            this.tabResults.Text = "Debug and logs";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabLogFeed);
            this.tabControl2.Controls.Add(this.tabPagePayload);
            this.tabControl2.Controls.Add(this.tabPageRequest);
            this.tabControl2.Controls.Add(this.tabPageResponse);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(2, 2);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(972, 611);
            this.tabControl2.TabIndex = 2;
            // 
            // tabLogFeed
            // 
            this.tabLogFeed.Controls.Add(this.listBoxLog);
            this.tabLogFeed.Location = new System.Drawing.Point(4, 22);
            this.tabLogFeed.Margin = new System.Windows.Forms.Padding(2);
            this.tabLogFeed.Name = "tabLogFeed";
            this.tabLogFeed.Padding = new System.Windows.Forms.Padding(2);
            this.tabLogFeed.Size = new System.Drawing.Size(964, 585);
            this.tabLogFeed.TabIndex = 1;
            this.tabLogFeed.Text = "Log";
            this.tabLogFeed.UseVisualStyleBackColor = true;
            // 
            // listBoxLog
            // 
            this.listBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(2, 2);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(960, 581);
            this.listBoxLog.TabIndex = 2;
            // 
            // tabPagePayload
            // 
            this.tabPagePayload.Controls.Add(this.textBoxPayload);
            this.tabPagePayload.Location = new System.Drawing.Point(4, 22);
            this.tabPagePayload.Margin = new System.Windows.Forms.Padding(2);
            this.tabPagePayload.Name = "tabPagePayload";
            this.tabPagePayload.Padding = new System.Windows.Forms.Padding(2);
            this.tabPagePayload.Size = new System.Drawing.Size(964, 585);
            this.tabPagePayload.TabIndex = 0;
            this.tabPagePayload.Text = "Last Payload";
            this.tabPagePayload.UseVisualStyleBackColor = true;
            // 
            // textBoxPayload
            // 
            this.textBoxPayload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPayload.Location = new System.Drawing.Point(2, 2);
            this.textBoxPayload.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPayload.Multiline = true;
            this.textBoxPayload.Name = "textBoxPayload";
            this.textBoxPayload.Size = new System.Drawing.Size(960, 581);
            this.textBoxPayload.TabIndex = 0;
            // 
            // tabPageRequest
            // 
            this.tabPageRequest.Controls.Add(this.textBoxRequest);
            this.tabPageRequest.Location = new System.Drawing.Point(4, 22);
            this.tabPageRequest.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageRequest.Name = "tabPageRequest";
            this.tabPageRequest.Size = new System.Drawing.Size(964, 585);
            this.tabPageRequest.TabIndex = 2;
            this.tabPageRequest.Text = "Last request";
            this.tabPageRequest.UseVisualStyleBackColor = true;
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRequest.Location = new System.Drawing.Point(0, 0);
            this.textBoxRequest.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRequest.Multiline = true;
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.Size = new System.Drawing.Size(964, 585);
            this.textBoxRequest.TabIndex = 2;
            // 
            // tabPageResponse
            // 
            this.tabPageResponse.Controls.Add(this.textBoxResponse);
            this.tabPageResponse.Location = new System.Drawing.Point(4, 22);
            this.tabPageResponse.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageResponse.Name = "tabPageResponse";
            this.tabPageResponse.Size = new System.Drawing.Size(964, 585);
            this.tabPageResponse.TabIndex = 3;
            this.tabPageResponse.Text = "Last response";
            this.tabPageResponse.UseVisualStyleBackColor = true;
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResponse.Location = new System.Drawing.Point(0, 0);
            this.textBoxResponse.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.Size = new System.Drawing.Size(964, 585);
            this.textBoxResponse.TabIndex = 1;
            // 
            // dataGridViewInboxDocTable
            // 
            this.dataGridViewInboxDocTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInboxDocTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInboxDocTable.Location = new System.Drawing.Point(3, 78);
            this.dataGridViewInboxDocTable.Name = "dataGridViewInboxDocTable";
            this.dataGridViewInboxDocTable.Size = new System.Drawing.Size(966, 530);
            this.dataGridViewInboxDocTable.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(234, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 63);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewOutboxDocTable, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(972, 611);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 69);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(234, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 63);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filters";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 63);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewOutboxDocTable
            // 
            this.dataGridViewOutboxDocTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutboxDocTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutboxDocTable.Location = new System.Drawing.Point(3, 78);
            this.dataGridViewOutboxDocTable.Name = "dataGridViewOutboxDocTable";
            this.dataGridViewOutboxDocTable.Size = new System.Drawing.Size(966, 530);
            this.dataGridViewOutboxDocTable.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 687);
            this.Controls.Add(this.tabControlDocuments);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "eVerbinding document exchange";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabManualSend.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelintop.ResumeLayout(false);
            this.groupActions.ResumeLayout(false);
            this.groupBoxFilesFromFiler.ResumeLayout(false);
            this.groupBoxFilesFromFiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileDocTable)).EndInit();
            this.tabControlDocuments.ResumeLayout(false);
            this.tabInbox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelInboxTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabOutbox.ResumeLayout(false);
            this.tabResults.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabLogFeed.ResumeLayout(false);
            this.tabPagePayload.ResumeLayout(false);
            this.tabPagePayload.PerformLayout();
            this.tabPageRequest.ResumeLayout(false);
            this.tabPageRequest.PerformLayout();
            this.tabPageResponse.ResumeLayout(false);
            this.tabPageResponse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInboxDocTable)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutboxDocTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem connectAndRefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabManualSend;
        private System.Windows.Forms.TabControl tabControlDocuments;
        private System.Windows.Forms.TabPage tabInbox;
        private System.Windows.Forms.TabPage tabOutbox;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabLogFeed;
        private System.Windows.Forms.TabPage tabPagePayload;
        public System.Windows.Forms.TextBox textBoxPayload;
        private System.Windows.Forms.TabPage tabPageRequest;
        public System.Windows.Forms.TextBox textBoxRequest;
        private System.Windows.Forms.TabPage tabPageResponse;
        public System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelintop;
        private System.Windows.Forms.GroupBox groupActions;
        private System.Windows.Forms.Button buttonSendDoc;
        private System.Windows.Forms.GroupBox groupBoxFilesFromFiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Button buttonDialog;
        private System.Windows.Forms.Button btnGetFiles;
        private System.Windows.Forms.DataGridView dataGridViewFileDocTable;
        private System.Windows.Forms.Button buttonSelectAllValid;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelInboxTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonInboxRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewInboxDocTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewOutboxDocTable;
    }
}

