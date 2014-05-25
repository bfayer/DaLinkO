namespace DaLinkO
{
    partial class Broadcast_Connection_Settings
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbWireless = new System.Windows.Forms.ComboBox();
            this.rbUSB = new System.Windows.Forms.RadioButton();
            this.rbWireless = new System.Windows.Forms.RadioButton();
            this.cbUSBPort = new System.Windows.Forms.ComboBox();
            this.cbUSBBaud = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConfigureClockTrigger = new System.Windows.Forms.Button();
            this.rbTrigOnClock = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDnTriggerInteval = new System.Windows.Forms.NumericUpDown();
            this.rbTrigOnTimer = new System.Windows.Forms.RadioButton();
            this.rbTrigOnDataRecieved = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnRemoveData = new System.Windows.Forms.Button();
            this.btnInsertConstant = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.btnFormatData = new System.Windows.Forms.Button();
            this.cbAutoCnctOnDataVis = new System.Windows.Forms.CheckBox();
            this.dgvTransmission = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnCheckTransmission = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTotalBytes = new System.Windows.Forms.TextBox();
            this.timerTransmissionDGVUpdater = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnTriggerInteval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransmission)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 28);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save and Exit";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(164, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(132, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(176, 22);
            this.tbName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(115, 17);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Broadcast name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbWireless);
            this.groupBox1.Controls.Add(this.rbUSB);
            this.groupBox1.Controls.Add(this.rbWireless);
            this.groupBox1.Controls.Add(this.cbUSBPort);
            this.groupBox1.Controls.Add(this.cbUSBBaud);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 167);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thing that goes grey";
            this.label4.Visible = false;
            // 
            // cbWireless
            // 
            this.cbWireless.Enabled = false;
            this.cbWireless.FormattingEnabled = true;
            this.cbWireless.Location = new System.Drawing.Point(172, 132);
            this.cbWireless.Name = "cbWireless";
            this.cbWireless.Size = new System.Drawing.Size(111, 24);
            this.cbWireless.TabIndex = 12;
            this.cbWireless.Visible = false;
            // 
            // rbUSB
            // 
            this.rbUSB.AutoSize = true;
            this.rbUSB.Checked = true;
            this.rbUSB.Location = new System.Drawing.Point(11, 21);
            this.rbUSB.Name = "rbUSB";
            this.rbUSB.Size = new System.Drawing.Size(57, 21);
            this.rbUSB.TabIndex = 8;
            this.rbUSB.TabStop = true;
            this.rbUSB.Text = "USB";
            this.rbUSB.UseVisualStyleBackColor = true;
            this.rbUSB.CheckedChanged += new System.EventHandler(this.rbUSB_CheckedChanged);
            // 
            // rbWireless
            // 
            this.rbWireless.AutoSize = true;
            this.rbWireless.Enabled = false;
            this.rbWireless.Location = new System.Drawing.Point(11, 102);
            this.rbWireless.Name = "rbWireless";
            this.rbWireless.Size = new System.Drawing.Size(170, 21);
            this.rbWireless.TabIndex = 11;
            this.rbWireless.Text = "Wireless -Arduino Yun";
            this.rbWireless.UseVisualStyleBackColor = true;
            this.rbWireless.Visible = false;
            this.rbWireless.CheckedChanged += new System.EventHandler(this.rbWireless_CheckedChanged);
            // 
            // cbUSBPort
            // 
            this.cbUSBPort.FormattingEnabled = true;
            this.cbUSBPort.Location = new System.Drawing.Point(117, 42);
            this.cbUSBPort.Name = "cbUSBPort";
            this.cbUSBPort.Size = new System.Drawing.Size(166, 24);
            this.cbUSBPort.TabIndex = 6;
            // 
            // cbUSBBaud
            // 
            this.cbUSBBaud.FormattingEnabled = true;
            this.cbUSBBaud.Location = new System.Drawing.Point(117, 72);
            this.cbUSBBaud.Name = "cbUSBBaud";
            this.cbUSBBaud.Size = new System.Drawing.Size(166, 24);
            this.cbUSBBaud.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Baud rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConfigureClockTrigger);
            this.groupBox2.Controls.Add(this.rbTrigOnClock);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numUpDnTriggerInteval);
            this.groupBox2.Controls.Add(this.rbTrigOnTimer);
            this.groupBox2.Controls.Add(this.rbTrigOnDataRecieved);
            this.groupBox2.Location = new System.Drawing.Point(16, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 144);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Broadcast trigger";
            // 
            // btnConfigureClockTrigger
            // 
            this.btnConfigureClockTrigger.Enabled = false;
            this.btnConfigureClockTrigger.Location = new System.Drawing.Point(198, 108);
            this.btnConfigureClockTrigger.Name = "btnConfigureClockTrigger";
            this.btnConfigureClockTrigger.Size = new System.Drawing.Size(84, 23);
            this.btnConfigureClockTrigger.TabIndex = 5;
            this.btnConfigureClockTrigger.Text = "Configure";
            this.btnConfigureClockTrigger.UseVisualStyleBackColor = true;
            this.btnConfigureClockTrigger.Visible = false;
            // 
            // rbTrigOnClock
            // 
            this.rbTrigOnClock.AutoSize = true;
            this.rbTrigOnClock.Enabled = false;
            this.rbTrigOnClock.Location = new System.Drawing.Point(10, 109);
            this.rbTrigOnClock.Name = "rbTrigOnClock";
            this.rbTrigOnClock.Size = new System.Drawing.Size(176, 21);
            this.rbTrigOnClock.TabIndex = 4;
            this.rbTrigOnClock.Text = "Scheduled on the clock";
            this.rbTrigOnClock.UseVisualStyleBackColor = true;
            this.rbTrigOnClock.Visible = false;
            this.rbTrigOnClock.CheckedChanged += new System.EventHandler(this.rbTrigOnClock_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Interval (milliseconds):";
            // 
            // numUpDnTriggerInteval
            // 
            this.numUpDnTriggerInteval.Enabled = false;
            this.numUpDnTriggerInteval.Location = new System.Drawing.Point(198, 78);
            this.numUpDnTriggerInteval.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numUpDnTriggerInteval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnTriggerInteval.Name = "numUpDnTriggerInteval";
            this.numUpDnTriggerInteval.Size = new System.Drawing.Size(84, 22);
            this.numUpDnTriggerInteval.TabIndex = 2;
            this.numUpDnTriggerInteval.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // rbTrigOnTimer
            // 
            this.rbTrigOnTimer.AutoSize = true;
            this.rbTrigOnTimer.Location = new System.Drawing.Point(10, 57);
            this.rbTrigOnTimer.Name = "rbTrigOnTimer";
            this.rbTrigOnTimer.Size = new System.Drawing.Size(95, 21);
            this.rbTrigOnTimer.TabIndex = 1;
            this.rbTrigOnTimer.Text = "On a timer";
            this.rbTrigOnTimer.UseVisualStyleBackColor = true;
            this.rbTrigOnTimer.CheckedChanged += new System.EventHandler(this.rbTrigOnTimer_CheckedChanged);
            // 
            // rbTrigOnDataRecieved
            // 
            this.rbTrigOnDataRecieved.AutoSize = true;
            this.rbTrigOnDataRecieved.Checked = true;
            this.rbTrigOnDataRecieved.Location = new System.Drawing.Point(10, 30);
            this.rbTrigOnDataRecieved.Name = "rbTrigOnDataRecieved";
            this.rbTrigOnDataRecieved.Size = new System.Drawing.Size(199, 21);
            this.rbTrigOnDataRecieved.TabIndex = 0;
            this.rbTrigOnDataRecieved.TabStop = true;
            this.rbTrigOnDataRecieved.Text = "When new data is recieved";
            this.rbTrigOnDataRecieved.UseVisualStyleBackColor = true;
            this.rbTrigOnDataRecieved.CheckedChanged += new System.EventHandler(this.rbTrigOnDataRecieved_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Transmission  (ordered from start to finish)";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(663, 26);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(82, 47);
            this.btnClearAll.TabIndex = 17;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnRemoveData
            // 
            this.btnRemoveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveData.Location = new System.Drawing.Point(521, 26);
            this.btnRemoveData.Name = "btnRemoveData";
            this.btnRemoveData.Size = new System.Drawing.Size(77, 47);
            this.btnRemoveData.TabIndex = 18;
            this.btnRemoveData.Text = "Remove";
            this.btnRemoveData.UseVisualStyleBackColor = true;
            this.btnRemoveData.Click += new System.EventHandler(this.btnRemoveData_Click);
            // 
            // btnInsertConstant
            // 
            this.btnInsertConstant.Location = new System.Drawing.Point(351, 26);
            this.btnInsertConstant.Name = "btnInsertConstant";
            this.btnInsertConstant.Size = new System.Drawing.Size(89, 47);
            this.btnInsertConstant.TabIndex = 19;
            this.btnInsertConstant.Text = "New constant";
            this.btnInsertConstant.UseVisualStyleBackColor = true;
            this.btnInsertConstant.Click += new System.EventHandler(this.btnInsertConstant_Click);
            // 
            // btnAddData
            // 
            this.btnAddData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddData.Location = new System.Drawing.Point(442, 26);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(77, 47);
            this.btnAddData.TabIndex = 20;
            this.btnAddData.Text = "Add data";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // btnFormatData
            // 
            this.btnFormatData.Location = new System.Drawing.Point(600, 26);
            this.btnFormatData.Name = "btnFormatData";
            this.btnFormatData.Size = new System.Drawing.Size(61, 47);
            this.btnFormatData.TabIndex = 21;
            this.btnFormatData.Text = "Edit";
            this.btnFormatData.UseVisualStyleBackColor = true;
            this.btnFormatData.Click += new System.EventHandler(this.btnFormatData_Click);
            // 
            // cbAutoCnctOnDataVis
            // 
            this.cbAutoCnctOnDataVis.AutoSize = true;
            this.cbAutoCnctOnDataVis.Enabled = false;
            this.cbAutoCnctOnDataVis.Location = new System.Drawing.Point(26, 363);
            this.cbAutoCnctOnDataVis.Name = "cbAutoCnctOnDataVis";
            this.cbAutoCnctOnDataVis.Size = new System.Drawing.Size(246, 38);
            this.cbAutoCnctOnDataVis.TabIndex = 22;
            this.cbAutoCnctOnDataVis.Text = "Attempt to automatically connect \r\nwhen data sources become visible";
            this.cbAutoCnctOnDataVis.UseVisualStyleBackColor = true;
            this.cbAutoCnctOnDataVis.Visible = false;
            // 
            // dgvTransmission
            // 
            this.dgvTransmission.AllowUserToAddRows = false;
            this.dgvTransmission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransmission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransmission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column4,
            this.Column1,
            this.Column2,
            this.Bytes});
            this.dgvTransmission.Location = new System.Drawing.Point(351, 77);
            this.dgvTransmission.MultiSelect = false;
            this.dgvTransmission.Name = "dgvTransmission";
            this.dgvTransmission.RowHeadersVisible = false;
            this.dgvTransmission.RowTemplate.Height = 24;
            this.dgvTransmission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransmission.Size = new System.Drawing.Size(393, 296);
            this.dgvTransmission.TabIndex = 23;
            this.dgvTransmission.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvTransmission_RowPostPaint);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Index";
            this.Column5.Name = "Column5";
            this.Column5.Width = 45;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "elementName";
            this.Column4.HeaderText = "Element Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "elementValueAsText";
            this.Column1.HeaderText = "Value";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "type";
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            // 
            // Bytes
            // 
            this.Bytes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Bytes.DataPropertyName = "numberOfBytes";
            this.Bytes.HeaderText = "Bytes";
            this.Bytes.Name = "Bytes";
            this.Bytes.Width = 55;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveUp.Location = new System.Drawing.Point(318, 83);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(28, 37);
            this.btnMoveUp.TabIndex = 24;
            this.btnMoveUp.Text = "↑";
            this.btnMoveUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveDown.Location = new System.Drawing.Point(318, 126);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(28, 37);
            this.btnMoveDown.TabIndex = 25;
            this.btnMoveDown.Text = "↓";
            this.btnMoveDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnCheckTransmission
            // 
            this.btnCheckTransmission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckTransmission.Location = new System.Drawing.Point(535, 407);
            this.btnCheckTransmission.Name = "btnCheckTransmission";
            this.btnCheckTransmission.Size = new System.Drawing.Size(210, 29);
            this.btnCheckTransmission.TabIndex = 26;
            this.btnCheckTransmission.Text = "Check bytes (HEX)";
            this.btnCheckTransmission.UseVisualStyleBackColor = true;
            this.btnCheckTransmission.Click += new System.EventHandler(this.btnCheckTransmission_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Total bytes in transmission:";
            // 
            // tbTotalBytes
            // 
            this.tbTotalBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalBytes.Location = new System.Drawing.Point(645, 379);
            this.tbTotalBytes.Name = "tbTotalBytes";
            this.tbTotalBytes.ReadOnly = true;
            this.tbTotalBytes.Size = new System.Drawing.Size(100, 22);
            this.tbTotalBytes.TabIndex = 28;
            // 
            // timerTransmissionDGVUpdater
            // 
            this.timerTransmissionDGVUpdater.Tick += new System.EventHandler(this.timerTransmissionDGVUpdater_Tick);
            // 
            // BeanCaster_Connection_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(757, 449);
            this.ControlBox = false;
            this.Controls.Add(this.tbTotalBytes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCheckTransmission);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.dgvTransmission);
            this.Controls.Add(this.cbAutoCnctOnDataVis);
            this.Controls.Add(this.btnFormatData);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.btnInsertConstant);
            this.Controls.Add(this.btnRemoveData);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MinimumSize = new System.Drawing.Size(775, 495);
            this.Name = "BeanCaster_Connection_Settings";
            this.Text = "BeanCaster_Connection_Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnTriggerInteval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransmission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbWireless;
        private System.Windows.Forms.RadioButton rbUSB;
        private System.Windows.Forms.RadioButton rbWireless;
        private System.Windows.Forms.ComboBox cbUSBPort;
        private System.Windows.Forms.ComboBox cbUSBBaud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDnTriggerInteval;
        private System.Windows.Forms.RadioButton rbTrigOnTimer;
        private System.Windows.Forms.RadioButton rbTrigOnDataRecieved;
        private System.Windows.Forms.Button btnConfigureClockTrigger;
        private System.Windows.Forms.RadioButton rbTrigOnClock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnRemoveData;
        private System.Windows.Forms.Button btnInsertConstant;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Button btnFormatData;
        private System.Windows.Forms.CheckBox cbAutoCnctOnDataVis;
        private System.Windows.Forms.DataGridView dgvTransmission;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnCheckTransmission;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTotalBytes;
        private System.Windows.Forms.Timer timerTransmissionDGVUpdater;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bytes;
    }
}