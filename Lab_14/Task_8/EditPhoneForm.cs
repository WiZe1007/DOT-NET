using System;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class EditPhoneForm : Form
    {
        private string username;

        // Ініціалізація форми
        public EditPhoneForm(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadCurrentPhone(); // Завантаження поточного номера телефону
        }

        // Завантаження телефону
        private void LoadCurrentPhone()
        {
            using (SqlConnection conn = DataAccess.GetConnection())
            {
                conn.Open();
                string query = "SELECT Phone FROM UserData WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            phoneTextBox.Text = reader["Phone"].ToString();
                        }
                    }
                }
            }
        }

        // Перевірка унік. номера телефону
        private bool IsPhoneTaken(string phone)
        {
            using (SqlConnection conn = DataAccess.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM UserData WHERE Phone = @Phone AND Username <> @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Username", username);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Збереження нового номера
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string newPhone = phoneTextBox.Text.Trim();

            // Перевірка формату номера
            if (!Regex.IsMatch(newPhone, @"^\+?\d{10,15}$"))
            {
                MessageBox.Show("Некоректний формат номера телефону.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка унікальності номера
            if (IsPhoneTaken(newPhone))
            {
                MessageBox.Show("Цей номер телефону вже використовується іншим користувачем.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = DataAccess.GetConnection())
            {
                conn.Open();
                string query = "UPDATE UserData SET Phone = @Phone WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Phone", newPhone);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Номер телефону успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
