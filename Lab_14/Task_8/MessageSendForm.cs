using System;
using System.Data.SqlClient;
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

        private void SendButton_Click(object sender, EventArgs e)
        {
            string recipientUsername = toTextBox.Text.Trim();
            string theme = themeTextBox.Text.Trim();
            string text = messageTextBox.Text.Trim();

            if (string.IsNullOrEmpty(recipientUsername) || string.IsNullOrEmpty(theme) || string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!UserExists(recipientUsername))
            {
                MessageBox.Show("Отримувач не знайдений.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int senderID = GetUserID(senderUsername);
            int recipientID = GetUserID(recipientUsername);

            if (senderID == -1 || recipientID == -1)
            {
                MessageBox.Show("Помилка при отриманні даних користувача.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\OneDrive\Изображения\Lab__12\Lab__12\Lab__12\SocialNetwork.mdf;Integrated Security=True";
            string query = "INSERT INTO Messages (SenderUserID, RecipientUserID, Theme, Text, Date) VALUES (@SenderUserID, @RecipientUserID, @Theme, @Text, @Date)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SenderUserID", senderID);
                cmd.Parameters.AddWithValue("@RecipientUserID", recipientID);
                cmd.Parameters.AddWithValue("@Theme", theme);
                cmd.Parameters.AddWithValue("@Text", text);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Повідомлення відправлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool UserExists(string username)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\OneDrive\Изображения\Lab__12\Lab__12\Lab__12\SocialNetwork.mdf;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private int GetUserID(string username)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\OneDrive\Изображения\Lab__12\Lab__12\Lab__12\SocialNetwork.mdf;Integrated Security=True";
            string query = "SELECT UserID FROM Users WHERE Username = @Username";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return (int)result;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
