using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class MessageSendForm : Form
    {
        private string senderUsername;

        public MessageSendForm(string senderUsername)
        {
            InitializeComponent();
            this.senderUsername = senderUsername;
        }

        // Відправка повідомлення
        private void SendButton_Click(object sender, EventArgs e)
        {
            string recipient = toTextBox.Text.Trim();
            string theme = themeTextBox.Text.Trim();
            string text = messageTextBox.Text.Trim();

            // Перевірка заповнення
            if (string.IsNullOrEmpty(recipient) || string.IsNullOrEmpty(theme) || string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка отримувача
            if (!UserExists(recipient))
            {
                MessageBox.Show("Отримувач не знайдений.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = DataAccess.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Messages (SenderUsername, RecipientUsername, Theme, Text, Date) VALUES (@SenderUsername, @RecipientUsername, @Theme, @Text, @Date)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SenderUsername", senderUsername);
                    cmd.Parameters.AddWithValue("@RecipientUsername", recipient);
                    cmd.Parameters.AddWithValue("@Theme", theme);
                    cmd.Parameters.AddWithValue("@Text", text);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Повідомлення відправлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        // Перевірка існування користувача
        private bool UserExists(string username)
        {
            using (SqlConnection conn = DataAccess.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
