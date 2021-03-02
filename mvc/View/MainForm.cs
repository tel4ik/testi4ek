using mvc.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mvc.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            dataGridView3.DataSource = MainController.GetItems();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var form = new ItemForm();
            form.ShowDialog();

            dataGridView3.DataSource = null;
            dataGridView3.DataSource = MainController.GetItems();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 0)
            {
                return;
            }

            var row = dataGridView3.SelectedRows[0].Index;

            var items = MainController.GetItems();
            var item = items[row];

            MainController.DeleteItems(item);

            dataGridView3.DataSource = null;
            dataGridView3.DataSource = MainController.GetItems();
        }


    }
}
