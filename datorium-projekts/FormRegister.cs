using BCrypt.Net;
using System.Text.RegularExpressions;
using MaterialSkin;
using MaterialSkin.Controls;

namespace datorium_projekts
{
    public partial class FormRegister : MaterialForm
    {
        private UserManager userManager;
        public FormRegister()
        {
            InitializeComponent();
            userManager = new UserManager("Data Source=main.db");
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.RemoveFormToManage(this);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // booleans to check validity of input
            bool passwordMatches = (materialTextBoxPassword.Text == materialTextBoxRepeatPassword.Text);
            bool passwordNull = string.IsNullOrEmpty(materialTextBoxPassword.Text) || string.IsNullOrEmpty(materialTextBoxRepeatPassword.Text);
            bool usernameNull = string.IsNullOrEmpty(materialTextBoxUsername.Text);
            bool otherBoxesNull = string.IsNullOrEmpty(materialTextBoxEmail.Text) || string.IsNullOrEmpty(materialTextBoxName.Text) || string.IsNullOrEmpty(materialTextBoxSurname.Text) || string.IsNullOrEmpty(materialTextBoxClass.Text);

            // regex expressions for inputs
            string passwordPattern = @"^(?=.*[A-Z])(?=.*[!@#$%^&*()_+={}\[\]:;""'<>,.?/|\\]).{6,}$";
            string usernamePattern = @"^\w+$";
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // defining variables for inputs, removing all spaces
            string username = materialTextBoxUsername.Text.Replace(" ", "");
            string email = materialTextBoxEmail.Text.Replace(" ", "");
            string password = materialTextBoxPassword.Text.Replace(" ", "");
            string name = materialTextBoxName.Text.Replace(" ", "");
            string surname = materialTextBoxSurname.Text.Replace(" ", "");
            string student_class = materialTextBoxClass.Text.Replace(" ", "");

            // checking validity of inputs
            if (!passwordMatches)
            {
                ShowError("Paroles nav vienādas!");
                return;
            }
            if (passwordNull)
            {
                ShowError("Parole nevar būt tukša!");
                return;
            }
            if (usernameNull)
            {
                ShowError("Lietotājvārds nevar būt tukšs!");
                return;
            }
            if (otherBoxesNull)
            {
                ShowError("Pārējie lauciņi nevar būt tukši!");
                return;
            }

            // check if inputs match regex patterns
            if (!Regex.IsMatch(username, usernamePattern))
            {
                ShowError("Lietotājvārdā var izmantot tikai burtus, skaitļus un _ simbolu!");
                return;
            };
            if (!Regex.IsMatch(password, passwordPattern))
            {
                ShowError("Parolei jābūt vismaz 6 rakstzīmju garai, un \njāizmanto vienu lielo burtu un vienu simbolu!");
                return;
            };
            if (!Regex.IsMatch(email, emailPattern))
            {
                ShowError("E-pasts nav derīgs!");
                return;
            };

            // check if inputs are unique
            if (userManager.UsernameExists(username))
            {
                ShowError("Lietotājs ar šādu lietotājvārdu jau eksistē!");
                return;
            };
            if (userManager.EmailExists(email))
            {
                ShowError("Lietotājs ar šādu e-pastu jau eksistē!");
                return;
            };

            // register user with encrypted and salted password if input valid
            RegisterUser(username, email, password, name, surname, student_class);
            this.DialogResult = DialogResult.OK;
        }
        private async void RegisterUser(string username, string email, string password, string name, string surname, string student_class)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            try
            {
                await Task.Run(() => userManager.AddUser(username, email, passwordHash, name, surname, student_class));

                Invoke((MethodInvoker)delegate
                {
                    Hide();
                    MessageBox.Show("Lietotājs veiksmīgi reģistrēts!", "Informācija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                });
            }
            catch
            {
                ShowError("Kļūda pievienojot lietotāju!");
            }
        }

        // method for displaying error messages
        private void ShowError(string message)
        {
            materialLabelError.Text = message;
            materialLabelError.Show();
        }
    }
}
