using Assignment4_1.Models;

namespace Assignment4_1 {
    public partial class AddContactForm : Form {

        public AddContactForm() {
            InitializeComponent();
        }

        private void AddContactForm_Load(object sender, EventArgs e) {

            textBoxFirstName.Select();
            EntryPreview();

        }

        private void btnAddContactSubmit_Click(object sender, EventArgs e) {

            if (textBoxFirstName.Text.Trim() == "") {
                MessageBox.Show("Enter a first name.");
                textBoxFirstName.Select();
                return;
            }

            if (textBoxLastName.Text.Trim() == "") {
                MessageBox.Show("Enter a last name.");
                textBoxLastName.Select();
                return;
            }

            if (textBoxMobilePhone.Text.Trim() == "" && textBoxWorkPhone.Text.Trim() == "") {
                MessageBox.Show("Enter a mobile or work phone.");
                textBoxMobilePhone.Select();
                return;
            }

            Person addPerson = new Person();
            addPerson.FirstName = textBoxFirstName.Text.Trim();
            addPerson.LastName = textBoxLastName.Text.Trim();
            addPerson.MobilePhone = textBoxMobilePhone.Text.Trim();
            addPerson.WorkPhone = textBoxWorkPhone.Text.Trim();
            addPerson.Street = textBoxStreet.Text.Trim();
            addPerson.City = textBoxCity.Text.Trim();
            addPerson.State = textBoxState.Text.Trim().ToUpper();
            addPerson.Zip = textBoxZip.Text.Trim();

            if (Data.Contacts.ContainsKey(addPerson.FullName)) {
                MessageBox.Show($"{addPerson.FullName} is already in the phone book.", "Duplicate");
                textBoxFirstName.Select();
                return;
            }

            Data.Contacts.Add(addPerson.FullName, addPerson);
            MessageBox.Show("Contact added.");

            ClearForm();
        }
        private void btnCloseAddContact_Click(object sender, EventArgs e) {

            Close();

        }
        private void btnAddContactReset_Click(object sender, EventArgs e) {
            ClearForm();
        }
        private void entry_Changed(object sender, EventArgs e) {

            EntryPreview();

        }

        private void ClearForm() {

            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxMobilePhone.Clear();
            textBoxWorkPhone.Clear();
            textBoxStreet.Clear();
            textBoxCity.Clear();
            textBoxState.Clear();
            textBoxZip.Clear();
            textBoxFirstName.Select();
            EntryPreview();
        }
        private void EntryPreview() {

            Person preview = new Person() {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                MobilePhone = textBoxMobilePhone.Text,
                WorkPhone = textBoxWorkPhone.Text,
                Street = textBoxStreet.Text,
                City = textBoxCity.Text,
                State = textBoxState.Text.ToUpper(),
                Zip = textBoxZip.Text
            };

            lblEntryPreview.Text = preview.Entry;

        }


    }
}
