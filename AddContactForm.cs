using Assignment4_1.Models;
using static System.Globalization.CultureInfo;                                    
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
            addPerson.FirstName = Capitalize(textBoxFirstName.Text).Trim();
            addPerson.LastName = Capitalize(textBoxLastName.Text).Trim();
            addPerson.MobilePhone = textBoxMobilePhone.Text.Trim();
            addPerson.WorkPhone = textBoxWorkPhone.Text.Trim();
            addPerson.Street = AddressFormat(textBoxStreet.Text).Trim();
            addPerson.City = AddressFormat(textBoxCity.Text).Trim();
            addPerson.State = textBoxState.Text.ToUpper().Trim();
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
                FirstName = Capitalize(textBoxFirstName.Text).Trim(),
                LastName = Capitalize(textBoxLastName.Text).Trim(),
                MobilePhone = textBoxMobilePhone.Text.Trim(),
                WorkPhone = textBoxWorkPhone.Text.Trim(),
                Street = AddressFormat(textBoxStreet.Text).Trim(),
                City = AddressFormat(textBoxCity.Text).Trim(),
                State = textBoxState.Text.ToUpper().Trim(),
                Zip = textBoxZip.Text.Trim()
            };

            lblEntryPreview.Text = preview.Entry;

        }

        private string Capitalize(string text) {
            if (text == "")
                return text;
            return char.ToUpper(text[0]) + text.Substring(1);
        }
        private string AddressFormat(string text) {
        
            return CurrentCulture.TextInfo.ToTitleCase(text.ToLower());

        }
    }
}
