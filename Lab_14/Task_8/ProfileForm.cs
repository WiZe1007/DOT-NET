using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class ProfileForm : Form
    {
        private string username;

        public ProfileForm(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadUserData();
            StyleComponents();
        }

        private void LoadUserData()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\OneDrive\Изображения\Lab__12\Lab__12\Lab__12\SocialNetwork.mdf;Integrated Security=True";
            string query = "SELECT Email, Phone FROM Users WHERE Username = @Username";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nameLabel.Text = username;
                    emailLabel.Text = reader["Email"].ToString();
                    phoneLabel.Text = reader["Phone"].ToString();
                }
            }
        }

        private void StyleComponents()
        {
            RoundButtonEdges(editNameButton, 15);
            RoundButtonEdges(editEmailButton, 15);
            RoundButtonEdges(editPhoneButton, 15);
            RoundButtonEdges(editPasswordButton, 15);
            RoundButtonEdges(sendMessageButton, 15);
            RoundButtonEdges(receiveMessageButton, 15);
            RoundButtonEdges(logoutButton, 15);

            sendMessageButton.BackColor = Color.MediumSeaGreen;
            sendMessageButton.ForeColor = Color.White;
            sendMessageButton.FlatStyle = FlatStyle.Flat;
            sendMessageButton.FlatAppearance.BorderSize = 0;

            Button[] buttons = { editNameButton, editEmailButton, editPhoneButton, editPasswordButton, receiveMessageButton, logoutButton };
            foreach (Button btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }
        }

        private void RoundButtonEdges(Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            button.Region = new Region(path);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

        private void EditNameButton_Click(object sender, EventArgs e)
        {
            EditNameForm editNameForm = new EditNameForm(username);
            if (editNameForm.ShowDialog() == DialogResult.OK)
            {
                username = editNameForm.NewUsername;
                LoadUserData();
            }
        }

        private void EditEmailButton_Click(object sender, EventArgs e)
        {
            new EditEmailForm(username).ShowDialog();
            LoadUserData();
        }

        private void EditPhoneButton_Click(object sender, EventArgs e)
        {
            new EditPhoneForm(username).ShowDialog();
            LoadUserData();
        }

        private void EditPasswordButton_Click(object sender, EventArgs e)
        {
            new EditPasswordForm(username).ShowDialog();
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            new MessageSendForm(username).ShowDialog();
        }

        private void ReceiveMessageButton_Click(object sender, EventArgs e)
        {
            new MessageReceiveForm(username).ShowDialog();
        }
    }
}
