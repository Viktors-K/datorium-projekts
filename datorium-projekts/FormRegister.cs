using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using System.Text.RegularExpressions;
namespace datorium_projekts
{
    public partial class FormRegister : Form
    {
        private UserManager userManager;
        public FormRegister()
        {
            InitializeComponent();
            userManager = new UserManager("Data Source=main.db");
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // booleans to check validity of input
            bool passwordMatches = (textBoxPassword.Text == textBoxRepeatPassword.Text);
            bool passwordNull = string.IsNullOrEmpty(textBoxPassword.Text) || string.IsNullOrEmpty(textBoxRepeatPassword.Text);
            bool usernameNull = string.IsNullOrEmpty(textBoxUsername.Text);
            bool otherBoxesNull = string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSurname.Text) || string.IsNullOrEmpty(textBoxClass.Text);
            
            // regex expressions for inputs
            string passwordPattern = @"^(?=.*[A-Z])(?=.*[!@#$%^&*()_+={}\[\]:;""'<>,.?/|\\]).{6,}$";
            string usernamePattern = @"^\w+$";
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // defining variables for inputs, removing all spaces
            string username = textBoxUsername.Text.Replace(" ", "");
            string email = textBoxEmail.Text.Replace(" ", "");
            string password = textBoxPassword.Text.Replace(" ", "");
            string name = textBoxName.Text.Replace(" ", "");
            string surname = textBoxSurname.Text.Replace(" ", "");
            string student_class = textBoxClass.Text.Replace(" ", "");

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
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(textBoxPassword.Text);
            try
            {
                userManager.AddUser(username, email, passwordHash, name, surname, student_class);
                password = null;
                MessageBox.Show("Lietotājs veiksmīgi reģistrēts!", "Informācija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                ShowError("Kļūda pievienojot lietotāju!");
            }
        }
        // method for displaying error messages
        private void ShowError(string message)
        {
            labelError.Text = message;
            labelError.Show();
        }
    }
}
