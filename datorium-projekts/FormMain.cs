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
            AddItemsToListView();

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
        public void AddItemsToListView()
        {
            materialListViewItems.View = View.Details; // Ensure the ListView is in Details mode
            materialListViewItems.Items.Clear();

            // Import Item Data
            List<Item> item_list = itemManager.GetAllItems();
            foreach (Item item in item_list)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.Type);
                listViewItem.SubItems.Add(item.Details);

                materialListViewItems.Items.Add(listViewItem);
            }
        }
    }
}
