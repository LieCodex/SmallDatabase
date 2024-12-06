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
    public partial class Form2 : Form
    {
        public static string search_term { get; set; }
        public static int _id { get; set; }
        public Form2(string data, int id)
        {
            InitializeComponent();
            search_term = data;
            _id = id;

        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            FirstNameTB.ReadOnly = false;
            LastNameTB.ReadOnly = false;
            MiddleNameTB.ReadOnly = false;
            AgeTB.ReadOnly = false;
            GenderTB.ReadOnly = false;
            DateOfBirthTB.ReadOnly = false;
            ContactNumberTB.ReadOnly = false;
            emailTB.ReadOnly = false;
            saveBTN.Enabled = true;
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            FirstNameTB.ReadOnly = true;
            LastNameTB.ReadOnly = true;
            MiddleNameTB.ReadOnly = true;
            AgeTB.ReadOnly = true;
            GenderTB.ReadOnly = true;
            DateOfBirthTB.ReadOnly = true;
            ContactNumberTB.ReadOnly = true;
            emailTB.ReadOnly = true;
            saveBTN.Enabled = false;
            Form1.SaveData(Int32.Parse(IDTB.Text), FirstNameTB.Text, LastNameTB.Text, MiddleNameTB.Text, Int32.Parse(AgeTB.Text), GenderTB.Text, DateTime.Parse(DateOfBirthTB.Text).Date, ContactNumberTB.Text, emailTB.Text);
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this data?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form1.Delete(int.Parse(IDTB.Text));
                this.Close();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                return;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<(string, string, string, string, string, string, string, string, string)> dataset = Form1.LoadEverything();

            int target = _id;

            int left = 0;
            int right = dataset.Count - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (middle == target)
                {
                    IDTB.Text = dataset[middle].Item1;
                    FirstNameTB.Text = dataset[middle].Item2;
                    LastNameTB.Text = dataset[middle].Item3;
                    MiddleNameTB.Text = dataset[middle].Item4;
                    AgeTB.Text = dataset[middle].Item5;
                    GenderTB.Text = dataset[middle].Item6;
                    DateOfBirthTB.Text = dataset[middle].Item7;
                    ContactNumberTB.Text = dataset[middle].Item8;
                    emailTB.Text = dataset[middle].Item9;
                    student_name.Text = dataset[middle].Item2 + " " + dataset[middle].Item3;
                    break;
                }
                else if (target > middle)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Form1 for1 = new Form1();
            for1.Show();
        }



    }
}
