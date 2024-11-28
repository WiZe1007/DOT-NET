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
            // Налаштування кнопки входу
            loginButton.BackColor = Color.MediumSeaGreen;
            loginButton.ForeColor = Color.White;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.FlatAppearance.BorderSize = 0;
            RoundButtonEdges(loginButton, 15); // Закруглення кутів кнопки

            // Налаштування кнопки реєстрації
            registerButton.BackColor = Color.Transparent;
            registerButton.ForeColor = Color.MediumSeaGreen;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.FlatAppearance.BorderSize = 0;
            RoundButtonEdges(registerButton, 15); // Закруглення кутів кнопки

            // Видаляємо рамки текстових полів та додаємо підкреслення
            usernameTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.BorderStyle = BorderStyle.None;

            // Налаштування панелей під текстовими полями
            usernamePanel.BackColor = Color.LightGray;
            passwordPanel.BackColor = Color.LightGray;
        }

        private void RoundButtonEdges(Button button, int radius)
        {
            // Графічний шлях для форми кнопки
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures(); // Закриваємо всі фігури
            button.Region = new Region(path); // Задаємо регіон кнопки
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim(); // Отримуємо ім'я користувача
            string password = passwordTextBox.Text; // Отримуємо пароль

            if (ValidateCredentials(username, password)) // Перевіряємо дані
            {
                // Переходимо до форми профілю
                ProfileForm profileForm = new ProfileForm(username);
                profileForm.Show();
                this.Hide();
            }
            else
            {
                // Повідомлення про помилку
                ShowErrorMessage("Невірний логін\nабо пароль");
            }
        }

        private bool ValidateCredentials(string username, string password)
        {
            using (SqlConnection conn = DataAccess.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void ShowErrorMessage(string message)
        {
            errorLabel.Text = message; // Встановлюємо текст помилки
            errorLabel.Visible = true; // Робимо мітку видимою
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Переходимо до форми реєстрації
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
