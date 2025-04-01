using BCrypt.Net;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.Sqlite;
namespace datorium_projekts
{
    public partial class FormLogin : MaterialForm
    {
        // order is important, reservations and handouts must be initiated first
        private ReservationManager reservationManager;
        private HandoutManager handoutManager;
        private ItemManager itemManager;
        private UserManager userManager;

        private MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public FormLogin()
        {
            InitializeComponent();

            // order is important, reservations and handouts must be initiated first
            reservationManager = new ReservationManager("Data Source=main.db");
            handoutManager = new HandoutManager("Data Source=main.db");
            itemManager = new ItemManager("Data Source=main.db");
            userManager = new UserManager("Data Source=main.db");

            PopulateDatabasesIfEmpty();

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // defining variables for inputs, removing all spaces
            string password = materialTextBoxPassword.Text.Replace(" ", "");
            string username = materialTextBoxUsername.Text.Replace(" ", "");

            // check if fields are not null
            if (string.IsNullOrEmpty(password))
            {
                ShowError("Parole ir tukša!");
                return;
            }
            if (string.IsNullOrEmpty(username))
            {
                ShowError("Lietotājvārds ir tukšs!");
                return;
            }

            // try to find user with given username, otherwise return error
            try
            {
                User user = userManager.GetUser(username);
                if (user == null)
                {
                    ShowError("Lietotājs neeksistē!");
                    return;
                }
                // check if password matches saved hash
                if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                {
                    ShowError("Parole ir nepareiza!");
                    return;
                }
            }
            catch (Exception ex)
            {
                ShowError("Kļūda lietotāja atrašanā!");
                MessageBox.Show(ex.Message);
                return;
            }

            // successful login, discard password
            password = null;
            materialLabelError.Hide();
            materialTextBoxPassword.Text = null;
            materialTextBoxUsername.Text = null;
            MessageBox.Show("Lietotājs veiksmīgi pieslēgts!", "Informācija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // hide current form and open new one, when new form closed, close this one as well.
            FormMain newForm = new FormMain(username);
            username = null;
            this.Hide();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }

        // method for displaying error messages
        private void ShowError(string message)
        {
            materialLabelError.Text = message;
            materialLabelError.Show();
        }
        // sample data for db
        private void PopulateDatabasesIfEmpty()
        {
            if (itemManager.GetAllItems().Count == 0)
            {
                itemManager.AddItem("Dators", "available", "Windows OS");
                itemManager.AddItem("Lādētājs", "available", "9V DC");
                itemManager.AddItem("Datorpele", "available", "USB-A");
                itemManager.AddItem("Dators", "available", "Chromebook");
                itemManager.AddItem("Lādētājs", "available", "9V DC");
                itemManager.AddItem("Datorpele", "available", "USB-A");
            }
            if (userManager.GetAllUsers().Count == 0)
            {
                string hash = BCrypt.Net.BCrypt.HashPassword("Admin12$");
                userManager.AddUser("admin", "admin@admin.lv", hash, "Admin", "Istrators", null, true);
            }
        }
    }
}
