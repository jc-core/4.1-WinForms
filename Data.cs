using Assignment4_1.Models;

namespace Assignment4_1 {
    internal class Data {

        public static Dictionary<string, Person> Contacts { get; set; } = new(StringComparer.OrdinalIgnoreCase);

        public static void LoadContacts() {

            Person person = new Person() {
                FirstName = "Marley",
                LastName = "Raine",
                MobilePhone = "616-555-0123",
                WorkPhone = "616-555-1230",
                Street = "48 Durrey Ln",
                City = "Real City",
                State = "PA",
                Zip = "28901"
            };
            Contacts.Add(person.FullName, person);

            person = new Person() {
                FirstName = "Danielle",
                LastName = "Hartman",
                MobilePhone = "616-555-1234",
                WorkPhone = "",
                Street = "9 Mall Ring Rd",
                City = "Real City",
                State = "PA",
                Zip = "28901"
            };
            Contacts.Add(person.FullName, person);

            person = new Person() {
                FirstName = "Patty",
                LastName = "Armand",
                MobilePhone = "",
                WorkPhone = "616-555-2345",
                Street = "1200 Cheshire St",
                City = "Philly",
                State = "PA",
                Zip = "28902"
            };
            Contacts.Add(person.FullName, person);

        }

        public static List<Person> AllContacts() {

            return Contacts.Values.OrderBy(person => person.LastName).ThenBy(person => person.FirstName).ToList();

        }

        public static List<Person> Search(string name) {

            string search = name.Trim().ToLower();
            List<Person> matches = new();

            foreach (Person person in AllContacts()) {

                if (person.FullName.ToLower().Contains(search))
                    matches.Add(person);

            }

            return matches;

        }

    }
}
