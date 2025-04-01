using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace datorium_projekts
{
    public partial class FormReservations : MaterialForm
    {
        private Item _item;
        private string _username;
        private ReservationManager _reservationManager;
        private ItemManager _itemManager;
        public FormReservations(int item_id, string username)
        {
            // materialskin.2 skin manager instance initation
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.RemoveFormToManage(this);

            // setting private variable values
            _reservationManager = new ReservationManager("Data Source=main.db");
            _itemManager = new ItemManager("Data Source=main.db");
            _item = _itemManager.GetItem(item_id);
            _username = username;

            InitializeComponent();
            materialLabelError.Hide();

            // dtp formatting
            dtpTimeUntil.Format = DateTimePickerFormat.Time;
            dtpTimeFrom.Format = DateTimePickerFormat.Time;
            dtpTimeUntil.ShowUpDown = true;
            dtpTimeFrom.ShowUpDown = true;
            dtpTimeUntil.Value = DateTime.Now.AddHours(2);
            dtpTimeFrom.Value = DateTime.Now.AddHours(1);
            dtpTimeUntil.MinDate = DateTime.Now;
            dtpTimeFrom.MinDate = DateTime.Now;

            // add info about item to disabled text box
            materialTextBoxType.Enabled = false;
            materialTextBoxType.Text = $"{_item.Id}: {_item.Type}";
        }

        private void materialButtonFinish_Click(object sender, EventArgs e)
        {
            DateTime time_from = dtpTimeFrom.Value;
            DateTime time_until = dtpTimeUntil.Value;
            if (time_from > time_until)
            {
                ShowError("Nepareizs laiks!");
                return;
            }
            _reservationManager.AddReservation(_item.Id, _username, time_from, time_until);
            MessageBox.Show($"Vienums {_item.Id}: {_item.Type} veiksmīgi rezervēts!", "Informācija", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
