namespace Assignment4_1 {
    partial class MainForm {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblSearch = new Label();
            textBoxSearch = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            dataGridContacts = new DataGridView();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            MobilePhone = new DataGridViewTextBoxColumn();
            WorkPhone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            groupBoxCard = new GroupBox();
            lblCardAddress = new Label();
            lblCardWork = new Label();
            lblCardMobile = new Label();
            lblCardName = new Label();
            btnAddContact = new Button();
            btnDeleteContact = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridContacts).BeginInit();
            groupBoxCard.SuspendLayout();
            SuspendLayout();
            //
            // lblSearch
            //
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.LightSteelBlue;
            lblSearch.Font = new Font("Georgia", 16F, FontStyle.Bold);
            lblSearch.Location = new Point(22, 22);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(199, 31);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Look up a name";
            //
            // textBoxSearch
            //
            textBoxSearch.Font = new Font("Segoe UI", 16F);
            textBoxSearch.Location = new Point(22, 62);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "first, last or full name";
            textBoxSearch.Size = new Size(380, 36);
            textBoxSearch.TabIndex = 1;
            //
            // btnSearch
            //
            btnSearch.BackColor = Color.LightSteelBlue;
            btnSearch.Font = new Font("Cascadia Code SemiBold", 13F);
            btnSearch.ForeColor = SystemColors.ControlText;
            btnSearch.Location = new Point(416, 58);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(140, 44);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            //
            // btnShowAll
            //
            btnShowAll.BackColor = Color.LightSteelBlue;
            btnShowAll.Font = new Font("Cascadia Code SemiBold", 13F);
            btnShowAll.ForeColor = SystemColors.ControlText;
            btnShowAll.Location = new Point(570, 58);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(140, 44);
            btnShowAll.TabIndex = 3;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            //
            // dataGridContacts
            //
            dataGridContacts.AllowUserToAddRows = false;
            dataGridContacts.AllowUserToDeleteRows = false;
            dataGridContacts.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridContacts.Columns.AddRange(new DataGridViewColumn[] { LastName, FirstName, MobilePhone, WorkPhone, Address });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridContacts.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridContacts.EnableHeadersVisualStyles = false;
            dataGridContacts.Location = new Point(22, 120);
            dataGridContacts.MultiSelect = false;
            dataGridContacts.Name = "dataGridContacts";
            dataGridContacts.ReadOnly = true;
            dataGridContacts.RowHeadersVisible = false;
            dataGridContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridContacts.Size = new Size(860, 310);
            dataGridContacts.StandardTab = true;
            dataGridContacts.TabIndex = 4;
            dataGridContacts.SelectionChanged += dataGridContacts_SelectionChanged;
            //
            // LastName
            //
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "Last Name";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 130;
            //
            // FirstName
            //
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "First Name";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 130;
            //
            // MobilePhone
            //
            MobilePhone.DataPropertyName = "MobilePhone";
            MobilePhone.HeaderText = "Mobile";
            MobilePhone.Name = "MobilePhone";
            MobilePhone.ReadOnly = true;
            MobilePhone.Width = 140;
            //
            // WorkPhone
            //
            WorkPhone.DataPropertyName = "WorkPhone";
            WorkPhone.HeaderText = "Work";
            WorkPhone.Name = "WorkPhone";
            WorkPhone.ReadOnly = true;
            WorkPhone.Width = 140;
            //
            // Address
            //
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.Name = "Address";
            Address.ReadOnly = true;
            //
            // groupBoxCard
            //
            groupBoxCard.BackColor = Color.AliceBlue;
            groupBoxCard.Controls.Add(lblCardAddress);
            groupBoxCard.Controls.Add(lblCardWork);
            groupBoxCard.Controls.Add(lblCardMobile);
            groupBoxCard.Controls.Add(lblCardName);
            groupBoxCard.Font = new Font("Georgia", 12F, FontStyle.Bold);
            groupBoxCard.Location = new Point(900, 120);
            groupBoxCard.Name = "groupBoxCard";
            groupBoxCard.Size = new Size(258, 310);
            groupBoxCard.TabIndex = 5;
            groupBoxCard.TabStop = false;
            groupBoxCard.Text = "Contact";
            //
            // lblCardAddress
            //
            lblCardAddress.Font = new Font("Segoe UI", 13F);
            lblCardAddress.Location = new Point(16, 190);
            lblCardAddress.Name = "lblCardAddress";
            lblCardAddress.Size = new Size(226, 100);
            lblCardAddress.TabIndex = 3;
            //
            // lblCardWork
            //
            lblCardWork.AutoSize = true;
            lblCardWork.Font = new Font("Segoe UI", 13F);
            lblCardWork.Location = new Point(16, 135);
            lblCardWork.Name = "lblCardWork";
            lblCardWork.Size = new Size(0, 25);
            lblCardWork.TabIndex = 2;
            //
            // lblCardMobile
            //
            lblCardMobile.AutoSize = true;
            lblCardMobile.Font = new Font("Segoe UI", 13F);
            lblCardMobile.Location = new Point(16, 100);
            lblCardMobile.Name = "lblCardMobile";
            lblCardMobile.Size = new Size(0, 25);
            lblCardMobile.TabIndex = 1;
            //
            // lblCardName
            //
            lblCardName.AutoSize = true;
            lblCardName.Font = new Font("Georgia", 18F, FontStyle.Bold);
            lblCardName.Location = new Point(16, 40);
            lblCardName.Name = "lblCardName";
            lblCardName.Size = new Size(0, 34);
            lblCardName.TabIndex = 0;
            //
            // btnAddContact
            //
            btnAddContact.BackColor = Color.LightSteelBlue;
            btnAddContact.Font = new Font("Cascadia Code SemiBold", 15F);
            btnAddContact.ForeColor = SystemColors.ControlText;
            btnAddContact.Location = new Point(22, 458);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(220, 70);
            btnAddContact.TabIndex = 6;
            btnAddContact.Text = "Add Contact";
            btnAddContact.UseVisualStyleBackColor = false;
            btnAddContact.Click += btnAddContact_Click;
            //
            // btnDeleteContact
            //
            btnDeleteContact.BackColor = Color.LightSteelBlue;
            btnDeleteContact.Font = new Font("Cascadia Code SemiBold", 15F);
            btnDeleteContact.ForeColor = SystemColors.ControlText;
            btnDeleteContact.Location = new Point(662, 458);
            btnDeleteContact.Name = "btnDeleteContact";
            btnDeleteContact.Size = new Size(220, 70);
            btnDeleteContact.TabIndex = 7;
            btnDeleteContact.Text = "Delete Contact";
            btnDeleteContact.UseVisualStyleBackColor = false;
            btnDeleteContact.Click += btnDeleteContact_Click;
            //
            // MainForm
            //
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1180, 550);
            Controls.Add(btnDeleteContact);
            Controls.Add(btnAddContact);
            Controls.Add(groupBoxCard);
            Controls.Add(dataGridContacts);
            Controls.Add(btnShowAll);
            Controls.Add(btnSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(lblSearch);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phone Book";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridContacts).EndInit();
            groupBoxCard.ResumeLayout(false);
            groupBoxCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblSearch;
        private TextBox textBoxSearch;
        private Button btnSearch;
        private Button btnShowAll;
        private DataGridView dataGridContacts;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MobilePhone;
        private DataGridViewTextBoxColumn WorkPhone;
        private DataGridViewTextBoxColumn Address;
        private GroupBox groupBoxCard;
        private Label lblCardAddress;
        private Label lblCardWork;
        private Label lblCardMobile;
        private Label lblCardName;
        private Button btnAddContact;
        private Button btnDeleteContact;
    }
}
