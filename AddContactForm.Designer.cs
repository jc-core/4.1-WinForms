namespace Assignment4_1 {
    partial class AddContactForm {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            lblAddContactTitle = new Label();
            labelFirstName = new Label();
            textBoxFirstName = new TextBox();
            labelLastName = new Label();
            textBoxLastName = new TextBox();
            labelMobilePhone = new Label();
            textBoxMobilePhone = new TextBox();
            labelWorkPhone = new Label();
            textBoxWorkPhone = new TextBox();
            labelStreet = new Label();
            textBoxStreet = new TextBox();
            labelCity = new Label();
            textBoxCity = new TextBox();
            labelState = new Label();
            textBoxState = new TextBox();
            labelZip = new Label();
            textBoxZip = new TextBox();
            groupBoxEntry = new GroupBox();
            lblEntryPreview = new Label();
            btnAddContactSubmit = new Button();
            btnAddContactReset = new Button();
            btnCloseAddContact = new Button();
            groupBoxEntry.SuspendLayout();
            SuspendLayout();
            //
            // lblAddContactTitle
            //
            lblAddContactTitle.AutoSize = true;
            lblAddContactTitle.BackColor = Color.LightSteelBlue;
            lblAddContactTitle.Font = new Font("Georgia", 28F, FontStyle.Bold);
            lblAddContactTitle.ForeColor = SystemColors.ControlText;
            lblAddContactTitle.Location = new Point(22, 18);
            lblAddContactTitle.Name = "lblAddContactTitle";
            lblAddContactTitle.Size = new Size(258, 54);
            lblAddContactTitle.TabIndex = 0;
            lblAddContactTitle.Text = "New Contact";
            //
            // labelFirstName
            //
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.LightSteelBlue;
            labelFirstName.Font = new Font("Georgia", 14F, FontStyle.Bold);
            labelFirstName.Location = new Point(30, 100);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(122, 27);
            labelFirstName.TabIndex = 20;
            labelFirstName.Text = "First Name";
            //
            // textBoxFirstName
            //
            textBoxFirstName.Font = new Font("Segoe UI", 14F);
            textBoxFirstName.Location = new Point(200, 97);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(230, 32);
            textBoxFirstName.TabIndex = 1;
            textBoxFirstName.TextChanged += entry_Changed;
            //
            // labelLastName
            //
            labelLastName.AutoSize = true;
            labelLastName.BackColor = Color.LightSteelBlue;
            labelLastName.Font = new Font("Georgia", 14F, FontStyle.Bold);
            labelLastName.Location = new Point(30, 146);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(120, 27);
            labelLastName.TabIndex = 21;
            labelLastName.Text = "Last Name";
            //
            // textBoxLastName
            //
            textBoxLastName.Font = new Font("Segoe UI", 14F);
            textBoxLastName.Location = new Point(200, 143);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(230, 32);
            textBoxLastName.TabIndex = 2;
            textBoxLastName.TextChanged += entry_Changed;
            //
            // labelMobilePhone
            //
            labelMobilePhone.AutoSize = true;
            labelMobilePhone.BackColor = Color.LightSteelBlue;
            labelMobilePhone.Font = new Font("Georgia", 14F, FontStyle.Bold);
            labelMobilePhone.Location = new Point(30, 192);
            labelMobilePhone.Name = "labelMobilePhone";
            labelMobilePhone.Size = new Size(153, 27);
            labelMobilePhone.TabIndex = 22;
            labelMobilePhone.Text = "Mobile Phone";
            //
            // textBoxMobilePhone
            //
            textBoxMobilePhone.Font = new Font("Segoe UI", 14F);
            textBoxMobilePhone.Location = new Point(200, 189);
            textBoxMobilePhone.Name = "textBoxMobilePhone";
            textBoxMobilePhone.Size = new Size(230, 32);
            textBoxMobilePhone.TabIndex = 3;
            textBoxMobilePhone.TextChanged += entry_Changed;
            //
            // labelWorkPhone
            //
            labelWorkPhone.AutoSize = true;
            labelWorkPhone.BackColor = Color.LightSteelBlue;
            labelWorkPhone.Font = new Font("Georgia", 14F, FontStyle.Bold);
            labelWorkPhone.Location = new Point(30, 238);
            labelWorkPhone.Name = "labelWorkPhone";
            labelWorkPhone.Size = new Size(136, 27);
            labelWorkPhone.TabIndex = 23;
            labelWorkPhone.Text = "Work Phone";
            //
            // textBoxWorkPhone
            //
            textBoxWorkPhone.Font = new Font("Segoe UI", 14F);
            textBoxWorkPhone.Location = new Point(200, 235);
            textBoxWorkPhone.Name = "textBoxWorkPhone";
            textBoxWorkPhone.Size = new Size(230, 32);
            textBoxWorkPhone.TabIndex = 4;
            textBoxWorkPhone.TextChanged += entry_Changed;
            //
            // labelStreet
            //
            labelStreet.AutoSize = true;
            labelStreet.BackColor = Color.LightSteelBlue;
            labelStreet.Font = new Font("Georgia", 14F, FontStyle.Bold);
            labelStreet.Location = new Point(30, 302);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(76, 27);
            labelStreet.TabIndex = 24;
            labelStreet.Text = "Street";
            //
            // textBoxStreet
            //
            textBoxStreet.Font = new Font("Segoe UI", 14F);
            textBoxStreet.Location = new Point(200, 299);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(520, 32);
            textBoxStreet.TabIndex = 5;
            textBoxStreet.TextChanged += entry_Changed;
            //
            // labelCity
            //
            labelCity.AutoSize = true;
            labelCity.BackColor = Color.LightSteelBlue;
            labelCity.Font = new Font("Georgia", 14F, FontStyle.Bold);
            labelCity.Location = new Point(30, 348);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(54, 27);
            labelCity.TabIndex = 25;
            labelCity.Text = "City";
            //
            // textBoxCity
            //
            textBoxCity.Font = new Font("Segoe UI", 14F);
            textBoxCity.Location = new Point(200, 345);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(230, 32);
            textBoxCity.TabIndex = 6;
            textBoxCity.TextChanged += entry_Changed;
            //
            // labelState
            //
            labelState.AutoSize = true;
            labelState.BackColor = Color.LightSteelBlue;
            labelState.Font = new Font("Georgia", 14F, FontStyle.Bold);
            labelState.Location = new Point(450, 348);
            labelState.Name = "labelState";
            labelState.Size = new Size(66, 27);
            labelState.TabIndex = 26;
            labelState.Text = "State";
            //
            // textBoxState
            //
            textBoxState.CharacterCasing = CharacterCasing.Upper;
            textBoxState.Font = new Font("Segoe UI", 14F);
            textBoxState.Location = new Point(522, 345);
            textBoxState.MaxLength = 2;
            textBoxState.Name = "textBoxState";
            textBoxState.Size = new Size(50, 32);
            textBoxState.TabIndex = 7;
            textBoxState.TextChanged += entry_Changed;
            //
            // labelZip
            //
            labelZip.AutoSize = true;
            labelZip.BackColor = Color.LightSteelBlue;
            labelZip.Font = new Font("Georgia", 14F, FontStyle.Bold);
            labelZip.Location = new Point(590, 348);
            labelZip.Name = "labelZip";
            labelZip.Size = new Size(45, 27);
            labelZip.TabIndex = 27;
            labelZip.Text = "Zip";
            //
            // textBoxZip
            //
            textBoxZip.Font = new Font("Segoe UI", 14F);
            textBoxZip.Location = new Point(640, 345);
            textBoxZip.MaxLength = 5;
            textBoxZip.Name = "textBoxZip";
            textBoxZip.Size = new Size(80, 32);
            textBoxZip.TabIndex = 8;
            textBoxZip.TextChanged += entry_Changed;
            //
            // groupBoxEntry
            //
            groupBoxEntry.BackColor = Color.AliceBlue;
            groupBoxEntry.Controls.Add(lblEntryPreview);
            groupBoxEntry.Font = new Font("Georgia", 12F, FontStyle.Bold);
            groupBoxEntry.Location = new Point(460, 90);
            groupBoxEntry.Name = "groupBoxEntry";
            groupBoxEntry.Size = new Size(260, 180);
            groupBoxEntry.TabIndex = 12;
            groupBoxEntry.TabStop = false;
            groupBoxEntry.Text = "Entry";
            //
            // lblEntryPreview
            //
            lblEntryPreview.Font = new Font("Segoe UI", 12F);
            lblEntryPreview.Location = new Point(14, 30);
            lblEntryPreview.Name = "lblEntryPreview";
            lblEntryPreview.Size = new Size(232, 140);
            lblEntryPreview.TabIndex = 0;
            //
            // btnAddContactSubmit
            //
            btnAddContactSubmit.BackColor = Color.LightSteelBlue;
            btnAddContactSubmit.Font = new Font("Cascadia Code SemiBold", 15F);
            btnAddContactSubmit.ForeColor = SystemColors.ControlText;
            btnAddContactSubmit.Location = new Point(30, 420);
            btnAddContactSubmit.Name = "btnAddContactSubmit";
            btnAddContactSubmit.Size = new Size(190, 52);
            btnAddContactSubmit.TabIndex = 9;
            btnAddContactSubmit.Text = "Add";
            btnAddContactSubmit.UseVisualStyleBackColor = false;
            btnAddContactSubmit.Click += btnAddContactSubmit_Click;
            //
            // btnAddContactReset
            //
            btnAddContactReset.BackColor = Color.LightSteelBlue;
            btnAddContactReset.Font = new Font("Cascadia Code SemiBold", 15F);
            btnAddContactReset.ForeColor = SystemColors.ControlText;
            btnAddContactReset.Location = new Point(280, 420);
            btnAddContactReset.Name = "btnAddContactReset";
            btnAddContactReset.Size = new Size(190, 52);
            btnAddContactReset.TabIndex = 10;
            btnAddContactReset.Text = "Reset";
            btnAddContactReset.UseVisualStyleBackColor = false;
            btnAddContactReset.Click += btnAddContactReset_Click;
            //
            // btnCloseAddContact
            //
            btnCloseAddContact.BackColor = Color.LightSteelBlue;
            btnCloseAddContact.Font = new Font("Cascadia Code SemiBold", 15F);
            btnCloseAddContact.ForeColor = SystemColors.ControlText;
            btnCloseAddContact.Location = new Point(530, 420);
            btnCloseAddContact.Name = "btnCloseAddContact";
            btnCloseAddContact.Size = new Size(190, 52);
            btnCloseAddContact.TabIndex = 11;
            btnCloseAddContact.Text = "Close";
            btnCloseAddContact.UseVisualStyleBackColor = false;
            btnCloseAddContact.Click += btnCloseAddContact_Click;
            //
            // AddContactForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(750, 500);
            Controls.Add(btnCloseAddContact);
            Controls.Add(btnAddContactReset);
            Controls.Add(btnAddContactSubmit);
            Controls.Add(groupBoxEntry);
            Controls.Add(textBoxZip);
            Controls.Add(labelZip);
            Controls.Add(textBoxState);
            Controls.Add(labelState);
            Controls.Add(textBoxCity);
            Controls.Add(labelCity);
            Controls.Add(textBoxStreet);
            Controls.Add(labelStreet);
            Controls.Add(textBoxWorkPhone);
            Controls.Add(labelWorkPhone);
            Controls.Add(textBoxMobilePhone);
            Controls.Add(labelMobilePhone);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(lblAddContactTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddContactForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Contact";
            Load += AddContactForm_Load;
            groupBoxEntry.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblAddContactTitle;
        private Label labelFirstName;
        private TextBox textBoxFirstName;
        private Label labelLastName;
        private TextBox textBoxLastName;
        private Label labelMobilePhone;
        private TextBox textBoxMobilePhone;
        private Label labelWorkPhone;
        private TextBox textBoxWorkPhone;
        private Label labelStreet;
        private TextBox textBoxStreet;
        private Label labelCity;
        private TextBox textBoxCity;
        private Label labelState;
        private TextBox textBoxState;
        private Label labelZip;
        private TextBox textBoxZip;
        private GroupBox groupBoxEntry;
        private Label lblEntryPreview;
        private Button btnAddContactSubmit;
        private Button btnAddContactReset;
        private Button btnCloseAddContact;
    }
}
