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
            bool passwordMatches = (textBoxPassword.Text == textBoxRepeatPassword.Text);
            bool passwordNull = string.IsNullOrEmpty(textBoxPassword.Text) || string.IsNullOrEmpty(textBoxRepeatPassword.Text);
            bool usernameNull = string.IsNullOrEmpty(textBoxUsername.Text);
            bool otherBoxesNull = string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSurname.Text) || string.IsNullOrEmpty(textBoxClass.Text);
            if (!passwordMatches)
            {
                labelError.Text = "Paroles nav vienādas!";
                labelError.Show();
                return;
            }
            if (passwordNull)
            {
                labelError.Text = "Parole nevar būt tukša!";
                labelError.Show();
                return;
            }
            if (usernameNull)
            {
                labelError.Text = "Lietotājvārds nevar būt tukšs!";
                labelError.Show();
                return;
            }
            if (otherBoxesNull)
            {
                labelError.Text = "Pārējie lauciņi nevar būt tukši!";
                labelError.Show();
                return;
            }
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(textBoxPassword.Text);
            userManager.AddUser(
                username: textBoxUsername.Text,
                email: textBoxEmail.Text,
                password_hash: passwordHash,
                name: textBoxName.Text,
                surname: textBoxSurname.Text,
                student_class: textBoxClass.Text
            );
            this.Close();
        }
    }
}
