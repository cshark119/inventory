using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace InventoryManagement
{
    public partial class RegisterForm : Form
    {
        private SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\franc\source\repos\InventoryManagement\InventoryManagement\inventory.mdf;Integrated Security=True;Connect Timeout=30");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (register_username.Text == "" || register_password.Text == "" || register_cPassword.Text == "")
            {
                MessageBox.Show("Please fill up all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (register_password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (register_password.Text.Trim() != register_cPassword.Text.Trim())
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\franc\source\repos\InventoryManagement\InventoryManagement\inventory.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    connect.Open();

                    // Check if username already exists
                    string checkUsername = "SELECT COUNT(*) FROM users WHERE username = @usern";
                    using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                        int userExists = (int)cmd.ExecuteScalar();

                        if (userExists > 0)
                        {
                            MessageBox.Show("Username is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new user
                    string insertData = "INSERT INTO users (username, password, role, status, date) VALUES (@usern, @pass, @role, @status, @date)";
                    using (SqlCommand insertCmd = new SqlCommand(insertData, connect))
                    {
                        insertCmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@role", "Admin");
                        insertCmd.Parameters.AddWithValue("@status", "Approval");
                        insertCmd.Parameters.AddWithValue("@date", DateTime.Today);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form1 loginForm = new Form1();
                        loginForm.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    return true; // Connection successfully opened
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Connection failed
                }
            }
            return connect.State == ConnectionState.Open; // Ensure it's actually open
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void register_password_TextChanged(object sender, EventArgs e)
        {
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }
    }
}
