namespace BayWynCouriersWinForm
{
    partial class Home
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
            this.panelBar = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnDeliveries = new System.Windows.Forms.Button();
            this.btnAssignments = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.IconPanel = new System.Windows.Forms.Panel();
            this.panelClients = new System.Windows.Forms.Panel();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.ContractDatePick = new System.Windows.Forms.DateTimePicker();
            this.lbClientRef = new System.Windows.Forms.Label();
            this.tbBEmail = new System.Windows.Forms.TextBox();
            this.tbBTel = new System.Windows.Forms.TextBox();
            this.tbBNotes = new System.Windows.Forms.TextBox();
            this.tbBAdd = new System.Windows.Forms.TextBox();
            this.tbBName = new System.Windows.Forms.TextBox();
            this.cbClientType = new System.Windows.Forms.ComboBox();
            this.lbCRN = new System.Windows.Forms.Label();
            this.lbNotes = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbBEmail = new System.Windows.Forms.Label();
            this.lbBAdd = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.panelDeliveries = new System.Windows.Forms.Panel();
            this.cbCourier = new System.Windows.Forms.ComboBox();
            this.btnBookDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cbDeliverySlot = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelReports = new System.Windows.Forms.Panel();
            this.btnGenReport = new System.Windows.Forms.Button();
            this.cbReports = new System.Windows.Forms.ComboBox();
            this.dataGridReports = new System.Windows.Forms.DataGridView();
            this.panelAssignments = new System.Windows.Forms.Panel();
            this.dataGridAssignments = new System.Windows.Forms.DataGridView();
            this.panelBar.SuspendLayout();
            this.panelClients.SuspendLayout();
            this.panelDeliveries.SuspendLayout();
            this.panelReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReports)).BeginInit();
            this.panelAssignments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBar.Controls.Add(this.btnReports);
            this.panelBar.Controls.Add(this.btnDeliveries);
            this.panelBar.Controls.Add(this.btnAssignments);
            this.panelBar.Controls.Add(this.btnClients);
            this.panelBar.Controls.Add(this.IconPanel);
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(220, 589);
            this.panelBar.TabIndex = 0;
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReports.Location = new System.Drawing.Point(0, 280);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(220, 60);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnDeliveries
            // 
            this.btnDeliveries.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeliveries.FlatAppearance.BorderSize = 0;
            this.btnDeliveries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliveries.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeliveries.Location = new System.Drawing.Point(0, 220);
            this.btnDeliveries.Name = "btnDeliveries";
            this.btnDeliveries.Size = new System.Drawing.Size(220, 60);
            this.btnDeliveries.TabIndex = 3;
            this.btnDeliveries.Text = "Deliveries";
            this.btnDeliveries.UseVisualStyleBackColor = true;
            this.btnDeliveries.Click += new System.EventHandler(this.btnDeliveries_Click);
            // 
            // btnAssignments
            // 
            this.btnAssignments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssignments.FlatAppearance.BorderSize = 0;
            this.btnAssignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignments.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAssignments.Location = new System.Drawing.Point(0, 160);
            this.btnAssignments.Name = "btnAssignments";
            this.btnAssignments.Size = new System.Drawing.Size(220, 60);
            this.btnAssignments.TabIndex = 2;
            this.btnAssignments.Tag = "3and4only";
            this.btnAssignments.Text = "Assignments";
            this.btnAssignments.UseVisualStyleBackColor = true;
            this.btnAssignments.Click += new System.EventHandler(this.btnAssignments_Click);
            // 
            // btnClients
            // 
            this.btnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClients.Location = new System.Drawing.Point(0, 100);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(220, 60);
            this.btnClients.TabIndex = 1;
            this.btnClients.Tag = "";
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // IconPanel
            // 
            this.IconPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.IconPanel.Location = new System.Drawing.Point(0, 0);
            this.IconPanel.Name = "IconPanel";
            this.IconPanel.Size = new System.Drawing.Size(220, 100);
            this.IconPanel.TabIndex = 0;
            // 
            // panelClients
            // 
            this.panelClients.Controls.Add(this.btnAddClient);
            this.panelClients.Controls.Add(this.ContractDatePick);
            this.panelClients.Controls.Add(this.lbClientRef);
            this.panelClients.Controls.Add(this.tbBEmail);
            this.panelClients.Controls.Add(this.tbBTel);
            this.panelClients.Controls.Add(this.tbBNotes);
            this.panelClients.Controls.Add(this.tbBAdd);
            this.panelClients.Controls.Add(this.tbBName);
            this.panelClients.Controls.Add(this.cbClientType);
            this.panelClients.Controls.Add(this.lbCRN);
            this.panelClients.Controls.Add(this.lbNotes);
            this.panelClients.Controls.Add(this.lbTel);
            this.panelClients.Controls.Add(this.lbBEmail);
            this.panelClients.Controls.Add(this.lbBAdd);
            this.panelClients.Controls.Add(this.lbName);
            this.panelClients.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelClients.Location = new System.Drawing.Point(239, 0);
            this.panelClients.Name = "panelClients";
            this.panelClients.Size = new System.Drawing.Size(694, 588);
            this.panelClients.TabIndex = 2;
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddClient.Location = new System.Drawing.Point(210, 501);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(120, 45);
            this.btnAddClient.TabIndex = 5;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = false;
            // 
            // ContractDatePick
            // 
            this.ContractDatePick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ContractDatePick.Location = new System.Drawing.Point(462, 75);
            this.ContractDatePick.Name = "ContractDatePick";
            this.ContractDatePick.Size = new System.Drawing.Size(121, 34);
            this.ContractDatePick.TabIndex = 14;
            // 
            // lbClientRef
            // 
            this.lbClientRef.AutoSize = true;
            this.lbClientRef.Location = new System.Drawing.Point(86, 61);
            this.lbClientRef.Name = "lbClientRef";
            this.lbClientRef.Size = new System.Drawing.Size(155, 28);
            this.lbClientRef.TabIndex = 13;
            this.lbClientRef.Text = "Client Reference:";
            // 
            // tbBEmail
            // 
            this.tbBEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBEmail.Location = new System.Drawing.Point(343, 279);
            this.tbBEmail.MinimumSize = new System.Drawing.Size(100, 25);
            this.tbBEmail.Name = "tbBEmail";
            this.tbBEmail.Size = new System.Drawing.Size(240, 27);
            this.tbBEmail.TabIndex = 12;
            // 
            // tbBTel
            // 
            this.tbBTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBTel.Location = new System.Drawing.Point(90, 279);
            this.tbBTel.MinimumSize = new System.Drawing.Size(100, 25);
            this.tbBTel.Name = "tbBTel";
            this.tbBTel.Size = new System.Drawing.Size(240, 27);
            this.tbBTel.TabIndex = 11;
            // 
            // tbBNotes
            // 
            this.tbBNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBNotes.Location = new System.Drawing.Point(90, 339);
            this.tbBNotes.Multiline = true;
            this.tbBNotes.Name = "tbBNotes";
            this.tbBNotes.Size = new System.Drawing.Size(493, 122);
            this.tbBNotes.TabIndex = 10;
            // 
            // tbBAdd
            // 
            this.tbBAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBAdd.Location = new System.Drawing.Point(90, 190);
            this.tbBAdd.Multiline = true;
            this.tbBAdd.Name = "tbBAdd";
            this.tbBAdd.Size = new System.Drawing.Size(493, 56);
            this.tbBAdd.TabIndex = 8;
            // 
            // tbBName
            // 
            this.tbBName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBName.Location = new System.Drawing.Point(90, 130);
            this.tbBName.MinimumSize = new System.Drawing.Size(100, 25);
            this.tbBName.Name = "tbBName";
            this.tbBName.Size = new System.Drawing.Size(493, 27);
            this.tbBName.TabIndex = 7;
            // 
            // cbClientType
            // 
            this.cbClientType.BackColor = System.Drawing.Color.Lavender;
            this.cbClientType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClientType.FormattingEnabled = true;
            this.cbClientType.Items.AddRange(new object[] {
            "Contracted",
            "Non Contracted"});
            this.cbClientType.Location = new System.Drawing.Point(320, 75);
            this.cbClientType.Name = "cbClientType";
            this.cbClientType.Size = new System.Drawing.Size(121, 36);
            this.cbClientType.TabIndex = 6;
            this.cbClientType.Text = "Client Type";
            // 
            // lbCRN
            // 
            this.lbCRN.AutoSize = true;
            this.lbCRN.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbCRN.Location = new System.Drawing.Point(91, 80);
            this.lbCRN.MaximumSize = new System.Drawing.Size(20, 20);
            this.lbCRN.MinimumSize = new System.Drawing.Size(20, 20);
            this.lbCRN.Name = "lbCRN";
            this.lbCRN.Size = new System.Drawing.Size(20, 20);
            this.lbCRN.TabIndex = 5;
            // 
            // lbNotes
            // 
            this.lbNotes.AutoSize = true;
            this.lbNotes.Location = new System.Drawing.Point(86, 317);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(68, 28);
            this.lbNotes.TabIndex = 4;
            this.lbNotes.Text = "Notes:";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(86, 257);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(105, 28);
            this.lbTel.TabIndex = 3;
            this.lbTel.Text = "Telephone:";
            // 
            // lbBEmail
            // 
            this.lbBEmail.AutoSize = true;
            this.lbBEmail.Location = new System.Drawing.Point(339, 257);
            this.lbBEmail.Name = "lbBEmail";
            this.lbBEmail.Size = new System.Drawing.Size(63, 28);
            this.lbBEmail.TabIndex = 2;
            this.lbBEmail.Text = "Email:";
            // 
            // lbBAdd
            // 
            this.lbBAdd.AutoSize = true;
            this.lbBAdd.Location = new System.Drawing.Point(86, 168);
            this.lbBAdd.Name = "lbBAdd";
            this.lbBAdd.Size = new System.Drawing.Size(163, 28);
            this.lbBAdd.TabIndex = 1;
            this.lbBAdd.Text = "Business Address:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(86, 108);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(145, 28);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Business Name:";
            // 
            // panelDeliveries
            // 
            this.panelDeliveries.Controls.Add(this.cbCourier);
            this.panelDeliveries.Controls.Add(this.btnBookDel);
            this.panelDeliveries.Controls.Add(this.label1);
            this.panelDeliveries.Controls.Add(this.textBox1);
            this.panelDeliveries.Controls.Add(this.textBox2);
            this.panelDeliveries.Controls.Add(this.textBox4);
            this.panelDeliveries.Controls.Add(this.textBox5);
            this.panelDeliveries.Controls.Add(this.cbDeliverySlot);
            this.panelDeliveries.Controls.Add(this.label2);
            this.panelDeliveries.Controls.Add(this.label4);
            this.panelDeliveries.Controls.Add(this.label5);
            this.panelDeliveries.Controls.Add(this.label7);
            this.panelDeliveries.Location = new System.Drawing.Point(239, 0);
            this.panelDeliveries.Name = "panelDeliveries";
            this.panelDeliveries.Size = new System.Drawing.Size(694, 588);
            this.panelDeliveries.TabIndex = 15;
            // 
            // cbCourier
            // 
            this.cbCourier.BackColor = System.Drawing.Color.Lavender;
            this.cbCourier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCourier.FormattingEnabled = true;
            this.cbCourier.Items.AddRange(new object[] {
            "Contracted",
            "Non Contracted"});
            this.cbCourier.Location = new System.Drawing.Point(462, 75);
            this.cbCourier.Name = "cbCourier";
            this.cbCourier.Size = new System.Drawing.Size(121, 36);
            this.cbCourier.TabIndex = 14;
            this.cbCourier.Text = "Courier";
            // 
            // btnBookDel
            // 
            this.btnBookDel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBookDel.FlatAppearance.BorderSize = 0;
            this.btnBookDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookDel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBookDel.Location = new System.Drawing.Point(210, 501);
            this.btnBookDel.Name = "btnBookDel";
            this.btnBookDel.Size = new System.Drawing.Size(120, 45);
            this.btnBookDel.TabIndex = 5;
            this.btnBookDel.Text = "Book Delivery";
            this.btnBookDel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Client Reference:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(343, 279);
            this.textBox1.MinimumSize = new System.Drawing.Size(100, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 27);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(90, 279);
            this.textBox2.MinimumSize = new System.Drawing.Size(100, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 27);
            this.textBox2.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(90, 190);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(493, 56);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(90, 130);
            this.textBox5.MinimumSize = new System.Drawing.Size(100, 25);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(493, 27);
            this.textBox5.TabIndex = 7;
            // 
            // cbDeliverySlot
            // 
            this.cbDeliverySlot.BackColor = System.Drawing.Color.Lavender;
            this.cbDeliverySlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDeliverySlot.FormattingEnabled = true;
            this.cbDeliverySlot.Items.AddRange(new object[] {
            "Contracted",
            "Non Contracted"});
            this.cbDeliverySlot.Location = new System.Drawing.Point(320, 75);
            this.cbDeliverySlot.Name = "cbDeliverySlot";
            this.cbDeliverySlot.Size = new System.Drawing.Size(121, 36);
            this.cbDeliverySlot.TabIndex = 6;
            this.cbDeliverySlot.Text = "Delivery Slot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(91, 80);
            this.label2.MaximumSize = new System.Drawing.Size(20, 20);
            this.label2.MinimumSize = new System.Drawing.Size(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telephone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Business Name:";
            // 
            // panelReports
            // 
            this.panelReports.BackColor = System.Drawing.Color.Lavender;
            this.panelReports.Controls.Add(this.btnGenReport);
            this.panelReports.Controls.Add(this.cbReports);
            this.panelReports.Controls.Add(this.dataGridReports);
            this.panelReports.Location = new System.Drawing.Point(239, 0);
            this.panelReports.Name = "panelReports";
            this.panelReports.Size = new System.Drawing.Size(694, 588);
            this.panelReports.TabIndex = 16;
            // 
            // btnGenReport
            // 
            this.btnGenReport.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGenReport.FlatAppearance.BorderSize = 0;
            this.btnGenReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenReport.Location = new System.Drawing.Point(517, 38);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(142, 64);
            this.btnGenReport.TabIndex = 5;
            this.btnGenReport.Text = "Generate";
            this.btnGenReport.UseVisualStyleBackColor = false;
            this.btnGenReport.Click += new System.EventHandler(this.btnGenReport_Click);
            // 
            // cbReports
            // 
            this.cbReports.BackColor = System.Drawing.Color.Lavender;
            this.cbReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbReports.FormattingEnabled = true;
            this.cbReports.Location = new System.Drawing.Point(52, 53);
            this.cbReports.Name = "cbReports";
            this.cbReports.Size = new System.Drawing.Size(426, 36);
            this.cbReports.TabIndex = 15;
            this.cbReports.Text = "Reports";
            // 
            // dataGridReports
            // 
            this.dataGridReports.AllowUserToDeleteRows = false;
            this.dataGridReports.AllowUserToOrderColumns = true;
            this.dataGridReports.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReports.Location = new System.Drawing.Point(52, 119);
            this.dataGridReports.Name = "dataGridReports";
            this.dataGridReports.ReadOnly = true;
            this.dataGridReports.RowHeadersWidth = 62;
            this.dataGridReports.Size = new System.Drawing.Size(607, 427);
            this.dataGridReports.TabIndex = 6;
            // 
            // panelAssignments
            // 
            this.panelAssignments.BackColor = System.Drawing.Color.Lavender;
            this.panelAssignments.Controls.Add(this.dataGridAssignments);
            this.panelAssignments.Location = new System.Drawing.Point(238, 0);
            this.panelAssignments.Name = "panelAssignments";
            this.panelAssignments.Size = new System.Drawing.Size(694, 588);
            this.panelAssignments.TabIndex = 17;
            // 
            // dataGridAssignments
            // 
            this.dataGridAssignments.AllowUserToDeleteRows = false;
            this.dataGridAssignments.AllowUserToOrderColumns = true;
            this.dataGridAssignments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridAssignments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAssignments.Location = new System.Drawing.Point(52, 119);
            this.dataGridAssignments.Name = "dataGridAssignments";
            this.dataGridAssignments.ReadOnly = true;
            this.dataGridAssignments.RowHeadersWidth = 62;
            this.dataGridAssignments.Size = new System.Drawing.Size(607, 427);
            this.dataGridAssignments.TabIndex = 6;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.panelAssignments);
            this.Controls.Add(this.panelReports);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelDeliveries);
            this.Controls.Add(this.panelClients);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bay Wyn Couriers";
            this.panelBar.ResumeLayout(false);
            this.panelClients.ResumeLayout(false);
            this.panelClients.PerformLayout();
            this.panelDeliveries.ResumeLayout(false);
            this.panelDeliveries.PerformLayout();
            this.panelReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReports)).EndInit();
            this.panelAssignments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssignments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnDeliveries;
        private System.Windows.Forms.Button btnAssignments;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Panel IconPanel;
        private System.Windows.Forms.Panel panelClients;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.DateTimePicker ContractDatePick;
        private System.Windows.Forms.Label lbClientRef;
        private System.Windows.Forms.TextBox tbBEmail;
        private System.Windows.Forms.TextBox tbBTel;
        private System.Windows.Forms.TextBox tbBNotes;
        private System.Windows.Forms.TextBox tbBAdd;
        private System.Windows.Forms.TextBox tbBName;
        private System.Windows.Forms.ComboBox cbClientType;
        private System.Windows.Forms.Label lbCRN;
        private System.Windows.Forms.Label lbNotes;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbBEmail;
        private System.Windows.Forms.Label lbBAdd;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panelDeliveries;
        private System.Windows.Forms.Panel panelReports;
        private System.Windows.Forms.DataGridView dataGridReports;
        private System.Windows.Forms.ComboBox cbCourier;
        private System.Windows.Forms.Button btnBookDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox cbDeliverySlot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbReports;
        private System.Windows.Forms.Button btnGenReport;
        private System.Windows.Forms.Panel panelAssignments;
        private System.Windows.Forms.DataGridView dataGridAssignments;
    }
}

