using System;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class EditEmailForm : Form
    {
        private string username;

        // Ініціалізація форми
        public EditEmailForm(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadCurrentEmail(); // Завантаження поточного email
        }

        // Завантаження email користувача
        private void LoadCurrentEmail()
        {
            using (SqlConnection conn = DataAccess.GetConnection())
            {
                conn.Open();
                string query = "SELECT Email FROM UserData WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            emailTextBox.Text = reader["Email"].ToString();
                        }
                    }
                }
            }
        }

        // Перевірка унікальності email
        private bool IsEmailTaken(string email)
        {
            using (SqlConnection conn = DataAccess.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM UserData WHERE Email = @Email AND Username <> @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Username", username);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Збереження нового email
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string newEmail = emailTextBox.Text.Trim();

            // Валідація email
            if (!Regex.IsMatch(newEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Невірний формат email.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка на зайнятість email
            if (IsEmailTaken(newEmail))
            {
                MessageBox.Show("Цей email вже використовується іншим користувачем.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = DataAccess.GetConnection())
            {
                conn.Open();
                string query = "UPDATE UserData SET Email = @Email WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", newEmail);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Email успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
