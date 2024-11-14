using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SistemaEstoque
{
    public partial class Form1 : Form
    {
        public static string username;
        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emanu\Documents\inventario.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
            this.Text = "login";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(*) FROM users WHERE username = @usern AND password = @pass AND status = @status";


                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", "Ativo");

                        int rowCount = (int)cmd.ExecuteScalar();

                        if (rowCount > 0)
                        {
                            string selectRole = "SELECT role FROM users WHERE username = @usern AND password = @pass";

                            using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                            {
                                getRole.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                                getRole.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                                string userRole = getRole.ExecuteScalar() as string;

                                MessageBox.Show("Logado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();

                                if (userRole == "Admin")
                                {
                                    MainForm mForm = new MainForm();
                                    mForm.Show();
                                }
                                else if (userRole == "Caixa")
                                {
                                    CashierMainForm cForm = new CashierMainForm();
                                    cForm.Show();
                                }


                            }


                        }
                        else
                        {
                            MessageBox.Show("Credenciais inválidas!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Conexão com banco de dados falhou! " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }

            }
        }
        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }


    }
}
