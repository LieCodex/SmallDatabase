using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Data.SqlClient;


namespace SmallDatabase
{

    public partial class Form1 : Form
    {
        private static string connectionString = "Server= LIECODEX\\SQLEXPRESS;" +
            "Database = Student_system;" +
            "Trusted_Connection = True;" +
            "TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<(string, string, string, string, string, string, string, string, string)> data = LoadEverything();
            string search_term = this.textBox1.Text;
            int index = data.FindIndex(item => item.Item2.ToLower() == search_term.ToLower());

            if (index < 0)
            {
                MessageBox.Show("Student does not exist");
                return;
            }
            this.Hide();
            Form2 form2 = new Form2(search_term, index);
            form2.Show();

        }


        public static void Delete(int id)
        {
            string query = "DELETE Students WHERE student_id = @student_id";

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@student_id", id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student record updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given StudentId.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}`");

            }
        }

        public static void SaveData(int id, string first_name, string last_name, string middle_name, int age, string gender, DateTime date_of_birth, string contact_number, string email)
        {
            string query = "UPDATE Students SET first_name = @first_name, last_name = @last_name, middle_name = @middle_name," +
                " age = @age, gender = @gender, date_of_birth = @date_of_birth, contact_number = @contact_number," +
                " email = @email WHERE student_id = @student_id";

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@first_name", first_name);
                        command.Parameters.AddWithValue("@last_name", last_name);
                        command.Parameters.AddWithValue("@middle_name", middle_name);
                        command.Parameters.AddWithValue("@age", age);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@date_of_birth", date_of_birth);
                        command.Parameters.AddWithValue("@contact_number", contact_number);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@student_id", id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student record updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given StudentId.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}`");

            }
        }

        public static void SaveNewData(string first_name, string last_name, string middle_name, int age, string gender, DateTime date_of_birth, string contact_number, string email)
        {
            string query = "INSERT INTO Students(first_name,last_name, middle_name, age, gender, date_of_birth, contact_number, email) VALUES" +
                "(@first_name,@last_name,@middle_name," +
                "@age, @gender, @date_of_birth,@contact_number,@email)";

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@first_name", first_name);
                        command.Parameters.AddWithValue("@last_name", last_name);
                        command.Parameters.AddWithValue("@middle_name", middle_name);
                        command.Parameters.AddWithValue("@age", age);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@date_of_birth", date_of_birth);
                        command.Parameters.AddWithValue("@contact_number", contact_number);
                        command.Parameters.AddWithValue("@email", email);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student record updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given StudentId.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}`");

            }
            Form1 form = new Form1();
            form.LoadData();
        }


        public static List<(string, string, string, string, string, string, string, string, string)> LoadEverything()
        {
            string query = "SELECT * FROM Students";

            List<(string, string, string, string, string, string, string, string, string)> results = new List<(string, string, string, string, string, string, string, string, string)>();

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            results.Add((reader.GetInt32(0).ToString(), reader.GetString(1).ToString(), reader.GetString(2).ToString(),
                                        reader.GetString(3).ToString(), reader.GetInt32(4).ToString(), reader.GetString(5).ToString(),
                                        reader.GetDateTime(6).Date.ToString("yyyy-MM-dd"), reader.GetString(7).ToString(), reader.GetString(8).ToString()));
                        }
                        reader.Close();
                    }
                }

                return results;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}`");
                return null;
            }
        }
        private void LoadData()
        {

            string query = "SELECT first_name, last_name FROM Students";

            AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            autoCompleteData.Add(reader.GetString(0).ToString());
                        }
                        reader.Close();
                    }
                }

                textBox1.AutoCompleteCustomSource = autoCompleteData;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}2");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ensure no required fields are empty or null
            if (string.IsNullOrEmpty(FirstNameTB.Text) ||
                string.IsNullOrEmpty(LastNameTB.Text) ||
                string.IsNullOrEmpty(MiddleNameTB.Text) ||
                string.IsNullOrEmpty(genderTB.Text) ||
                string.IsNullOrEmpty(contact_numberTB.Text) ||
                string.IsNullOrEmpty(emailTB.Text) ||
                string.IsNullOrEmpty(ageTB.Text) ||
                string.IsNullOrEmpty(date_of_birthTB.Text))
            {
                MessageBox.Show("Please fill up all fields");
                return;
            }
            else
            {
                SaveNewData(FirstNameTB.Text, LastNameTB.Text, MiddleNameTB.Text, Int32.Parse(ageTB.Text), genderTB.Text, DateTime.Parse(date_of_birthTB.Text).Date, contact_numberTB.Text, emailTB.Text);
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.Show();
        }
    }
}
