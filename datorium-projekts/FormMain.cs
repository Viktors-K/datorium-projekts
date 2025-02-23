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
    public partial class FormMain : Form
    {
        private ItemManager itemManager;
        public FormMain()
        {
            InitializeComponent();
            itemManager = new ItemManager("Data Source=main.db");
            AddItemsToTable();
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
            dataGridViewItems.DataSource = dt;
        }


    }
}
