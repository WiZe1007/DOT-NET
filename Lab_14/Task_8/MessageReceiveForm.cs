using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class MessageReceiveForm : Form
    {
        private string username;

        public MessageReceiveForm(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadMessages();
        }

        private void LoadMessages()
        {
            int userID = GetUserID(username);
            if (userID == -1)
            {
                MessageBox.Show("Помилка при отриманні даних користувача.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\OneDrive\Изображения\Lab__12\Lab__12\Lab__12\SocialNetwork.mdf;Integrated Security=True";
            string query = "SELECT MessageID, Theme FROM Messages WHERE RecipientUserID = @RecipientUserID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RecipientUserID", userID);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable messagesTable = new DataTable();
                messagesTable.Load(reader);
                if (messagesTable.Rows.Count > 0)
                {
                    messagesListBox.DisplayMember = "Theme";
                    messagesListBox.ValueMember = "MessageID";
                    messagesListBox.DataSource = messagesTable;
                }
                else
                {
                    messagesListBox.Items.Add("No messages.");
                }
            }
        }

        private void MessagesListBox_DoubleClick(object sender, EventArgs e)
        {
            if (messagesListBox.SelectedItem != null && messagesListBox.SelectedItem.ToString() != "No messages.")
            {
                int messageID = Convert.ToInt32(messagesListBox.SelectedValue);
                ShowMessageDetails(messageID);
            }
        }

        private void ShowMessageDetails(int messageID)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\OneDrive\Изображения\Lab__12\Lab__12\Lab__12\SocialNetwork.mdf;Integrated Security=True";
            string query = @"SELECT m.Theme, m.Text, m.Date, u.Username AS SenderUsername 
                             FROM Messages m 
                             JOIN Users u ON m.SenderUserID = u.UserID 
                             WHERE m.MessageID = @MessageID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MessageID", messageID);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string senderUsername = reader["SenderUsername"].ToString();
                    string theme = reader["Theme"].ToString();
                    string text = reader["Text"].ToString();
                    DateTime date = Convert.ToDateTime(reader["Date"]);

                    MessageDetailForm detailForm = new MessageDetailForm(senderUsername, theme, text, date);
                    detailForm.ShowDialog();
                }
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
