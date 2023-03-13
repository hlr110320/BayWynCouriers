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
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUser = new System.Windows.Forms.Label();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnDeliveries = new System.Windows.Forms.Button();
            this.btnAssignments = new System.Windows.Forms.Button();
            this.panelClients = new System.Windows.Forms.Panel();
            this.tabContracts = new System.Windows.Forms.TabControl();
            this.tabC1 = new System.Windows.Forms.TabPage();
            this.btnCreateContract = new System.Windows.Forms.Button();
            this.cbClientType = new System.Windows.Forms.ComboBox();
            this.tbCourierRuns = new System.Windows.Forms.TextBox();
            this.ContractRuns = new System.Windows.Forms.Label();
            this.btnCClear = new System.Windows.Forms.Button();
            this.tbBEmail = new System.Windows.Forms.TextBox();
            this.tbBTel = new System.Windows.Forms.TextBox();
            this.tbBNotes = new System.Windows.Forms.TextBox();
            this.tbBAdd = new System.Windows.Forms.TextBox();
            this.tbBName = new System.Windows.Forms.TextBox();
            this.lbNotes = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbBEmail = new System.Windows.Forms.Label();
            this.lbBAdd = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tabC2 = new System.Windows.Forms.TabPage();
            this.tabC3 = new System.Windows.Forms.TabPage();
            this.lbClientRef = new System.Windows.Forms.Label();
            this.lbCRN = new System.Windows.Forms.Label();
            this.panelDeliveries = new System.Windows.Forms.Panel();
            this.cbBName = new System.Windows.Forms.ComboBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridBookSlots = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBookDel = new System.Windows.Forms.Button();
            this.deliveryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelReports = new System.Windows.Forms.Panel();
            this.btnGenReport = new System.Windows.Forms.Button();
            this.cbReports = new System.Windows.Forms.ComboBox();
            this.dataGridReports = new System.Windows.Forms.DataGridView();
            this.panelAssignments = new System.Windows.Forms.Panel();
            this.cbAssignments = new System.Windows.Forms.ComboBox();
            this.btnAssignmentsSave = new System.Windows.Forms.Button();
            this.btnAssignmentsLoad = new System.Windows.Forms.Button();
            this.dataGridAssignments = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IconPanel = new System.Windows.Forms.Panel();
            this.panelBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelClients.SuspendLayout();
            this.tabContracts.SuspendLayout();
            this.tabC1.SuspendLayout();
            this.panelDeliveries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookSlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReports)).BeginInit();
            this.panelAssignments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssignments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.IconPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBar.Controls.Add(this.btnLogout);
            this.panelBar.Controls.Add(this.panel1);
            this.panelBar.Controls.Add(this.btnContracts);
            this.panelBar.Controls.Add(this.btnReports);
            this.panelBar.Controls.Add(this.btnDeliveries);
            this.panelBar.Controls.Add(this.btnAssignments);
            this.panelBar.Controls.Add(this.IconPanel);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(220, 900);
            this.panelBar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(0, 654);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 60);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Tag = "";
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 489);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 165);
            this.panel1.TabIndex = 6;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbUser.Location = new System.Drawing.Point(10, 86);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(0, 21);
            this.lbUser.TabIndex = 5;
            // 
            // btnContracts
            // 
            this.btnContracts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContracts.FlatAppearance.BorderSize = 0;
            this.btnContracts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnContracts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContracts.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContracts.ForeColor = System.Drawing.SystemColors.Control;
            this.btnContracts.Location = new System.Drawing.Point(0, 429);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(220, 60);
            this.btnContracts.TabIndex = 4;
            this.btnContracts.Tag = "";
            this.btnContracts.Text = "Contracts";
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.BtnContracts_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReports.Location = new System.Drawing.Point(0, 369);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(220, 60);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // btnDeliveries
            // 
            this.btnDeliveries.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeliveries.FlatAppearance.BorderSize = 0;
            this.btnDeliveries.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeliveries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeliveries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliveries.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliveries.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeliveries.Location = new System.Drawing.Point(0, 309);
            this.btnDeliveries.Name = "btnDeliveries";
            this.btnDeliveries.Size = new System.Drawing.Size(220, 60);
            this.btnDeliveries.TabIndex = 2;
            this.btnDeliveries.Text = "Deliveries";
            this.btnDeliveries.UseVisualStyleBackColor = true;
            this.btnDeliveries.Click += new System.EventHandler(this.BtnDeliveries_Click);
            // 
            // btnAssignments
            // 
            this.btnAssignments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssignments.FlatAppearance.BorderSize = 0;
            this.btnAssignments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAssignments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAssignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignments.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignments.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAssignments.Location = new System.Drawing.Point(0, 249);
            this.btnAssignments.Name = "btnAssignments";
            this.btnAssignments.Size = new System.Drawing.Size(220, 60);
            this.btnAssignments.TabIndex = 1;
            this.btnAssignments.Tag = "3and4only";
            this.btnAssignments.Text = "Assignments";
            this.btnAssignments.UseVisualStyleBackColor = true;
            this.btnAssignments.Click += new System.EventHandler(this.BtnAssignments_Click);
            // 
            // panelClients
            // 
            this.panelClients.Controls.Add(this.tabContracts);
            this.panelClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClients.Location = new System.Drawing.Point(220, 0);
            this.panelClients.Name = "panelClients";
            this.panelClients.Size = new System.Drawing.Size(1187, 900);
            this.panelClients.TabIndex = 2;
            // 
            // tabContracts
            // 
            this.tabContracts.Controls.Add(this.tabC1);
            this.tabContracts.Controls.Add(this.tabC2);
            this.tabContracts.Controls.Add(this.tabC3);
            this.tabContracts.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabContracts.Location = new System.Drawing.Point(0, 0);
            this.tabContracts.Name = "tabContracts";
            this.tabContracts.SelectedIndex = 0;
            this.tabContracts.Size = new System.Drawing.Size(1327, 900);
            this.tabContracts.TabIndex = 7;
            // 
            // tabC1
            // 
            this.tabC1.AutoScroll = true;
            this.tabC1.BackColor = System.Drawing.Color.Lavender;
            this.tabC1.Controls.Add(this.btnCreateContract);
            this.tabC1.Controls.Add(this.cbClientType);
            this.tabC1.Controls.Add(this.tbCourierRuns);
            this.tabC1.Controls.Add(this.ContractRuns);
            this.tabC1.Controls.Add(this.btnCClear);
            this.tabC1.Controls.Add(this.tbBEmail);
            this.tabC1.Controls.Add(this.tbBTel);
            this.tabC1.Controls.Add(this.tbBNotes);
            this.tabC1.Controls.Add(this.tbBAdd);
            this.tabC1.Controls.Add(this.tbBName);
            this.tabC1.Controls.Add(this.lbNotes);
            this.tabC1.Controls.Add(this.lbTel);
            this.tabC1.Controls.Add(this.lbBEmail);
            this.tabC1.Controls.Add(this.lbBAdd);
            this.tabC1.Controls.Add(this.lbName);
            this.tabC1.Location = new System.Drawing.Point(4, 37);
            this.tabC1.Name = "tabC1";
            this.tabC1.Padding = new System.Windows.Forms.Padding(3);
            this.tabC1.Size = new System.Drawing.Size(1319, 859);
            this.tabC1.TabIndex = 0;
            this.tabC1.Text = "Create New Contract";
            // 
            // btnCreateContract
            // 
            this.btnCreateContract.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCreateContract.FlatAppearance.BorderSize = 0;
            this.btnCreateContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateContract.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateContract.Location = new System.Drawing.Point(320, 536);
            this.btnCreateContract.Name = "btnCreateContract";
            this.btnCreateContract.Size = new System.Drawing.Size(120, 45);
            this.btnCreateContract.TabIndex = 15;
            this.btnCreateContract.Text = "Create";
            this.btnCreateContract.UseVisualStyleBackColor = false;
            this.btnCreateContract.Click += new System.EventHandler(this.btnCreateContract_Click);
            // 
            // cbClientType
            // 
            this.cbClientType.BackColor = System.Drawing.Color.Lavender;
            this.cbClientType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbClientType.FormattingEnabled = true;
            this.cbClientType.Items.AddRange(new object[] {
            "Contracted",
            "Non Contracted"});
            this.cbClientType.Location = new System.Drawing.Point(90, 20);
            this.cbClientType.Name = "cbClientType";
            this.cbClientType.Size = new System.Drawing.Size(263, 36);
            this.cbClientType.TabIndex = 8;
            this.cbClientType.Text = "Client Type";
            // 
            // tbCourierRuns
            // 
            this.tbCourierRuns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCourierRuns.Location = new System.Drawing.Point(90, 84);
            this.tbCourierRuns.MinimumSize = new System.Drawing.Size(100, 25);
            this.tbCourierRuns.Name = "tbCourierRuns";
            this.tbCourierRuns.Size = new System.Drawing.Size(263, 27);
            this.tbCourierRuns.TabIndex = 9;
            // 
            // ContractRuns
            // 
            this.ContractRuns.AutoSize = true;
            this.ContractRuns.Location = new System.Drawing.Point(93, 59);
            this.ContractRuns.Name = "ContractRuns";
            this.ContractRuns.Size = new System.Drawing.Size(127, 28);
            this.ContractRuns.TabIndex = 15;
            this.ContractRuns.Text = "Courier Runs:";
            // 
            // btnCClear
            // 
            this.btnCClear.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCClear.FlatAppearance.BorderSize = 0;
            this.btnCClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCClear.Location = new System.Drawing.Point(484, 536);
            this.btnCClear.Name = "btnCClear";
            this.btnCClear.Size = new System.Drawing.Size(120, 45);
            this.btnCClear.TabIndex = 16;
            this.btnCClear.Text = "Clear";
            this.btnCClear.UseVisualStyleBackColor = false;
            this.btnCClear.Click += new System.EventHandler(this.btnCClear_Click);
            // 
            // tbBEmail
            // 
            this.tbBEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBEmail.Location = new System.Drawing.Point(90, 332);
            this.tbBEmail.MinimumSize = new System.Drawing.Size(100, 25);
            this.tbBEmail.Name = "tbBEmail";
            this.tbBEmail.Size = new System.Drawing.Size(830, 27);
            this.tbBEmail.TabIndex = 13;
            // 
            // tbBTel
            // 
            this.tbBTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBTel.Location = new System.Drawing.Point(90, 276);
            this.tbBTel.MinimumSize = new System.Drawing.Size(100, 25);
            this.tbBTel.Name = "tbBTel";
            this.tbBTel.Size = new System.Drawing.Size(830, 27);
            this.tbBTel.TabIndex = 12;
            // 
            // tbBNotes
            // 
            this.tbBNotes.AcceptsReturn = true;
            this.tbBNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBNotes.Location = new System.Drawing.Point(90, 384);
            this.tbBNotes.Multiline = true;
            this.tbBNotes.Name = "tbBNotes";
            this.tbBNotes.Size = new System.Drawing.Size(828, 126);
            this.tbBNotes.TabIndex = 14;
            // 
            // tbBAdd
            // 
            this.tbBAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBAdd.Location = new System.Drawing.Point(90, 194);
            this.tbBAdd.Multiline = true;
            this.tbBAdd.Name = "tbBAdd";
            this.tbBAdd.Size = new System.Drawing.Size(830, 49);
            this.tbBAdd.TabIndex = 11;
            // 
            // tbBName
            // 
            this.tbBName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBName.Location = new System.Drawing.Point(90, 139);
            this.tbBName.MinimumSize = new System.Drawing.Size(100, 25);
            this.tbBName.Name = "tbBName";
            this.tbBName.Size = new System.Drawing.Size(830, 27);
            this.tbBName.TabIndex = 10;
            // 
            // lbNotes
            // 
            this.lbNotes.AutoSize = true;
            this.lbNotes.Location = new System.Drawing.Point(93, 359);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(68, 28);
            this.lbNotes.TabIndex = 4;
            this.lbNotes.Text = "Notes:";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(93, 249);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(105, 28);
            this.lbTel.TabIndex = 3;
            this.lbTel.Text = "Telephone:";
            // 
            // lbBEmail
            // 
            this.lbBEmail.AutoSize = true;
            this.lbBEmail.Location = new System.Drawing.Point(93, 304);
            this.lbBEmail.Name = "lbBEmail";
            this.lbBEmail.Size = new System.Drawing.Size(63, 28);
            this.lbBEmail.TabIndex = 2;
            this.lbBEmail.Text = "Email:";
            // 
            // lbBAdd
            // 
            this.lbBAdd.AutoSize = true;
            this.lbBAdd.Location = new System.Drawing.Point(93, 169);
            this.lbBAdd.Name = "lbBAdd";
            this.lbBAdd.Size = new System.Drawing.Size(163, 28);
            this.lbBAdd.TabIndex = 1;
            this.lbBAdd.Text = "Business Address:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(93, 114);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(145, 28);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Business Name:";
            // 
            // tabC2
            // 
            this.tabC2.BackColor = System.Drawing.Color.Lavender;
            this.tabC2.Location = new System.Drawing.Point(4, 37);
            this.tabC2.Name = "tabC2";
            this.tabC2.Padding = new System.Windows.Forms.Padding(3);
            this.tabC2.Size = new System.Drawing.Size(1319, 1009);
            this.tabC2.TabIndex = 1;
            this.tabC2.Text = "View Contracts";
            // 
            // tabC3
            // 
            this.tabC3.Location = new System.Drawing.Point(4, 37);
            this.tabC3.Name = "tabC3";
            this.tabC3.Size = new System.Drawing.Size(1319, 1009);
            this.tabC3.TabIndex = 2;
            this.tabC3.Text = "Edit Contracts";
            this.tabC3.UseVisualStyleBackColor = true;
            // 
            // lbClientRef
            // 
            this.lbClientRef.AutoSize = true;
            this.lbClientRef.Location = new System.Drawing.Point(1042, 28);
            this.lbClientRef.Name = "lbClientRef";
            this.lbClientRef.Size = new System.Drawing.Size(155, 28);
            this.lbClientRef.TabIndex = 13;
            this.lbClientRef.Text = "Client Reference:";
            // 
            // lbCRN
            // 
            this.lbCRN.Location = new System.Drawing.Point(0, 0);
            this.lbCRN.Name = "lbCRN";
            this.lbCRN.Size = new System.Drawing.Size(100, 23);
            this.lbCRN.TabIndex = 18;
            // 
            // panelDeliveries
            // 
            this.panelDeliveries.BackColor = System.Drawing.Color.Lavender;
            this.panelDeliveries.Controls.Add(this.cbBName);
            this.panelDeliveries.Controls.Add(this.DatePicker);
            this.panelDeliveries.Controls.Add(this.dataGridBookSlots);
            this.panelDeliveries.Controls.Add(this.dataGridView1);
            this.panelDeliveries.Controls.Add(this.btnBookDel);
            this.panelDeliveries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeliveries.Location = new System.Drawing.Point(220, 0);
            this.panelDeliveries.Name = "panelDeliveries";
            this.panelDeliveries.Size = new System.Drawing.Size(1187, 900);
            this.panelDeliveries.TabIndex = 15;
            // 
            // cbBName
            // 
            this.cbBName.FormattingEnabled = true;
            this.cbBName.Location = new System.Drawing.Point(90, 121);
            this.cbBName.Name = "cbBName";
            this.cbBName.Size = new System.Drawing.Size(354, 36);
            this.cbBName.TabIndex = 5;
            this.cbBName.Text = "Please choose";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(666, 121);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 34);
            this.DatePicker.TabIndex = 7;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // dataGridBookSlots
            // 
            this.dataGridBookSlots.ColumnHeadersHeight = 34;
            this.dataGridBookSlots.Location = new System.Drawing.Point(0, 0);
            this.dataGridBookSlots.Name = "dataGridBookSlots";
            this.dataGridBookSlots.RowHeadersWidth = 62;
            this.dataGridBookSlots.Size = new System.Drawing.Size(240, 150);
            this.dataGridBookSlots.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnBookDel
            // 
            this.btnBookDel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBookDel.FlatAppearance.BorderSize = 0;
            this.btnBookDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookDel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBookDel.Location = new System.Drawing.Point(794, 322);
            this.btnBookDel.Name = "btnBookDel";
            this.btnBookDel.Size = new System.Drawing.Size(120, 45);
            this.btnBookDel.TabIndex = 8;
            this.btnBookDel.Text = "Book Delivery";
            this.btnBookDel.UseVisualStyleBackColor = false;
            this.btnBookDel.Click += new System.EventHandler(this.btnBookDel_Click);
            // 
            // deliveryIDDataGridViewTextBoxColumn
            // 
            this.deliveryIDDataGridViewTextBoxColumn.DataPropertyName = "DeliveryID";
            this.deliveryIDDataGridViewTextBoxColumn.HeaderText = "DeliveryID";
            this.deliveryIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deliveryIDDataGridViewTextBoxColumn.Name = "deliveryIDDataGridViewTextBoxColumn";
            this.deliveryIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 150;
            // 
            // courierIDDataGridViewTextBoxColumn
            // 
            this.courierIDDataGridViewTextBoxColumn.DataPropertyName = "CourierID";
            this.courierIDDataGridViewTextBoxColumn.HeaderText = "CourierID";
            this.courierIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.courierIDDataGridViewTextBoxColumn.Name = "courierIDDataGridViewTextBoxColumn";
            this.courierIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientIDDataGridViewTextBoxColumn1
            // 
            this.clientIDDataGridViewTextBoxColumn1.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn1.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.clientIDDataGridViewTextBoxColumn1.Name = "clientIDDataGridViewTextBoxColumn1";
            this.clientIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.Width = 150;
            // 
            // panelReports
            // 
            this.panelReports.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelReports.BackColor = System.Drawing.Color.Lavender;
            this.panelReports.Controls.Add(this.btnGenReport);
            this.panelReports.Controls.Add(this.cbReports);
            this.panelReports.Controls.Add(this.dataGridReports);
            this.panelReports.Location = new System.Drawing.Point(134, 0);
            this.panelReports.Name = "panelReports";
            this.panelReports.Size = new System.Drawing.Size(1358, 1050);
            this.panelReports.TabIndex = 16;
            // 
            // btnGenReport
            // 
            this.btnGenReport.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGenReport.FlatAppearance.BorderSize = 0;
            this.btnGenReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenReport.Location = new System.Drawing.Point(1158, 47);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(142, 55);
            this.btnGenReport.TabIndex = 5;
            this.btnGenReport.Text = "Generate";
            this.btnGenReport.UseVisualStyleBackColor = false;
            this.btnGenReport.Click += new System.EventHandler(this.BtnGenReport_Click);
            // 
            // cbReports
            // 
            this.cbReports.BackColor = System.Drawing.Color.Lavender;
            this.cbReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbReports.FormattingEnabled = true;
            this.cbReports.Location = new System.Drawing.Point(52, 53);
            this.cbReports.Name = "cbReports";
            this.cbReports.Size = new System.Drawing.Size(966, 36);
            this.cbReports.TabIndex = 15;
            this.cbReports.Text = "Choose a report";
            // 
            // dataGridReports
            // 
            this.dataGridReports.AllowUserToDeleteRows = false;
            this.dataGridReports.AllowUserToOrderColumns = true;
            this.dataGridReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridReports.BackgroundColor = System.Drawing.Color.White;
            this.dataGridReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReports.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridReports.Location = new System.Drawing.Point(52, 119);
            this.dataGridReports.Name = "dataGridReports";
            this.dataGridReports.ReadOnly = true;
            this.dataGridReports.RowHeadersWidth = 62;
            this.dataGridReports.Size = new System.Drawing.Size(2406, 1838);
            this.dataGridReports.TabIndex = 6;
            // 
            // panelAssignments
            // 
            this.panelAssignments.BackColor = System.Drawing.Color.Lavender;
            this.panelAssignments.Controls.Add(this.cbAssignments);
            this.panelAssignments.Controls.Add(this.btnAssignmentsSave);
            this.panelAssignments.Controls.Add(this.btnAssignmentsLoad);
            this.panelAssignments.Controls.Add(this.dataGridAssignments);
            this.panelAssignments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAssignments.Location = new System.Drawing.Point(220, 0);
            this.panelAssignments.Name = "panelAssignments";
            this.panelAssignments.Size = new System.Drawing.Size(1187, 900);
            this.panelAssignments.TabIndex = 17;
            // 
            // cbAssignments
            // 
            this.cbAssignments.FormattingEnabled = true;
            this.cbAssignments.Location = new System.Drawing.Point(53, 30);
            this.cbAssignments.Name = "cbAssignments";
            this.cbAssignments.Size = new System.Drawing.Size(121, 36);
            this.cbAssignments.TabIndex = 9;
            this.cbAssignments.Text = "Please select";
            this.cbAssignments.Click += new System.EventHandler(this.CbAssignments_Click);
            // 
            // btnAssignmentsSave
            // 
            this.btnAssignmentsSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAssignmentsSave.FlatAppearance.BorderSize = 0;
            this.btnAssignmentsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignmentsSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAssignmentsSave.Location = new System.Drawing.Point(351, 12);
            this.btnAssignmentsSave.Name = "btnAssignmentsSave";
            this.btnAssignmentsSave.Size = new System.Drawing.Size(120, 45);
            this.btnAssignmentsSave.TabIndex = 8;
            this.btnAssignmentsSave.Text = "Save";
            this.btnAssignmentsSave.UseVisualStyleBackColor = false;
            // 
            // btnAssignmentsLoad
            // 
            this.btnAssignmentsLoad.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAssignmentsLoad.FlatAppearance.BorderSize = 0;
            this.btnAssignmentsLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignmentsLoad.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAssignmentsLoad.Location = new System.Drawing.Point(209, 12);
            this.btnAssignmentsLoad.Name = "btnAssignmentsLoad";
            this.btnAssignmentsLoad.Size = new System.Drawing.Size(120, 45);
            this.btnAssignmentsLoad.TabIndex = 7;
            this.btnAssignmentsLoad.Text = "Load";
            this.btnAssignmentsLoad.UseVisualStyleBackColor = false;
            this.btnAssignmentsLoad.Click += new System.EventHandler(this.BtnAssignmentsLoad_Click);
            // 
            // dataGridAssignments
            // 
            this.dataGridAssignments.AllowUserToDeleteRows = false;
            this.dataGridAssignments.AllowUserToOrderColumns = true;
            this.dataGridAssignments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridAssignments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAssignments.Location = new System.Drawing.Point(53, 75);
            this.dataGridAssignments.Name = "dataGridAssignments";
            this.dataGridAssignments.ReadOnly = true;
            this.dataGridAssignments.RowHeadersWidth = 62;
            this.dataGridAssignments.Size = new System.Drawing.Size(607, 427);
            this.dataGridAssignments.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::BayWynCouriersWinForm.Properties.Resources.LOGO;
            this.pictureBox1.Image = global::BayWynCouriersWinForm.Properties.Resources.LOGO;
            this.pictureBox1.InitialImage = global::BayWynCouriersWinForm.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(26, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 154);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // IconPanel
            // 
            this.IconPanel.Controls.Add(this.pictureBox1);
            this.IconPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.IconPanel.Location = new System.Drawing.Point(0, 0);
            this.IconPanel.Name = "IconPanel";
            this.IconPanel.Size = new System.Drawing.Size(220, 249);
            this.IconPanel.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1407, 900);
            this.Controls.Add(this.panelClients);
            this.Controls.Add(this.panelDeliveries);
            this.Controls.Add(this.panelAssignments);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelReports);
            this.Controls.Add(this.lbClientRef);
            this.Controls.Add(this.lbCRN);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bay Wyn Couriers";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelClients.ResumeLayout(false);
            this.tabContracts.ResumeLayout(false);
            this.tabC1.ResumeLayout(false);
            this.tabC1.PerformLayout();
            this.panelDeliveries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookSlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReports)).EndInit();
            this.panelAssignments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssignments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.IconPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnDeliveries;
        private System.Windows.Forms.Button btnAssignments;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Panel panelClients;
        private System.Windows.Forms.Label lbClientRef;
        private System.Windows.Forms.TextBox tbBEmail;
        private System.Windows.Forms.TextBox tbBTel;
        private System.Windows.Forms.TextBox tbBNotes;
        private System.Windows.Forms.TextBox tbBAdd;
        private System.Windows.Forms.TextBox tbBName;
        private System.Windows.Forms.Label lbCRN;
        private System.Windows.Forms.Label lbNotes;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbBEmail;
        private System.Windows.Forms.Label lbBAdd;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panelDeliveries;
        private System.Windows.Forms.Panel panelReports;
        private System.Windows.Forms.DataGridView dataGridReports;
        private System.Windows.Forms.Button btnBookDel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbReports;
        private System.Windows.Forms.Button btnGenReport;
        private System.Windows.Forms.Panel panelAssignments;
        private System.Windows.Forms.DataGridView dataGridAssignments;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btnAssignmentsSave;
        private System.Windows.Forms.Button btnAssignmentsLoad;
        private System.Windows.Forms.ComboBox cbAssignments;
        private System.Windows.Forms.Button btnCClear;
        private System.Windows.Forms.ComboBox cbClientType;
        private System.Windows.Forms.TextBox tbCourierRuns;
        private System.Windows.Forms.Label ContractRuns;
        private System.Windows.Forms.TabControl tabContracts;
        private System.Windows.Forms.TabPage tabC1;
        private System.Windows.Forms.TabPage tabC2;
        private System.Windows.Forms.DataGridView dataGridViewContracts;
        private System.Windows.Forms.TabPage tabC3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientRunTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridBookSlots;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.ComboBox cbBName;
        private System.Windows.Forms.Button btnCreateContract;
        private System.Windows.Forms.Panel IconPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

