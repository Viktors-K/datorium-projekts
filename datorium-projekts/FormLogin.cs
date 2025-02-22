using BCrypt.Net;
namespace datorium_projekts
{
    public partial class FormLogin : Form
    {
        private UserManager userManager;
        public FormLogin()
        {
            InitializeComponent();
            userManager = new UserManager("Data Source=main.db");
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            string username = textBoxUsername.Text;
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
            try
            {
                User user = userManager.GetUser(username);
                if (user == null)
                {
                    ShowError("Lietotājs neeksistē!");
                    return;
                }
                if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                {
                    ShowError("Parole ir nepareiza!");
                    return;
                }
            } catch (Exception ex)
            {
                ShowError("Kļūda lietotāja atrašanā!");
                return;
            }
            // successful login
            password = null;
            labelError.Hide();
            textBoxPassword.Text = null;
            textBoxUsername.Text = null;
            MessageBox.Show("Lietotājs veiksmīgi pieslēgts!", "Informācija", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // method for displaying error messages
        private void ShowError(string message)
        {
            labelError.Text = message;
            labelError.Show();
        }
    }
}
