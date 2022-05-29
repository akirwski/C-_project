
namespace UITesting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.cmbProfileDept = new System.Windows.Forms.ComboBox();
            this.btnProfileUpdate = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtProfileRole = new System.Windows.Forms.TextBox();
            this.txtProfilePhone = new System.Windows.Forms.TextBox();
            this.txtProfileEmail = new System.Windows.Forms.TextBox();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.lblProfileUserID = new System.Windows.Forms.Label();
            this.lblNameLable = new System.Windows.Forms.Label();
            this.lblUserIDLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTicketITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlViewTicket = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.RichTextBox();
            this.txtViewIssue = new System.Windows.Forms.RichTextBox();
            this.tbnShowAllTicket = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbViewTicket = new System.Windows.Forms.ComboBox();
            this.dgvViewTicket = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlViewTicketU = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvClosedTickets = new System.Windows.Forms.DataGridView();
            this.txtViewIssueU = new System.Windows.Forms.RichTextBox();
            this.dgvViewTicketU = new System.Windows.Forms.DataGridView();
            this.pnlCreateTicket = new System.Windows.Forms.Panel();
            this.btnTicketCancel = new System.Windows.Forms.Button();
            this.btnTicketSubmit = new System.Windows.Forms.Button();
            this.txtTicketTitle = new System.Windows.Forms.TextBox();
            this.txtTicketIssue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTicketDept = new System.Windows.Forms.ComboBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginUserID = new System.Windows.Forms.TextBox();
            this.pnlProfile.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlViewTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewTicket)).BeginInit();
            this.pnlViewTicketU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewTicketU)).BeginInit();
            this.pnlCreateTicket.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.White;
            this.pnlProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlProfile.BackgroundImage")));
            this.pnlProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlProfile.Controls.Add(this.cmbProfileDept);
            this.pnlProfile.Controls.Add(this.btnProfileUpdate);
            this.pnlProfile.Controls.Add(this.lblRole);
            this.pnlProfile.Controls.Add(this.lblDept);
            this.pnlProfile.Controls.Add(this.lblPhone);
            this.pnlProfile.Controls.Add(this.lblEmail);
            this.pnlProfile.Controls.Add(this.txtProfileRole);
            this.pnlProfile.Controls.Add(this.txtProfilePhone);
            this.pnlProfile.Controls.Add(this.txtProfileEmail);
            this.pnlProfile.Controls.Add(this.lblProfileName);
            this.pnlProfile.Controls.Add(this.lblProfileUserID);
            this.pnlProfile.Controls.Add(this.lblNameLable);
            this.pnlProfile.Controls.Add(this.lblUserIDLabel);
            this.pnlProfile.Location = new System.Drawing.Point(89, 28);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(50, 50);
            this.pnlProfile.TabIndex = 9;
            // 
            // cmbProfileDept
            // 
            this.cmbProfileDept.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbProfileDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbProfileDept.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbProfileDept.FormattingEnabled = true;
            this.cmbProfileDept.Location = new System.Drawing.Point(487, 196);
            this.cmbProfileDept.Name = "cmbProfileDept";
            this.cmbProfileDept.Size = new System.Drawing.Size(211, 24);
            this.cmbProfileDept.TabIndex = 13;
            // 
            // btnProfileUpdate
            // 
            this.btnProfileUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProfileUpdate.Location = new System.Drawing.Point(555, 289);
            this.btnProfileUpdate.Name = "btnProfileUpdate";
            this.btnProfileUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnProfileUpdate.TabIndex = 12;
            this.btnProfileUpdate.Text = "Update";
            this.btnProfileUpdate.UseVisualStyleBackColor = true;
            this.btnProfileUpdate.Click += new System.EventHandler(this.btnProfileUpdate_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRole.Location = new System.Drawing.Point(438, 242);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(37, 17);
            this.lblRole.TabIndex = 11;
            this.lblRole.Text = "Role";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDept.Location = new System.Drawing.Point(393, 200);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(82, 17);
            this.lblDept.TabIndex = 10;
            this.lblDept.Text = "Department";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPhone.Location = new System.Drawing.Point(426, 157);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 17);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEmail.Location = new System.Drawing.Point(433, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // txtProfileRole
            // 
            this.txtProfileRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProfileRole.Location = new System.Drawing.Point(487, 239);
            this.txtProfileRole.Name = "txtProfileRole";
            this.txtProfileRole.Size = new System.Drawing.Size(211, 23);
            this.txtProfileRole.TabIndex = 7;
            // 
            // txtProfilePhone
            // 
            this.txtProfilePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProfilePhone.Location = new System.Drawing.Point(487, 154);
            this.txtProfilePhone.Name = "txtProfilePhone";
            this.txtProfilePhone.Size = new System.Drawing.Size(211, 23);
            this.txtProfilePhone.TabIndex = 5;
            // 
            // txtProfileEmail
            // 
            this.txtProfileEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProfileEmail.Location = new System.Drawing.Point(487, 112);
            this.txtProfileEmail.Name = "txtProfileEmail";
            this.txtProfileEmail.Size = new System.Drawing.Size(211, 23);
            this.txtProfileEmail.TabIndex = 4;
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.BackColor = System.Drawing.Color.White;
            this.lblProfileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProfileName.Location = new System.Drawing.Point(487, 73);
            this.lblProfileName.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(100, 20);
            this.lblProfileName.TabIndex = 3;
            // 
            // lblProfileUserID
            // 
            this.lblProfileUserID.AutoSize = true;
            this.lblProfileUserID.BackColor = System.Drawing.Color.White;
            this.lblProfileUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProfileUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProfileUserID.Location = new System.Drawing.Point(487, 34);
            this.lblProfileUserID.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblProfileUserID.Name = "lblProfileUserID";
            this.lblProfileUserID.Size = new System.Drawing.Size(100, 20);
            this.lblProfileUserID.TabIndex = 2;
            // 
            // lblNameLable
            // 
            this.lblNameLable.AutoSize = true;
            this.lblNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNameLable.Location = new System.Drawing.Point(430, 75);
            this.lblNameLable.Name = "lblNameLable";
            this.lblNameLable.Size = new System.Drawing.Size(45, 17);
            this.lblNameLable.TabIndex = 1;
            this.lblNameLable.Text = "Name";
            // 
            // lblUserIDLabel
            // 
            this.lblUserIDLabel.AutoSize = true;
            this.lblUserIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUserIDLabel.Location = new System.Drawing.Point(420, 36);
            this.lblUserIDLabel.Name = "lblUserIDLabel";
            this.lblUserIDLabel.Size = new System.Drawing.Size(55, 17);
            this.lblUserIDLabel.TabIndex = 0;
            this.lblUserIDLabel.Text = "User ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.ticketToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.viewTicketITToolStripMenuItem,
            this.exiToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(94, 21);
            this.ticketToolStripMenuItem.Text = "CreateTicket";
            this.ticketToolStripMenuItem.Click += new System.EventHandler(this.ticketToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // viewTicketITToolStripMenuItem
            // 
            this.viewTicketITToolStripMenuItem.Name = "viewTicketITToolStripMenuItem";
            this.viewTicketITToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.viewTicketITToolStripMenuItem.Text = "ViewTicket";
            this.viewTicketITToolStripMenuItem.Click += new System.EventHandler(this.viewTicketITToolStripMenuItem_Click);
            // 
            // exiToolStripMenuItem
            // 
            this.exiToolStripMenuItem.Name = "exiToolStripMenuItem";
            this.exiToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.exiToolStripMenuItem.Text = "Exit";
            this.exiToolStripMenuItem.Click += new System.EventHandler(this.exiToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // pnlViewTicket
            // 
            this.pnlViewTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlViewTicket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlViewTicket.BackgroundImage")));
            this.pnlViewTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlViewTicket.Controls.Add(this.label4);
            this.pnlViewTicket.Controls.Add(this.txtComments);
            this.pnlViewTicket.Controls.Add(this.txtViewIssue);
            this.pnlViewTicket.Controls.Add(this.tbnShowAllTicket);
            this.pnlViewTicket.Controls.Add(this.btnClose);
            this.pnlViewTicket.Controls.Add(this.cmbViewTicket);
            this.pnlViewTicket.Controls.Add(this.dgvViewTicket);
            this.pnlViewTicket.Controls.Add(this.label1);
            this.pnlViewTicket.Location = new System.Drawing.Point(33, 101);
            this.pnlViewTicket.Name = "pnlViewTicket";
            this.pnlViewTicket.Size = new System.Drawing.Size(800, 500);
            this.pnlViewTicket.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(519, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Comments";
            // 
            // txtComments
            // 
            this.txtComments.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtComments.Location = new System.Drawing.Point(512, 89);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(225, 250);
            this.txtComments.TabIndex = 7;
            this.txtComments.Text = "";
            // 
            // txtViewIssue
            // 
            this.txtViewIssue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtViewIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtViewIssue.Location = new System.Drawing.Point(38, 359);
            this.txtViewIssue.Name = "txtViewIssue";
            this.txtViewIssue.Size = new System.Drawing.Size(425, 122);
            this.txtViewIssue.TabIndex = 6;
            this.txtViewIssue.Text = "";
            // 
            // tbnShowAllTicket
            // 
            this.tbnShowAllTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbnShowAllTicket.Location = new System.Drawing.Point(377, 42);
            this.tbnShowAllTicket.Name = "tbnShowAllTicket";
            this.tbnShowAllTicket.Size = new System.Drawing.Size(90, 35);
            this.tbnShowAllTicket.TabIndex = 5;
            this.tbnShowAllTicket.Text = "Show All";
            this.tbnShowAllTicket.UseVisualStyleBackColor = true;
            this.tbnShowAllTicket.Click += new System.EventHandler(this.tbnShowAllTicket_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(662, 42);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbViewTicket
            // 
            this.cmbViewTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbViewTicket.FormattingEnabled = true;
            this.cmbViewTicket.Location = new System.Drawing.Point(119, 47);
            this.cmbViewTicket.Name = "cmbViewTicket";
            this.cmbViewTicket.Size = new System.Drawing.Size(147, 24);
            this.cmbViewTicket.TabIndex = 2;
            this.cmbViewTicket.SelectedIndexChanged += new System.EventHandler(this.cmbViewTicket_SelectedIndexChanged);
            // 
            // dgvViewTicket
            // 
            this.dgvViewTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewTicket.Location = new System.Drawing.Point(38, 89);
            this.dgvViewTicket.Name = "dgvViewTicket";
            this.dgvViewTicket.Size = new System.Drawing.Size(425, 250);
            this.dgvViewTicket.TabIndex = 1;
            this.dgvViewTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewTicket_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TicketID";
            // 
            // pnlViewTicketU
            // 
            this.pnlViewTicketU.BackColor = System.Drawing.Color.White;
            this.pnlViewTicketU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlViewTicketU.BackgroundImage")));
            this.pnlViewTicketU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlViewTicketU.Controls.Add(this.label5);
            this.pnlViewTicketU.Controls.Add(this.label6);
            this.pnlViewTicketU.Controls.Add(this.dgvClosedTickets);
            this.pnlViewTicketU.Controls.Add(this.txtViewIssueU);
            this.pnlViewTicketU.Controls.Add(this.dgvViewTicketU);
            this.pnlViewTicketU.Location = new System.Drawing.Point(21, 143);
            this.pnlViewTicketU.Name = "pnlViewTicketU";
            this.pnlViewTicketU.Size = new System.Drawing.Size(24, 26);
            this.pnlViewTicketU.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(416, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "CLOSED Tickets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "OPEN Tickets";
            // 
            // dgvClosedTickets
            // 
            this.dgvClosedTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClosedTickets.GridColor = System.Drawing.Color.Cyan;
            this.dgvClosedTickets.Location = new System.Drawing.Point(416, 62);
            this.dgvClosedTickets.Name = "dgvClosedTickets";
            this.dgvClosedTickets.Size = new System.Drawing.Size(350, 232);
            this.dgvClosedTickets.TabIndex = 8;
            this.dgvClosedTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClosedTickets_CellContentClick_1);
            // 
            // txtViewIssueU
            // 
            this.txtViewIssueU.BackColor = System.Drawing.SystemColors.Control;
            this.txtViewIssueU.Location = new System.Drawing.Point(33, 311);
            this.txtViewIssueU.Name = "txtViewIssueU";
            this.txtViewIssueU.Size = new System.Drawing.Size(426, 172);
            this.txtViewIssueU.TabIndex = 7;
            this.txtViewIssueU.Text = "";
            // 
            // dgvViewTicketU
            // 
            this.dgvViewTicketU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewTicketU.Location = new System.Drawing.Point(33, 62);
            this.dgvViewTicketU.Name = "dgvViewTicketU";
            this.dgvViewTicketU.Size = new System.Drawing.Size(350, 232);
            this.dgvViewTicketU.TabIndex = 0;
            this.dgvViewTicketU.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewTicketU_CellContentClick_1);
            // 
            // pnlCreateTicket
            // 
            this.pnlCreateTicket.BackColor = System.Drawing.Color.White;
            this.pnlCreateTicket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCreateTicket.BackgroundImage")));
            this.pnlCreateTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCreateTicket.Controls.Add(this.btnTicketCancel);
            this.pnlCreateTicket.Controls.Add(this.btnTicketSubmit);
            this.pnlCreateTicket.Controls.Add(this.txtTicketTitle);
            this.pnlCreateTicket.Controls.Add(this.txtTicketIssue);
            this.pnlCreateTicket.Controls.Add(this.label2);
            this.pnlCreateTicket.Controls.Add(this.label3);
            this.pnlCreateTicket.Controls.Add(this.label7);
            this.pnlCreateTicket.Controls.Add(this.cmbTicketDept);
            this.pnlCreateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pnlCreateTicket.Location = new System.Drawing.Point(4, 28);
            this.pnlCreateTicket.Name = "pnlCreateTicket";
            this.pnlCreateTicket.Size = new System.Drawing.Size(62, 50);
            this.pnlCreateTicket.TabIndex = 14;
            // 
            // btnTicketCancel
            // 
            this.btnTicketCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTicketCancel.Location = new System.Drawing.Point(197, 357);
            this.btnTicketCancel.Name = "btnTicketCancel";
            this.btnTicketCancel.Size = new System.Drawing.Size(75, 32);
            this.btnTicketCancel.TabIndex = 7;
            this.btnTicketCancel.Text = "Cancel";
            this.btnTicketCancel.UseVisualStyleBackColor = true;
            this.btnTicketCancel.Click += new System.EventHandler(this.btnTicketCancel_Click_1);
            // 
            // btnTicketSubmit
            // 
            this.btnTicketSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTicketSubmit.Location = new System.Drawing.Point(94, 357);
            this.btnTicketSubmit.Name = "btnTicketSubmit";
            this.btnTicketSubmit.Size = new System.Drawing.Size(75, 32);
            this.btnTicketSubmit.TabIndex = 6;
            this.btnTicketSubmit.Text = "Submit";
            this.btnTicketSubmit.UseVisualStyleBackColor = true;
            this.btnTicketSubmit.Click += new System.EventHandler(this.btnTicketSubmit_Click_1);
            // 
            // txtTicketTitle
            // 
            this.txtTicketTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTicketTitle.Location = new System.Drawing.Point(94, 56);
            this.txtTicketTitle.Name = "txtTicketTitle";
            this.txtTicketTitle.Size = new System.Drawing.Size(121, 23);
            this.txtTicketTitle.TabIndex = 3;
            // 
            // txtTicketIssue
            // 
            this.txtTicketIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTicketIssue.Location = new System.Drawing.Point(94, 124);
            this.txtTicketIssue.Multiline = true;
            this.txtTicketIssue.Name = "txtTicketIssue";
            this.txtTicketIssue.Size = new System.Drawing.Size(383, 220);
            this.txtTicketIssue.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(53, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(268, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(47, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Issue";
            // 
            // cmbTicketDept
            // 
            this.cmbTicketDept.AutoCompleteCustomSource.AddRange(new string[] {
            "Accounting",
            "HR",
            "IT"});
            this.cmbTicketDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbTicketDept.FormattingEnabled = true;
            this.cmbTicketDept.Location = new System.Drawing.Point(356, 55);
            this.cmbTicketDept.Name = "cmbTicketDept";
            this.cmbTicketDept.Size = new System.Drawing.Size(121, 24);
            this.cmbTicketDept.TabIndex = 4;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogin.BackgroundImage")));
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogin.Controls.Add(this.label8);
            this.pnlLogin.Controls.Add(this.label9);
            this.pnlLogin.Controls.Add(this.label10);
            this.pnlLogin.Controls.Add(this.LoginButton);
            this.pnlLogin.Controls.Add(this.txtLoginPassword);
            this.pnlLogin.Controls.Add(this.txtLoginUserID);
            this.pnlLogin.Location = new System.Drawing.Point(33, 191);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(50, 54);
            this.pnlLogin.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(243, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(257, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "User ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(195, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(435, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Welcome! Please Input your Username and Password Below";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(372, 225);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(80, 31);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLoginPassword.Location = new System.Drawing.Point(318, 196);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(188, 23);
            this.txtLoginPassword.TabIndex = 1;
            // 
            // txtLoginUserID
            // 
            this.txtLoginUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLoginUserID.Location = new System.Drawing.Point(318, 167);
            this.txtLoginUserID.Name = "txtLoginUserID";
            this.txtLoginUserID.Size = new System.Drawing.Size(188, 23);
            this.txtLoginUserID.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 531);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlCreateTicket);
            this.Controls.Add(this.pnlViewTicketU);
            this.Controls.Add(this.pnlViewTicket);
            this.Controls.Add(this.pnlProfile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "IT Help Center";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlViewTicket.ResumeLayout(false);
            this.pnlViewTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewTicket)).EndInit();
            this.pnlViewTicketU.ResumeLayout(false);
            this.pnlViewTicketU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewTicketU)).EndInit();
            this.pnlCreateTicket.ResumeLayout(false);
            this.pnlCreateTicket.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label lblUserIDLabel;
        private System.Windows.Forms.Label lblProfileUserID;
        private System.Windows.Forms.Label lblNameLable;
        private System.Windows.Forms.Button btnProfileUpdate;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtProfileRole;
        private System.Windows.Forms.TextBox txtProfilePhone;
        private System.Windows.Forms.TextBox txtProfileEmail;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbProfileDept;
        private System.Windows.Forms.ToolStripMenuItem viewTicketITToolStripMenuItem;
        private System.Windows.Forms.Panel pnlViewTicket;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbViewTicket;
        private System.Windows.Forms.DataGridView dgvViewTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exiToolStripMenuItem;
        private System.Windows.Forms.Button tbnShowAllTicket;
        private System.Windows.Forms.RichTextBox txtViewIssue;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtComments;
        private System.Windows.Forms.Panel pnlViewTicketU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvClosedTickets;
        private System.Windows.Forms.RichTextBox txtViewIssueU;
        private System.Windows.Forms.DataGridView dgvViewTicketU;
        private System.Windows.Forms.Panel pnlCreateTicket;
        private System.Windows.Forms.Button btnTicketCancel;
        private System.Windows.Forms.Button btnTicketSubmit;
        private System.Windows.Forms.TextBox txtTicketTitle;
        private System.Windows.Forms.TextBox txtTicketIssue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTicketDept;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginUserID;
    }
}

