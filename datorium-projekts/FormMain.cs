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
        private ItemManager itemManager;
        private UserManager userManager;
        private ReservationManager reservationManager;
        private HandoutManager handoutManager;
        private User currentUser;
        public FormMain(string username)
        {
            InitializeComponent();
            reservationManager = new ReservationManager("Data Source=main.db");
            handoutManager = new HandoutManager("Data Source=main.db");
            userManager = new UserManager("Data Source=main.db");
            itemManager = new ItemManager("Data Source=main.db");
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
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
        public void AdminSetup()
        {
            materialLabelUsername.Text = $"Administrators {currentUser.Username}";
            AddUsersToListView();
            AddItemsToListView(materialListViewAdminItems);
        }
        public void AddItemsToListView(MaterialListView listView)
        {
            listView.View = View.Details;
            listView.Items.Clear();

            List<Item> item_list = itemManager.GetAllItems();
            foreach (Item item in item_list)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.Type);
                listViewItem.SubItems.Add(item.Details);
                listViewItem.SubItems.Add(item.Status);
                listView.Items.Add(listViewItem);
            }
        }
        public void AddUsersToListView()
        {
            materialListViewUsers.View = View.Details;
            materialListViewUsers.Items.Clear();

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
                materialListViewUsers.Items.Add(listViewItem);
            }
        }

        private void materialButtonAdminItemCreate_Click(object sender, EventArgs e)
        {
            FormAdminItems formAdminItems = new FormAdminItems("create", 1);
            formAdminItems.Show();
            formAdminItems.FormClosed += (s, ev) =>
            {
                AddItemsToListView(materialListViewAdminItems);
                AddItemsToListView(materialListViewItems);
            };
        }

        private void materialButtonAdminItemUpdate_Click(object sender, EventArgs e)
        {
            if (materialListViewAdminItems.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = materialListViewAdminItems.SelectedItems[0];
                int item_id = Convert.ToInt32(selectedItem.SubItems[0].Text);
                FormAdminItems formAdminItems = new FormAdminItems("update", item_id);
                formAdminItems.Show();
                formAdminItems.FormClosed += (s, ev) =>
                {
                    AddItemsToListView(materialListViewAdminItems);
                    AddItemsToListView(materialListViewItems);
                };
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
    }
}
