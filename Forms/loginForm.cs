using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class LoginForm : Form
    {
        private readonly string connectionString = "Data Source=96.37.36.204;Initial Catalog=SportsData;Persist Security Info=True;User ID=AppAccess;Password=password123;TrustServerCertificate=True";

        public LoginForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            InitializePasswordTextBox();
            InitializeUsernameTextBox();
        }

        private void InitializePasswordTextBox()
        {
            // Initial placeholder setup
            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.PasswordChar = '\0'; // No password char initially

            txtPassword.Enter += (sender, e) =>
            {
                // Clear the placeholder text when the control is focused
                if (txtPassword.Text == "Password")
                {
                    txtPassword.Text = "";
                    txtPassword.ForeColor = Color.Black;
                    txtPassword.PasswordChar = '*'; // Set the password char when user starts typing
                }
            };

            txtPassword.Leave += (sender, e) =>
            {
                // Restore the placeholder text if no password was entered
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    txtPassword.Text = "Password";
                    txtPassword.ForeColor = Color.Gray;
                    txtPassword.PasswordChar = '\0'; // Remove password char when showing placeholder
                }
            };

            txtPassword.TextChanged += (sender, e) =>
            {
                // Ensure the password char is used for any text entered by the user
                if (!string.IsNullOrEmpty(txtPassword.Text) && txtPassword.Text != "Password")
                {
                    txtPassword.ForeColor = Color.Black;
                    txtPassword.PasswordChar = '*';
                }
            };
        }

        private void InitializeUsernameTextBox()
        {
            // Initial placeholder setup
            txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.Gray;

            txtUsername.Enter += (sender, e) =>
            {
                // Clear the placeholder text when the control is focused
                if (txtUsername.Text == "Username")
                {
                    txtUsername.Text = "";
                    txtUsername.ForeColor = Color.Black;
                }
            };

            txtUsername.Leave += (sender, e) =>
            {
                // Restore the placeholder text if no username was entered
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    txtUsername.Text = "Username";
                    txtUsername.ForeColor = Color.Gray;
                }
            };
        }


        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            // Hash the password
            var hashedPassword = HashPassword(password);

            // Attempt to store username and hashed password in the Users table
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand("INSERT INTO Users (Username, Password) VALUES (@Username, @Password)", connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", hashedPassword);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully!");

                    // Clear the username and password fields after successful account creation
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var hashedPassword = HashPassword(password);

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand("SELECT Password FROM Users WHERE Username = @Username", connection);
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var storedPassword = reader["Password"].ToString();
                            if (hashedPassword == storedPassword)
                            {
                                MessageBox.Show("Login successful!");

                                // Set DialogResult to OK to signal success
                                this.DialogResult = DialogResult.OK;

                                // Close the LoginForm
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Login failed: Incorrect username or password.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Login failed: Incorrect username or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

    }
}
