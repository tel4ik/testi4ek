using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mvc.Model;
using mvc.DAL;
using mvc.Controller;

namespace mvc.View
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();

            comboBox1.DataSource = MainController.GetStatues();
        }

        private void label1_Click(object sender, EventArgs e)
        {
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var items = new ToDoItem
            {
                Name = textBox1.Text,
                Description = textBox2.Text,
                Status = comboBox1.Text
        };

            MainController.AddItems(items);

            this.Close();

        }
    }
}
