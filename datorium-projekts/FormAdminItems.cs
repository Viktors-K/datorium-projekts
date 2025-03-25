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
    public partial class FormAdminItems : MaterialForm
    {
        private int _oldItemId;
        private string _goal;
        private ItemManager _itemManager;
        public FormAdminItems(string goal, int item_id)
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.RemoveFormToManage(this);
            _oldItemId = item_id;
            _goal = goal;
            _itemManager = new ItemManager("Data Source=main.db");
            InitializeComponent();
            materialLabelError.Hide();
            if (_goal == "update")
            {
                Item old_item = _itemManager.GetItem(_oldItemId);
                materialTextBoxType.Text = old_item.Type;
                materialTextBoxDetails.Text = old_item.Details;
                Text = "Vienuma atjaunošana";
                materialButtonFinish.Text = "Atjaunot";
            }
            else if (_goal == "create")
            {
                Text = "Vienuma pievienošana";
                materialButtonFinish.Text = "Pievienot";
            }
        }

        private void materialButtonFinish_Click(object sender, EventArgs e)
        {
            string newType = materialTextBoxType.Text;
            string newDetails = materialTextBoxDetails.Text;

            if (string.IsNullOrWhiteSpace(newType))
            {
                ShowError("Veids nevar būt tukšs!");
                return;
            }

            if (_goal == "update")
            {
                Item old_item = _itemManager.GetItem(_oldItemId);
                Item new_item = new Item(
                    id: old_item.Id,
                    type: newType,
                    status: old_item.Status,
                    details: newDetails
                );
                _itemManager.EditItem(new_item, old_item);
                Close();
            }
            else if (_goal == "create")
            {
                _itemManager.AddItem(newType, "available", newDetails);
                Close();
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
