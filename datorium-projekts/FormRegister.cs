using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datorium_projekts
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            bool passwordMatches = (textBoxPassword.Text == textBoxRepeatPassword.Text);
            bool passwordNull = string.IsNullOrEmpty(textBoxPassword.Text) || string.IsNullOrEmpty(textBoxRepeatPassword.Text);
            if (!passwordMatches) {
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
            this.Close();
        }
    }
}
