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
            // defining variables for inputs, removing all spaces
            string password = textBoxPassword.Text.Replace(" ", "");
            string username = textBoxUsername.Text.Replace(" ", "");

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
            } catch (Exception ex)
            {
                ShowError("Kļūda lietotāja atrašanā!");
                return;
            }

            // successful login, discard password
            password = null;
            labelError.Hide();
            textBoxPassword.Text = null;
            textBoxUsername.Text = null;
            MessageBox.Show("Lietotājs veiksmīgi pieslēgts!", "Informācija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // hide current form and open new one, when new form closed, close this one as well.
            FormMain newForm = new FormMain();
            this.Hide();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }

        // method for displaying error messages
        private void ShowError(string message)
        {
            labelError.Text = message;
            labelError.Show();
        }
    }
}
