using System;
using System.Data.SqlClient;
using System.IO;
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
            using (SqlConnection conn = DataAccess.GetConnection())
            {
                conn.Open();
                string query = "SELECT MessageID, SenderUsername, Theme, Text, Date FROM Messages WHERE RecipientUsername = @RecipientUsername";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RecipientUsername", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            messagesListBox.Items.Clear();
                            while (reader.Read())
                            {
                                int messageId = reader.GetInt32(0);
                                string theme = reader.GetString(2);
                                messagesListBox.Items.Add(new MessageListItem { MessageID = messageId, Theme = theme });
                            }
                        }
                        else
                        {
                            messagesListBox.Items.Add("No messages.");
                        }
                    }
                }
            }
        }

        private void MessagesListBox_DoubleClick(object sender, EventArgs e)
        {
            if (messagesListBox.SelectedItem != null && messagesListBox.SelectedItem.ToString() != "No messages.")
            {
                MessageListItem selectedItem = messagesListBox.SelectedItem as MessageListItem;
                if (selectedItem != null)
                {
                    int messageId = selectedItem.MessageID;
                    // Отримати деталі повідомлення з бази даних
                    using (SqlConnection conn = DataAccess.GetConnection())
                    {
                        conn.Open();
                        string query = "SELECT SenderUsername, Theme, Text, Date FROM Messages WHERE MessageID = @MessageID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MessageID", messageId);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string messageDetails = $"From: {reader["SenderUsername"]}\n" +
                                                            $"Theme: {reader["Theme"]}\n" +
                                                            $"Text: {reader["Text"]}\n" +
                                                            $"Date: {reader["Date"]}";
                                    // Відкрити форму деталей повідомлення
                                    MessageDetailForm detailForm = new MessageDetailForm(messageDetails);
                                    detailForm.ShowDialog();
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    class MessageListItem
    {
        public int MessageID { get; set; }
        public string Theme { get; set; }

        public override string ToString()
        {
            return Theme;
        }
    }
}
