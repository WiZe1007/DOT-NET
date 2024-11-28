using System;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class EditNameForm : Form
    {
        private string username;
        public string NewUsername { get; private set; }

        // Ініціалізація форми
        public EditNameForm(string username)
        {
            InitializeComponent();
            this.username = username;
            nameTextBox.Text = username; // Заповнення поточного імені
        }

        // Збереження нового імені
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string newUsername = nameTextBox.Text.Trim();

            // Валідація нового імені
            if (!Regex.IsMatch(newUsername, @"^[a-zA-Z0-9]{1,15}$"))
            {
                MessageBox.Show("Невірне ім'я. Використовуйте тільки літери та цифри (макс. 15 символів).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка на збіг з поточним ім'ям
            if (username == newUsername)
            {
                MessageBox.Show("Нове ім'я співпадає з поточним.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            // Перевірка на зайнятість імені
            if (IsUsernameTaken(newUsername))
            {
                MessageBox.Show("Ім'я вже зайняте. Оберіть інше.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Оновлення імені у базі даних
            UpdateUsernameInDatabase(username, newUsername);

            MessageBox.Show("Ім'я успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.NewUsername = newUsername;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Оновлення імені у файлі
        private void UpdateUsernameInFile(string filePath, string oldUsername, string newUsername)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts[0] == oldUsername)
                    {
                        parts[0] = newUsername;
                        lines[i] = string.Join(",", parts);
                    }
                }
                File.WriteAllLines(filePath, lines);
            }
        }

        // Перевірка, чи зайняте ім'я
        private bool IsUsernameTaken(string newUsername)
        {
            using (SqlConnection conn = DataAccess.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", newUsername);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void UpdateUsernameInDatabase(string oldUsername, string newUsername)
        {
            using (SqlConnection conn = DataAccess.GetConnection())
            {
                conn.Open();

                // Оновлення в таблиці Users
                string updateUsersQuery = "UPDATE Users SET Username = @NewUsername WHERE Username = @OldUsername";
                using (SqlCommand cmd = new SqlCommand(updateUsersQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                    cmd.Parameters.AddWithValue("@OldUsername", oldUsername);
                    cmd.ExecuteNonQuery();
                }

                // Оновлення в таблиці UserData
                string updateUserDataQuery = "UPDATE UserData SET Username = @NewUsername WHERE Username = @OldUsername";
                using (SqlCommand cmd = new SqlCommand(updateUserDataQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                    cmd.Parameters.AddWithValue("@OldUsername", oldUsername);
                    cmd.ExecuteNonQuery();
                }

                // Оновлення в таблиці Messages (відправник)
                string updateMessagesSenderQuery = "UPDATE Messages SET SenderUsername = @NewUsername WHERE SenderUsername = @OldUsername";
                using (SqlCommand cmd = new SqlCommand(updateMessagesSenderQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                    cmd.Parameters.AddWithValue("@OldUsername", oldUsername);
                    cmd.ExecuteNonQuery();
                }

                // Оновлення в таблиці Messages (отримувач)
                string updateMessagesRecipientQuery = "UPDATE Messages SET RecipientUsername = @NewUsername WHERE RecipientUsername = @OldUsername";
                using (SqlCommand cmd = new SqlCommand(updateMessagesRecipientQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                    cmd.Parameters.AddWithValue("@OldUsername", oldUsername);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
