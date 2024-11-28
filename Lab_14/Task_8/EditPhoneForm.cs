using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class EditPhoneForm : Form
    {
        private string username;

        public EditPhoneForm(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadCurrentPhone();
        }

        private void LoadCurrentPhone()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\OneDrive\Изображения\Lab__12\Lab__12\Lab__12\SocialNetwork.mdf;Integrated Security=True";
            string query = "SELECT Phone FROM Users WHERE Username = @Username";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();
                phoneTextBox.Text = cmd.ExecuteScalar()?.ToString();
            }
        }

        private bool IsPhoneTaken(string phone)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\OneDrive\Изображения\Lab__12\Lab__12\Lab__12\SocialNetwork.mdf;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM Users WHERE Phone = @Phone AND Username != @Username";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string newPhone = phoneTextBox.Text.Trim();

            if (!Regex.IsMatch(newPhone, @"^\+?\d{10,15}$"))
            {
                MessageBox.Show("Некоректний формат номера телефону.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsPhoneTaken(newPhone))
            {
                MessageBox.Show("Цей номер телефону вже використовується іншим користувачем.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\OneDrive\Изображения\Lab__12\Lab__12\Lab__12\SocialNetwork.mdf;Integrated Security=True";
            string query = "UPDATE Users SET Phone = @Phone WHERE Username = @Username";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Phone", newPhone);
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Номер телефону успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
