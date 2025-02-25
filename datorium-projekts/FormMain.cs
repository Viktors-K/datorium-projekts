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
    public partial class FormMain : MaterialForm
    {
        private ItemManager itemManager;
        private UserManager userManager;
        private User currentUser;
        public FormMain(string username)
        {
            InitializeComponent();
            userManager = new UserManager("Data Source=main.db");
            itemManager = new ItemManager("Data Source=main.db");
            currentUser = userManager.GetUser(username);
            AddItemsToTable();

            //labelWelcome.Text = $"Laipni lūgti, {currentUser.Name} {currentUser.Surname}!";
            // groupBoxUserControls.Text = $"Lietotājs {currentUser.Username}";
            if (currentUser.Admin)
            {
                //    labelRole.Text = $"Pieslēdzies kā: Administrators";
            }
            else
            {
                //    labelRole.Text = $"Pieslēdzies kā: Lietotājs";
                //    tabControlMain.TabPages.Remove(tabPageAdminItem);
                //    tabControlMain.TabPages.Remove(tabPageAdminUser);
            }
        }
        public void AddItemsToTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Veids", typeof(string));
            dt.Columns.Add("Apraksts", typeof(string));

            // import Item data
            List<Item> item_list = itemManager.GetAllItems();
            foreach (Item item in item_list)
            {
                object[] row = new object[]
                {
                    (int)item.Id,
                    (string)item.Type,
                    (string)item.Details
                };
                dt.Rows.Add(row);
            }
            //dataGridViewItems.DataSource = dt;
        }
    }
}
