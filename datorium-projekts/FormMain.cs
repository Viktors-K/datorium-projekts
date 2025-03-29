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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace datorium_projekts
{
    public partial class FormMain : MaterialForm
    {
        // order is important, reservations and handouts must be initiated first
        private ReservationManager reservationManager;
        private HandoutManager handoutManager;
        private ItemManager itemManager;
        private UserManager userManager;
        private User currentUser;
        public FormMain(string username)
        {
            InitializeComponent();
            // order is important, reservations and handouts must be initiated first
            reservationManager = new ReservationManager("Data Source=main.db");
            handoutManager = new HandoutManager("Data Source=main.db");
            itemManager = new ItemManager("Data Source=main.db");
            userManager = new UserManager("Data Source=main.db");

            // materialskin.2 skin manager instance initation and setting theme settings
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            
            // get user instance
            currentUser = userManager.GetUser(username);
            AddItemsToListView(materialListViewItems);

            // add admin only functions if user is admin, otherwise remove not needed tabs
            if (currentUser.Admin) AdminSetup();
            else
            {
                materialLabelUsername.Text = $"Lietotājs {currentUser.Username}";
                materialTabControlMain.TabPages.Remove(tabPageAdminItem);
                materialTabControlMain.TabPages.Remove(tabPageAdminUser);
            }

            // add users StudentClass value to label if not null, otherwise hide it
            if (currentUser.StudentClass != null) materialLabelGrade.Text = $"{currentUser.StudentClass} klase";
            else materialLabelGrade.Visible = false;

            // user info on user page
            materialLabelName.Text = $"{currentUser.Name} {currentUser.Surname}";
        }

        // add admin specific information and populate tables with info for admins
        public void AdminSetup()
        {
            materialLabelUsername.Text = $"Administrators {currentUser.Username}";
            AddUsersToListView(materialListViewUsers);
            AddItemsToListView(materialListViewAdminItems);
        }
        // method for adding items to a listview object
        public void AddItemsToListView(MaterialListView listView)
        {
            listView.View = View.Details;
            listView.Items.Clear();
            List<Item> item_list = itemManager.GetAllItems();

            foreach (Item item in item_list)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());

                // set item color based on status
                if (item.Status == "available") listViewItem.BackColor = Color.Green;
                else if (item.Status == "reserved") listViewItem.BackColor = Color.Yellow;
                else if (item.Status == "taken") listViewItem.BackColor = Color.Orange;

                listViewItem.SubItems.Add(item.Type);
                listViewItem.SubItems.Add(item.Details);
                listViewItem.SubItems.Add(item.Status);
                listView.Items.Add(listViewItem);
            }
        }
        // method for adding users in a listview object 
        public void AddUsersToListView(MaterialListView listView)
        {
            listView.View = View.Details;
            listView.Items.Clear();

            List<User> user_list = userManager.GetAllUsers();
            foreach (User user in user_list)
            {
                ListViewItem listViewItem = new ListViewItem(user.Id.ToString());
                listViewItem.SubItems.Add(user.Username);
                listViewItem.SubItems.Add(user.Email);
                listViewItem.SubItems.Add(user.Admin ? "Administrators" : "Lietotājs");
                listViewItem.SubItems.Add(user.Name);
                listViewItem.SubItems.Add(user.Surname);
                listViewItem.SubItems.Add(user.StudentClass);
                listView.Items.Add(listViewItem);
            }
        }
        // method for creating a dialog in the admin inventory tab
        private void adminItemDialog(string objective, int item_id)
        {
            FormAdminItems formAdminItems = new FormAdminItems(objective, item_id);
            formAdminItems.Show();
            formAdminItems.FormClosed += (s, ev) =>
            {
                AddItemsToListView(materialListViewAdminItems);
                AddItemsToListView(materialListViewItems);
            };
        }
        // method for creating a dialog in the handout tab
        private void handoutDialog(int item_id)
        {
            FormHandouts formHandouts = new FormHandouts(item_id, currentUser.Username);
            formHandouts.Show();
            formHandouts.FormClosed += (s, ev) =>
            {
                AddItemsToListView(materialListViewAdminItems);
                AddItemsToListView(materialListViewItems);
            };
        }
        private void materialButtonAdminItemCreate_Click(object sender, EventArgs e)
        {
            adminItemDialog("create", 1);
        }

        private void materialButtonAdminItemUpdate_Click(object sender, EventArgs e)
        {
            if (materialListViewAdminItems.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = materialListViewAdminItems.SelectedItems[0];
                int item_id = Convert.ToInt32(selectedItem.SubItems[0].Text);
                adminItemDialog("update", item_id);
            }
        }

        private void materialButtonDelete_Click(object sender, EventArgs e)
        {
            if (materialListViewAdminItems.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = materialListViewAdminItems.SelectedItems[0];
                int item_id = Convert.ToInt32(selectedItem.SubItems[0].Text);
                itemManager.DeleteItem(item_id);
                AddItemsToListView(materialListViewAdminItems);
                AddItemsToListView(materialListViewItems);
            }
        }

        private void materialButtonItemTake_Click(object sender, EventArgs e)
        {
            if (materialListViewItems.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = materialListViewItems.SelectedItems[0];
                int item_id = Convert.ToInt32(selectedItem.SubItems[0].Text);
                handoutDialog(item_id);
            }
        }

        private void materialButtonItemReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
