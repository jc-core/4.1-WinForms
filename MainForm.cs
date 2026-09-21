using Assignment4_1.Models;

namespace Assignment4_1 {
    public partial class MainForm : Form {

        private List<Person> visibleContacts = new();

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            dataGridContacts.AutoGenerateColumns = false;
            RefreshGrid(Data.AllContacts());

        }

        private void btnSearch_Click(object sender, EventArgs e) {

            if (textBoxSearch.Text.Trim() == "") {
                MessageBox.Show("Type a name to search.");
                textBoxSearch.Select();
                return;
            }

            List<Person> foundContacts = Data.Search(textBoxSearch.Text);

            if (foundContacts.Count == 0) {
                MessageBox.Show($"Nobody named \"{textBoxSearch.Text.Trim()}\" in the phone book.", "Not Found");
                textBoxSearch.SelectAll();
                return;
            }

            RefreshGrid(foundContacts);

        }

        private void btnShowAll_Click(object sender, EventArgs e) {

            textBoxSearch.Clear();
            RefreshGrid(Data.AllContacts());

        }

        private void btnAddContact_Click(object sender, EventArgs e) {

            Hide();

            AddContactForm addContact = new AddContactForm();
            addContact.ShowDialog();

            Show();
            RefreshGrid(Data.AllContacts());

        }

        private void btnDeleteContact_Click(object sender, EventArgs e) {

            if (dataGridContacts.CurrentRow == null) {
                MessageBox.Show("Select a contact first.");
                return;
            }

            Person selectedContact = visibleContacts[dataGridContacts.CurrentRow.Index];

            DialogResult result = MessageBox.Show($"Delete {selectedContact.FullName} from the phone book?", "Delete Contact", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) {

                Data.Contacts.Remove(selectedContact.FullName);
                visibleContacts.Remove(selectedContact);
                RefreshGrid(visibleContacts);

            }

        }

        private void dataGridContacts_SelectionChanged(object sender, EventArgs e) {

            if (dataGridContacts.CurrentRow == null || dataGridContacts.CurrentRow.Index >= visibleContacts.Count)
                ShowCard(null);
            else
                ShowCard(visibleContacts[dataGridContacts.CurrentRow.Index]);

        }

        private void RefreshGrid(List<Person> currentList) {

            visibleContacts = currentList;
            dataGridContacts.DataSource = null;
            dataGridContacts.DataSource = visibleContacts;

            contactCardGroupBox.Text = visibleContacts.Count == 1 ? "1 contact" : $"{visibleContacts.Count} contacts";

        }

        private void ShowCard(Person? contact) {

            if (contact == null) {
                lblCardName.Text = "";
                lblCardMobile.Text = "";
                lblCardWork.Text = "";
                lblCardAddress.Text = "";
                return;
            }

            lblCardName.Text = contact.FullName;
            lblCardMobile.Text = contact.MobilePhone == "" ? "Mobile: -" : $"Mobile: {contact.MobilePhone}";
            lblCardWork.Text = contact.WorkPhone == "" ? "Work: -" : $"Work: {contact.WorkPhone}";
            lblCardAddress.Text = contact.Address;

        }

    }
}
