namespace Assignment4_1.Models {

    internal class Person {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MobilePhone { get; set; }
        public string? WorkPhone { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public string Address {

            get {

                List<string> name = new();

                if (!string.IsNullOrWhiteSpace(Street)) name.Add(Street);
                if (!string.IsNullOrWhiteSpace(City)) name.Add(City);
                if (!string.IsNullOrWhiteSpace(State) || !string.IsNullOrWhiteSpace(Zip)) name.Add($"{State} {Zip}".Trim());

                return string.Join(", ", name);

            }

        }

        public string Entry {

            get {

                string name = $"{LastName}, {FirstName}".Trim(' ', ',');
                string mobileNumber = string.IsNullOrWhiteSpace(MobilePhone) ? "" : $"Mobile: {MobilePhone}\n";
                string workNumber = string.IsNullOrWhiteSpace(WorkPhone) ? "" : $"Work: {WorkPhone}\n";

                return $"{name}\n{mobileNumber}{workNumber}{Address}";

            }

        }

    }
}
