using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallDatabase
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<(string, string, string, string, string, string, string, string, string)> data = Form1.LoadEverything();

            DataTable table = new DataTable();

            table.Columns.Add("Student ID");
            table.Columns.Add("First Name");
            table.Columns.Add("Last Name");
            table.Columns.Add("Middle Name");
            table.Columns.Add("Age");
            table.Columns.Add("Gender");
            table.Columns.Add("Date Of Birth");
            table.Columns.Add("Contact Number");
            table.Columns.Add("Email");

            foreach(var item in data)
            {
                table.Rows.Add(item.Item1, item.Item2, item.Item3, item.Item4, item.Item5, item.Item6, item.Item7, item.Item8, item.Item9); 
            }

            dataGridView1.DataSource = table;
            // Adjust the form size to fit the DataGridView
            int width = dataGridView1.PreferredSize.Width;
            int height = dataGridView1.PreferredSize.Height;

            this.ClientSize = new Size(width, height);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Form1 for1 = new Form1();
            for1.Show();
        }




    }
}
