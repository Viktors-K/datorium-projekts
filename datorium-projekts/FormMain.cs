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
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            currentUser = userManager.GetUser(username);
            AddItemsToListView();
            
            if (currentUser.Admin)
            {
                AdminSetup();
            }
            else
            {
                materialLabelUsername.Text = $"Lietotājs {currentUser.Username}";
                materialTabControlMain.TabPages.Remove(tabPageAdminItem);
                materialTabControlMain.TabPages.Remove(tabPageAdminUser);
            }

            materialLabelName.Text = $"{currentUser.Name} {currentUser.Surname}";

            if (currentUser.StudentClass != null) 
            {
                materialLabelGrade.Text = $"{currentUser.StudentClass} klase";
            }
            else
            {
                materialLabelGrade.Visible = false;
            }
        }
        public void AdminSetup()
        {
            materialLabelUsername.Text = $"Administrators {currentUser.Username}";
            AddUsersToListView();
        }
        public void AddItemsToListView()
        {
            materialListViewItems.View = View.Details;
            materialListViewItems.Items.Clear();

            List<Item> item_list = itemManager.GetAllItems();
            foreach (Item item in item_list)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.Type);
                listViewItem.SubItems.Add(item.Details);
                listViewItem.SubItems.Add(item.Status);
                materialListViewItems.Items.Add(listViewItem);
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
    }
}
