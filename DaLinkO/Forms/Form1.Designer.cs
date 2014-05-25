namespace DaLinkO
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timerUiRoughRefresh = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProfileAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importBroadcastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.buttonClearVisibleSources = new System.Windows.Forms.Button();
            this.dgvSourceLog = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCreateNewBroadcast = new System.Windows.Forms.Button();
            this.btnEditBroadcast = new System.Windows.Forms.Button();
            this.btnDeleteBroadcast = new System.Windows.Forms.Button();
            this.dgvBroadcastList = new System.Windows.Forms.DataGridView();
            this.ConnectionButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Transmit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tbConsoleInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSourceDGV = new System.Windows.Forms.Label();
            this.tabModes = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnGenerateSketch = new System.Windows.Forms.Button();
            this.tabDebugPage = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonPauseDebug = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDebugMode = new System.Windows.Forms.TextBox();
            this.textBoxBeanVersionExample = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTransmissionVersionExample = new System.Windows.Forms.ComboBox();
            this.tabLiveData = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dgvSourceLiveData = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvBeanElementsLive = new System.Windows.Forms.DataGridView();
            this.nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beanElementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.broadcastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSourceLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBroadcastList)).BeginInit();
            this.tabModes.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabDebugPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabLiveData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSourceLiveData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeanElementsLive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beanElementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // timerUiRoughRefresh
            // 
            this.timerUiRoughRefresh.Tick += new System.EventHandler(this.timerUiRoughRefresh_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProfileToolStripMenuItem,
            this.saveProfileToolStripMenuItem,
            this.saveProfileAsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.importBroadcastToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadProfileToolStripMenuItem
            // 
            this.loadProfileToolStripMenuItem.Enabled = false;
            this.loadProfileToolStripMenuItem.Name = "loadProfileToolStripMenuItem";
            this.loadProfileToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.loadProfileToolStripMenuItem.Text = "Load Profile";
            // 
            // saveProfileToolStripMenuItem
            // 
            this.saveProfileToolStripMenuItem.Enabled = false;
            this.saveProfileToolStripMenuItem.Name = "saveProfileToolStripMenuItem";
            this.saveProfileToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.saveProfileToolStripMenuItem.Text = "Save Profile";
            // 
            // saveProfileAsToolStripMenuItem
            // 
            this.saveProfileAsToolStripMenuItem.Enabled = false;
            this.saveProfileAsToolStripMenuItem.Name = "saveProfileAsToolStripMenuItem";
            this.saveProfileAsToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.saveProfileAsToolStripMenuItem.Text = "Save Profile As";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.saveToolStripMenuItem.Text = "Export Broadcast";
            // 
            // importBroadcastToolStripMenuItem
            // 
            this.importBroadcastToolStripMenuItem.Enabled = false;
            this.importBroadcastToolStripMenuItem.Name = "importBroadcastToolStripMenuItem";
            this.importBroadcastToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.importBroadcastToolStripMenuItem.Text = "Import Broadcast";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Enabled = false;
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(121, 24);
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConsole.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBoxConsole.ForeColor = System.Drawing.Color.Lime;
            this.textBoxConsole.Location = new System.Drawing.Point(3, 227);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ReadOnly = true;
            this.textBoxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConsole.Size = new System.Drawing.Size(357, 290);
            this.textBoxConsole.TabIndex = 1;
            // 
            // buttonClearVisibleSources
            // 
            this.buttonClearVisibleSources.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearVisibleSources.Location = new System.Drawing.Point(294, 521);
            this.buttonClearVisibleSources.Name = "buttonClearVisibleSources";
            this.buttonClearVisibleSources.Size = new System.Drawing.Size(66, 26);
            this.buttonClearVisibleSources.TabIndex = 3;
            this.buttonClearVisibleSources.Text = "Clear";
            this.buttonClearVisibleSources.UseVisualStyleBackColor = true;
            this.buttonClearVisibleSources.Click += new System.EventHandler(this.buttonClearVisibleSources_Click);
            // 
            // dgvSourceLog
            // 
            this.dgvSourceLog.AllowUserToAddRows = false;
            this.dgvSourceLog.AllowUserToDeleteRows = false;
            this.dgvSourceLog.AllowUserToResizeRows = false;
            this.dgvSourceLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSourceLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSourceLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvSourceLog.Location = new System.Drawing.Point(3, 24);
            this.dgvSourceLog.MultiSelect = false;
            this.dgvSourceLog.Name = "dgvSourceLog";
            this.dgvSourceLog.ReadOnly = true;
            this.dgvSourceLog.RowHeadersVisible = false;
            this.dgvSourceLog.RowTemplate.Height = 24;
            this.dgvSourceLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSourceLog.Size = new System.Drawing.Size(357, 180);
            this.dgvSourceLog.TabIndex = 7;
            this.dgvSourceLog.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSourceLog_CellDoubleClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Src";
            this.Column5.HeaderText = "Source";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "LastActiveTime";
            this.Column6.HeaderText = "Last Recieved";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 130;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "v";
            this.Column7.HeaderText = "Version";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // buttonCreateNewBroadcast
            // 
            this.buttonCreateNewBroadcast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateNewBroadcast.Location = new System.Drawing.Point(3, 522);
            this.buttonCreateNewBroadcast.Name = "buttonCreateNewBroadcast";
            this.buttonCreateNewBroadcast.Size = new System.Drawing.Size(91, 25);
            this.buttonCreateNewBroadcast.TabIndex = 9;
            this.buttonCreateNewBroadcast.Text = "Create new";
            this.buttonCreateNewBroadcast.UseVisualStyleBackColor = true;
            this.buttonCreateNewBroadcast.Click += new System.EventHandler(this.buttonCreateNewBroadcast_Click);
            // 
            // btnEditBroadcast
            // 
            this.btnEditBroadcast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditBroadcast.Location = new System.Drawing.Point(100, 522);
            this.btnEditBroadcast.Name = "btnEditBroadcast";
            this.btnEditBroadcast.Size = new System.Drawing.Size(46, 25);
            this.btnEditBroadcast.TabIndex = 11;
            this.btnEditBroadcast.Text = "Edit";
            this.btnEditBroadcast.UseVisualStyleBackColor = true;
            this.btnEditBroadcast.Click += new System.EventHandler(this.btnEditBroadcast_Click);
            // 
            // btnDeleteBroadcast
            // 
            this.btnDeleteBroadcast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteBroadcast.Location = new System.Drawing.Point(152, 522);
            this.btnDeleteBroadcast.Name = "btnDeleteBroadcast";
            this.btnDeleteBroadcast.Size = new System.Drawing.Size(65, 25);
            this.btnDeleteBroadcast.TabIndex = 12;
            this.btnDeleteBroadcast.Text = "Delete";
            this.btnDeleteBroadcast.UseVisualStyleBackColor = true;
            this.btnDeleteBroadcast.Click += new System.EventHandler(this.btnDeleteBroadcast_Click);
            // 
            // dgvBroadcastList
            // 
            this.dgvBroadcastList.AllowUserToAddRows = false;
            this.dgvBroadcastList.AllowUserToOrderColumns = true;
            this.dgvBroadcastList.AllowUserToResizeRows = false;
            this.dgvBroadcastList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBroadcastList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBroadcastList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConnectionButton,
            this.Transmit,
            this.Column1,
            this.Column3,
            this.Column2});
            this.dgvBroadcastList.Location = new System.Drawing.Point(3, 20);
            this.dgvBroadcastList.Name = "dgvBroadcastList";
            this.dgvBroadcastList.RowHeadersVisible = false;
            this.dgvBroadcastList.RowTemplate.Height = 24;
            this.dgvBroadcastList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBroadcastList.Size = new System.Drawing.Size(536, 496);
            this.dgvBroadcastList.TabIndex = 13;
            this.dgvBroadcastList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBroadcastList_CellClick);
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.DataPropertyName = "buttonConnectText";
            this.ConnectionButton.HeaderText = "Connect";
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ConnectionButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ConnectionButton.Text = "";
            this.ConnectionButton.Width = 82;
            // 
            // Transmit
            // 
            this.Transmit.DataPropertyName = "transmitCheck";
            this.Transmit.HeaderText = "Send";
            this.Transmit.Name = "Transmit";
            this.Transmit.ReadOnly = true;
            this.Transmit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Transmit.Width = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "name";
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 70;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "connectionInfo";
            this.Column3.HeaderText = "Connection info";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 210;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "status";
            this.Column2.HeaderText = "Status";
            this.Column2.Name = "Column2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Console for selected broadcast";
            // 
            // tbConsoleInput
            // 
            this.tbConsoleInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConsoleInput.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbConsoleInput.ForeColor = System.Drawing.Color.Lime;
            this.tbConsoleInput.Location = new System.Drawing.Point(3, 523);
            this.tbConsoleInput.Name = "tbConsoleInput";
            this.tbConsoleInput.Size = new System.Drawing.Size(291, 22);
            this.tbConsoleInput.TabIndex = 17;
            this.tbConsoleInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbConsoleInput_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Broadcasts ";
            // 
            // labelSourceDGV
            // 
            this.labelSourceDGV.AutoSize = true;
            this.labelSourceDGV.Location = new System.Drawing.Point(3, 4);
            this.labelSourceDGV.Name = "labelSourceDGV";
            this.labelSourceDGV.Size = new System.Drawing.Size(135, 17);
            this.labelSourceDGV.TabIndex = 8;
            this.labelSourceDGV.Text = "Visible data sources";
            // 
            // tabModes
            // 
            this.tabModes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabModes.Controls.Add(this.tabDashboard);
            this.tabModes.Controls.Add(this.tabDebugPage);
            this.tabModes.Controls.Add(this.tabLiveData);
            this.tabModes.Location = new System.Drawing.Point(-2, 29);
            this.tabModes.Name = "tabModes";
            this.tabModes.SelectedIndex = 0;
            this.tabModes.Size = new System.Drawing.Size(926, 582);
            this.tabModes.TabIndex = 21;
            this.tabModes.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabModes_Selected);
            // 
            // tabDashboard
            // 
            this.tabDashboard.BackColor = System.Drawing.Color.White;
            this.tabDashboard.Controls.Add(this.splitContainer1);
            this.tabDashboard.Location = new System.Drawing.Point(4, 25);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(918, 553);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.btnGenerateSketch);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditBroadcast);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteBroadcast);
            this.splitContainer1.Panel1.Controls.Add(this.dgvBroadcastList);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCreateNewBroadcast);
            this.splitContainer1.Panel1MinSize = 500;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.dgvSourceLog);
            this.splitContainer1.Panel2.Controls.Add(this.labelSourceDGV);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxConsole);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.buttonClearVisibleSources);
            this.splitContainer1.Panel2.Controls.Add(this.tbConsoleInput);
            this.splitContainer1.Panel2MinSize = 300;
            this.splitContainer1.Size = new System.Drawing.Size(912, 547);
            this.splitContainer1.SplitterDistance = 542;
            this.splitContainer1.TabIndex = 20;
            // 
            // btnGenerateSketch
            // 
            this.btnGenerateSketch.Enabled = false;
            this.btnGenerateSketch.Location = new System.Drawing.Point(223, 522);
            this.btnGenerateSketch.Name = "btnGenerateSketch";
            this.btnGenerateSketch.Size = new System.Drawing.Size(174, 25);
            this.btnGenerateSketch.TabIndex = 20;
            this.btnGenerateSketch.Text = "Generate Arduino sketch";
            this.btnGenerateSketch.UseVisualStyleBackColor = true;
            // 
            // tabDebugPage
            // 
            this.tabDebugPage.BackColor = System.Drawing.Color.White;
            this.tabDebugPage.Controls.Add(this.label8);
            this.tabDebugPage.Controls.Add(this.splitContainer2);
            this.tabDebugPage.Location = new System.Drawing.Point(4, 25);
            this.tabDebugPage.Name = "tabDebugPage";
            this.tabDebugPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabDebugPage.Size = new System.Drawing.Size(918, 553);
            this.tabDebugPage.TabIndex = 1;
            this.tabDebugPage.Text = "Mod debugging";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(767, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "*INCOMING DATA IS NOT PROCESSED WHEN VIEWING THIS TAB. ACTIVE BROADCASTS WILL NOT" +
    " RECIEVE DATA*";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Location = new System.Drawing.Point(6, 23);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonPauseDebug);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxDebugMode);
            this.splitContainer2.Panel1MinSize = 400;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBoxBeanVersionExample);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.cbTransmissionVersionExample);
            this.splitContainer2.Panel2MinSize = 300;
            this.splitContainer2.Size = new System.Drawing.Size(906, 523);
            this.splitContainer2.SplitterDistance = 507;
            this.splitContainer2.TabIndex = 8;
            // 
            // buttonPauseDebug
            // 
            this.buttonPauseDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPauseDebug.Location = new System.Drawing.Point(405, 8);
            this.buttonPauseDebug.Name = "buttonPauseDebug";
            this.buttonPauseDebug.Size = new System.Drawing.Size(97, 24);
            this.buttonPauseDebug.TabIndex = 6;
            this.buttonPauseDebug.Text = "Pause";
            this.buttonPauseDebug.UseVisualStyleBackColor = true;
            this.buttonPauseDebug.Click += new System.EventHandler(this.buttonPauseDebug_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Transmission text as recieved from source";
            // 
            // textBoxDebugMode
            // 
            this.textBoxDebugMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDebugMode.Location = new System.Drawing.Point(4, 35);
            this.textBoxDebugMode.Multiline = true;
            this.textBoxDebugMode.Name = "textBoxDebugMode";
            this.textBoxDebugMode.Size = new System.Drawing.Size(498, 478);
            this.textBoxDebugMode.TabIndex = 0;
            // 
            // textBoxBeanVersionExample
            // 
            this.textBoxBeanVersionExample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBeanVersionExample.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxBeanVersionExample.Location = new System.Drawing.Point(3, 35);
            this.textBoxBeanVersionExample.Multiline = true;
            this.textBoxBeanVersionExample.Name = "textBoxBeanVersionExample";
            this.textBoxBeanVersionExample.ReadOnly = true;
            this.textBoxBeanVersionExample.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBeanVersionExample.Size = new System.Drawing.Size(385, 481);
            this.textBoxBeanVersionExample.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Example XML data structure";
            // 
            // cbTransmissionVersionExample
            // 
            this.cbTransmissionVersionExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTransmissionVersionExample.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransmissionVersionExample.FormattingEnabled = true;
            this.cbTransmissionVersionExample.Location = new System.Drawing.Point(278, 9);
            this.cbTransmissionVersionExample.Name = "cbTransmissionVersionExample";
            this.cbTransmissionVersionExample.Size = new System.Drawing.Size(112, 24);
            this.cbTransmissionVersionExample.TabIndex = 2;
            this.cbTransmissionVersionExample.SelectedIndexChanged += new System.EventHandler(this.cbTransmissionVersionExample_SelectedIndexChanged);
            // 
            // tabLiveData
            // 
            this.tabLiveData.Controls.Add(this.splitContainer3);
            this.tabLiveData.Location = new System.Drawing.Point(4, 25);
            this.tabLiveData.Name = "tabLiveData";
            this.tabLiveData.Padding = new System.Windows.Forms.Padding(3);
            this.tabLiveData.Size = new System.Drawing.Size(918, 553);
            this.tabLiveData.TabIndex = 2;
            this.tabLiveData.Text = "Live data";
            this.tabLiveData.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Location = new System.Drawing.Point(6, 7);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dgvSourceLiveData);
            this.splitContainer3.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label7);
            this.splitContainer3.Panel2.Controls.Add(this.dgvBeanElementsLive);
            this.splitContainer3.Size = new System.Drawing.Size(906, 541);
            this.splitContainer3.SplitterDistance = 456;
            this.splitContainer3.TabIndex = 4;
            // 
            // dgvSourceLiveData
            // 
            this.dgvSourceLiveData.AllowUserToAddRows = false;
            this.dgvSourceLiveData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSourceLiveData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSourceLiveData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column12});
            this.dgvSourceLiveData.Location = new System.Drawing.Point(3, 24);
            this.dgvSourceLiveData.MultiSelect = false;
            this.dgvSourceLiveData.Name = "dgvSourceLiveData";
            this.dgvSourceLiveData.ReadOnly = true;
            this.dgvSourceLiveData.RowHeadersVisible = false;
            this.dgvSourceLiveData.RowTemplate.Height = 24;
            this.dgvSourceLiveData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSourceLiveData.Size = new System.Drawing.Size(448, 517);
            this.dgvSourceLiveData.TabIndex = 0;
            this.dgvSourceLiveData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSourceLiveData_CellClick);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Src";
            this.Column8.HeaderText = "Source";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 160;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "LastActiveTime";
            this.Column9.HeaderText = "Last heard from";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 150;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.DataPropertyName = "v";
            this.Column12.HeaderText = "Mod Version";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Visible sources";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Elements within selected source";
            // 
            // dgvBeanElementsLive
            // 
            this.dgvBeanElementsLive.AllowUserToAddRows = false;
            this.dgvBeanElementsLive.AllowUserToResizeRows = false;
            this.dgvBeanElementsLive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBeanElementsLive.AutoGenerateColumns = false;
            this.dgvBeanElementsLive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeanElementsLive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nDataGridViewTextBoxColumn,
            this.tDataGridViewTextBoxColumn,
            this.vDataGridViewTextBoxColumn});
            this.dgvBeanElementsLive.DataSource = this.beanElementBindingSource;
            this.dgvBeanElementsLive.Location = new System.Drawing.Point(3, 24);
            this.dgvBeanElementsLive.Name = "dgvBeanElementsLive";
            this.dgvBeanElementsLive.ReadOnly = true;
            this.dgvBeanElementsLive.RowHeadersVisible = false;
            this.dgvBeanElementsLive.RowTemplate.Height = 24;
            this.dgvBeanElementsLive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeanElementsLive.Size = new System.Drawing.Size(439, 513);
            this.dgvBeanElementsLive.TabIndex = 1;
            // 
            // nDataGridViewTextBoxColumn
            // 
            this.nDataGridViewTextBoxColumn.DataPropertyName = "N";
            this.nDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nDataGridViewTextBoxColumn.Name = "nDataGridViewTextBoxColumn";
            this.nDataGridViewTextBoxColumn.ReadOnly = true;
            this.nDataGridViewTextBoxColumn.Width = 150;
            // 
            // tDataGridViewTextBoxColumn
            // 
            this.tDataGridViewTextBoxColumn.DataPropertyName = "T";
            this.tDataGridViewTextBoxColumn.HeaderText = "Type";
            this.tDataGridViewTextBoxColumn.Name = "tDataGridViewTextBoxColumn";
            this.tDataGridViewTextBoxColumn.ReadOnly = true;
            this.tDataGridViewTextBoxColumn.Width = 150;
            // 
            // vDataGridViewTextBoxColumn
            // 
            this.vDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vDataGridViewTextBoxColumn.DataPropertyName = "V";
            this.vDataGridViewTextBoxColumn.HeaderText = "Value";
            this.vDataGridViewTextBoxColumn.Name = "vDataGridViewTextBoxColumn";
            this.vDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beanElementBindingSource
            // 
            this.beanElementBindingSource.DataSource = typeof(DaLinkO.DE);
            // 
            // broadcastBindingSource
            // 
            this.broadcastBindingSource.DataSource = typeof(DaLinkO.Broadcast);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(920, 610);
            this.Controls.Add(this.tabModes);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form1";
            this.Text = "DaLinkO (alpha)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSourceLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBroadcastList)).EndInit();
            this.tabModes.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabDebugPage.ResumeLayout(false);
            this.tabDebugPage.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabLiveData.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSourceLiveData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeanElementsLive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beanElementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerUiRoughRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProfileAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importBroadcastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.Button buttonClearVisibleSources;
        private System.Windows.Forms.DataGridView dgvSourceLog;
        private System.Windows.Forms.Button buttonCreateNewBroadcast;
        private System.Windows.Forms.Button btnEditBroadcast;
        private System.Windows.Forms.Button btnDeleteBroadcast;
        private System.Windows.Forms.DataGridView dgvBroadcastList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbConsoleInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSourceDGV;
        private System.Windows.Forms.TabControl tabModes;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabDebugPage;
        private System.Windows.Forms.TextBox textBoxBeanVersionExample;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTransmissionVersionExample;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDebugMode;
        private System.Windows.Forms.Button buttonPauseDebug;
        private System.Windows.Forms.TabPage tabLiveData;
        private System.Windows.Forms.DataGridView dgvSourceLiveData;
        private System.Windows.Forms.BindingSource broadcastBindingSource;
        private System.Windows.Forms.DataGridView dgvBeanElementsLive;
        private System.Windows.Forms.BindingSource beanElementBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewButtonColumn ConnectionButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Transmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGenerateSketch;
    }
}

