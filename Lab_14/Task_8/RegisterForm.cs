using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            StyleComponents();
            ClearErrorLabels();
        }

        private void StyleComponents()
        {
            // Кнопка реєстрації
            registerButton.BackColor = Color.MediumSeaGreen;
            registerButton.ForeColor = Color.White;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.FlatAppearance.BorderSize = 0;
            RoundButtonEdges(registerButton, 15);

            // Кнопка переходу до логіну
            loginButton.BackColor = Color.Transparent;
            loginButton.ForeColor = Color.MediumSeaGreen;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.FlatAppearance.BorderSize = 0;
            RoundButtonEdges(loginButton, 15);

            // Видалення рамок текстових полів та додавання підкреслення
            nameTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.BorderStyle = BorderStyle.None;
            phoneTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.BorderStyle = BorderStyle.None;
            confirmPasswordTextBox.BorderStyle = BorderStyle.None;

            // Задання кольору для панелей під текстовими полями
            namePanel.BackColor = Color.LightGray;
            emailPanel.BackColor = Color.LightGray;
            phonePanel.BackColor = Color.LightGray;
            passwordPanel.BackColor = Color.LightGray;
            confirmPasswordPanel.BackColor = Color.LightGray;
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

        private void ClearErrorLabels()
        {
            nameErrorLabel.Text = "";
            emailErrorLabel.Text = "";
            phoneErrorLabel.Text = "";
            passwordErrorLabel.Text = "";
            confirmPasswordErrorLabel.Text = "";
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            ClearErrorLabels();

            string userName = nameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string phone = phoneTextBox.Text.Trim();
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            bool isValid = ValidateFields(userName, email, phone, password, confirmPassword);

            if (isValid)
            {
                bool isUnique = true;

                if (IsUsernameTaken(userName))
                {
                    nameErrorLabel.Text = "Ім'я користувача вже зайняте.";
                    isUnique = false;
                }

                if (IsEmailTaken(email))
                {
                    emailErrorLabel.Text = "Електронна пошта вже використовується.";
                    isUnique = false;
                }

                if (IsPhoneTaken(phone))
                {
                    phoneErrorLabel.Text = "Номер телефону вже використовується.";
                    isUnique = false;
                }

                if (!isUnique)
                {
                    return;
                }

                SaveUserData(userName, email, phone, password);
                MessageBox.Show("Реєстрація успішна!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private bool ValidateFields(string userName, string email, string phone, string password, string confirmPassword)
        {
            bool isValid = true;

            if (!Regex.IsMatch(userName, @"^[a-zA-Z0-9]{1,15}$"))
            {
                nameErrorLabel.Text = "Неправильне ім'я. Макс. 15 символів, латиниця та цифри.";
                isValid = false;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                emailErrorLabel.Text = "Невірний формат електронної пошти.";
                isValid = false;
            }

            if (!Regex.IsMatch(phone, @"^\+?\d{10,18}$"))
            {
                phoneErrorLabel.Text = "Номер телефону має містити від 10 до 18 цифр.";
                isValid = false;
            }

            if (!Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*[0-9])(?=.*[!@#$%^&*]).{12,}$"))
            {
                passwordErrorLabel.Text = "Слабкий пароль. Мін. 12 символів, цифри та спеціальні символи.";
                isValid = false;
            }

            if (password != confirmPassword)
            {
                confirmPasswordErrorLabel.Text = "Паролі не співпадають.";
                isValid = false;
            }

            return isValid;
        }

        private bool IsUsernameTaken(string userName)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\OneDrive\Изображения\Lab__12\Lab__12\Lab__12\SocialNetwork.mdf;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", userName);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private bool IsEmailTaken(string email)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\OneDrive\Изображения\Lab__12\Lab__12\Lab__12\SocialNetwork.mdf;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private bool IsPhoneTaken(string phone)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\OneDrive\Изображения\Lab__12\Lab__12\Lab__12\SocialNetwork.mdf;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM Users WHERE Phone = @Phone";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Phone", phone);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void ClearFields()
        {
            nameTextBox.Clear();
            emailTextBox.Clear();
            phoneTextBox.Clear();
            passwordTextBox.Clear();
            confirmPasswordTextBox.Clear();
            ClearErrorLabels();
        }

        private void SaveUserData(string userName, string email, string phone, string password)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nemof\OneDrive\Изображения\Lab__12\Lab__12\Lab__12\SocialNetwork.mdf;Integrated Security=True";
            string query = "INSERT INTO Users (Username, Password, Email, Phone) VALUES (@Username, @Password, @Email, @Phone)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", userName);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
