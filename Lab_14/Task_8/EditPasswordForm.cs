using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class EditPasswordForm : Form
    {
        private string username;

        public EditPasswordForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string currentPassword = currentPasswordTextBox.Text;
            string newPassword = newPasswordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            string errorMessage = ValidateFields(currentPassword, newPassword, confirmPassword);

            if (string.IsNullOrEmpty(errorMessage))
            {
                if (UpdatePasswordInDatabase(username, currentPassword, newPassword))
                {
                    MessageBox.Show("Пароль успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Невірний поточний пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidateFields(string currentPassword, string newPassword, string confirmPassword)
        {
            string error = "";

            if (string.IsNullOrEmpty(currentPassword))
                error += "Введіть поточний пароль.\n";

            if (!Regex.IsMatch(newPassword, @"^(?=.*[a-zA-Z])(?=.*[0-9])(?=.*[!@#$%^&*]).{12,}$"))
                error += "Новий пароль має бути мінімум 12 символів і включати літери, цифри та спеціальні символи.\n";

            if (newPassword != confirmPassword)
                error += "Нові паролі не співпадають.\n";

            return error;
        }

        private bool UpdatePasswordInDatabase(string username, string currentPassword, string newPassword)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\OneDrive\Изображения\Lab__12\Lab__12\Lab__12\SocialNetwork.mdf;Integrated Security=True";
            string query = "UPDATE Users SET Password = @NewPassword WHERE Username = @Username AND Password = @CurrentPassword";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@CurrentPassword", currentPassword);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
