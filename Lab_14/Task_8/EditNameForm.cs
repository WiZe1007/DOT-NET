using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class EditNameForm : Form
    {
        private string username;
        public string NewUsername { get; private set; }

        public EditNameForm(string username)
        {
            InitializeComponent();
            this.username = username;
            nameTextBox.Text = username;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string newUsername = nameTextBox.Text.Trim();

            if (!Regex.IsMatch(newUsername, @"^[a-zA-Z0-9]{1,15}$"))
            {
                MessageBox.Show("Невірне ім'я. Використовуйте тільки літери та цифри (макс. 15 символів).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username == newUsername)
            {
                MessageBox.Show("Нове ім'я співпадає з поточним.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            if (IsUsernameTaken(newUsername))
            {
                MessageBox.Show("Ім'я вже зайняте. Оберіть інше.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdateUsernameInDatabase(username, newUsername);
        }

        private void UpdateUsernameInDatabase(string oldUsername, string newUsername)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\OneDrive\Изображения\Lab__12\Lab__12\Lab__12\SocialNetwork.mdf;Integrated Security=True";
            string query = "UPDATE Users SET Username = @NewUsername WHERE Username = @OldUsername";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                cmd.Parameters.AddWithValue("@OldUsername", oldUsername);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Ім'я успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.NewUsername = newUsername;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не вдалося оновити ім'я.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsUsernameTaken(string newUsername)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\OneDrive\Изображения\Lab__12\Lab__12\Lab__12\SocialNetwork.mdf;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @NewUsername";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
