namespace Assignment4_1 {
    internal static class Program {

        [STAThread]
        static void Main() {

            ApplicationConfiguration.Initialize();

            Data.LoadContacts();

            Application.Run(new MainForm());

        }
    }
}
