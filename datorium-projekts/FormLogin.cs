using BCrypt.Net;
using MaterialSkin;
using MaterialSkin.Controls;
namespace datorium_projekts
{
    public partial class FormLogin : MaterialForm
    {
        private UserManager userManager;
        private MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public FormLogin()
        {
            InitializeComponent();
            userManager = new UserManager("Data Source=main.db");
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"[{DateTime.Now}] click on register button");

                FormRegister formRegister = new FormRegister();
                System.Diagnostics.Debug.WriteLine($"[{DateTime.Now}] created registration form");

                formRegister.FormClosed += (s, args) =>
                {
                    if (formRegister.Tag != null && formRegister.Tag.ToString() == "Success")
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            System.Diagnostics.Debug.WriteLine($"[{DateTime.Now}] register success.");
                            MessageBox.Show("Lietotājs veiksmīgi reģistrēts!", "Informācija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        });
                    }
                };
                formRegister.Show(); // Open on a separate thread
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
    }
}
