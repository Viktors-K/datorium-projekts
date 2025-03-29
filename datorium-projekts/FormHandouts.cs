using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace datorium_projekts
{
    public partial class FormHandouts : MaterialForm
    {
        private Item _item;
        private string _username;
        private HandoutManager _handoutManager;
        private ItemManager _itemManager;
        public FormHandouts(int item_id, string username)
        {
            // materialskin.2 skin manager instance initation
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.RemoveFormToManage(this);

            // setting private variable values

            _handoutManager = new HandoutManager("Data Source=main.db");
            _itemManager = new ItemManager("Data Source=main.db");
            _item = _itemManager.GetItem(item_id);
            _username = username;

            InitializeComponent();
            materialLabelError.Hide();
            dtpTimeUntil.Format = DateTimePickerFormat.Time;
            dtpTimeUntil.ShowUpDown = true;
            dtpTimeUntil.Value = DateTime.Now.AddHours(1);
            dtpTimeUntil.MinDate = DateTime.Now;

            // add info about item to disabled text box
            materialTextBoxType.Enabled = false;
            materialTextBoxType.Text = $"{_item.Id}: {_item.Type}";
        }

        private void materialButtonFinish_Click(object sender, EventArgs e)
        {
            DateTime selected_duetime = dtpTimeUntil.Value;
            _handoutManager.AddHandout(_item.Id, _username, selected_duetime);
            MessageBox.Show($"Vienums {_item.Id}: {_item.Type} veiksmīgi izsniegts!", "Informācija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        // method for displaying error messages
        private void ShowError(string message)
        {
            materialLabelError.Text = message;
            materialLabelError.Show();
        }
    }
}
