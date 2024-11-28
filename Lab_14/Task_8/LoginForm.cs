using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            errorLabel.Visible = false;
            StyleComponents();
        }

        private void StyleComponents()
        {
            loginButton.BackColor = Color.MediumSeaGreen;
            loginButton.ForeColor = Color.White;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.FlatAppearance.BorderSize = 0;
            RoundButtonEdges(loginButton, 15);

            registerButton.BackColor = Color.Transparent;
            registerButton.ForeColor = Color.MediumSeaGreen;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.FlatAppearance.BorderSize = 0;
            RoundButtonEdges(registerButton, 15);

            usernameTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.BorderStyle = BorderStyle.None;

            usernamePanel.BackColor = Color.LightGray;
            passwordPanel.BackColor = Color.LightGray;
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            if (ValidateCredentials(username, password))
            {
                ProfileForm profileForm = new ProfileForm(username);
                profileForm.Show();
                this.Hide();
            }
            else
            {
                ShowErrorMessage("Невірний логін\nабо пароль");
            }
        }

        private bool ValidateCredentials(string username, string password)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\OneDrive\Изображения\Lab__12\Lab__12\Lab__12\SocialNetwork.mdf;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void ShowErrorMessage(string message)
        {
            errorLabel.Text = message;
            errorLabel.Visible = true;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
