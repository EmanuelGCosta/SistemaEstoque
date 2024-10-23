using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaEstoque
{
    public partial class RegisterForm : Form
    {
        SqlConnection 
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emanu\Documents\inventario.mdf;Integrated Security=True;Connect Timeout=30");    
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (register_username.Text == "" || register_password.Text == "" || register_cPassword.Text == "")
            {
                MessageBox.Show("Por favor complete todos os campos vazios", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string checkUsername = "SELECT * FROM users WHERE username = @usern";
                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(register_username.Text.Trim() +
                                    " Já existe!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length < 8)
                            {
                                MessageBox.Show("Senha inválida, é preciso no mínimo 8 caracteres", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Trim() != register_cPassword.Text.Trim())
                            {
                                MessageBox.Show("Senhas não são iguais ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                string insertData = "INSERT INTO users (username, password, role, status, date)" +
                                    "VALUES (@usern, @pass, @role, @status, @date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", "Caixa");
                                    insertD.Parameters.AddWithValue("@status", "Aprovado");

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();

                                    MessageBox.Show("Registrado com sucesso!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();

                                    this.Hide();
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Conexão falhou: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }

        private void login_label_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }
    }
}
