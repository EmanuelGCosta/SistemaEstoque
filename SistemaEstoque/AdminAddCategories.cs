using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaEstoque
{
    public partial class AdminAddCategories : UserControl
    {
        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emanu\Documents\inventario.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminAddCategories()
        {
            InitializeComponent();
            displayCategoriesData(); 
        }

        public void displayCategoriesData()
        {
            CategoriesData cData = new CategoriesData();
            List<CategoriesData> listData = cData.AllCategoriesData();

            dataGridView1.DataSource = listData;
        }

        private void addCategory_addBtn_Click(object sender, EventArgs e)
        {
            if (addCategory_category.Text == "")
            {
                MessageBox.Show("Campo em branco", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string checkCat = "SELECT * FROM categories WHERE category = @cat";

                    using (SqlCommand cmd = new SqlCommand(checkCat, connect)) 
                    { 
                        cmd.Parameters.AddWithValue("@cat", addCategory_category.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Categoria: " + addCategory_category.Text.Trim() + " já existe!", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO categories (category, date) VALUES (@cat, @date)";

                            using (SqlCommand insertD =  new SqlCommand(insertData, connect))
                            {
                                insertD.Parameters.AddWithValue("@cat", addCategory_category.Text.Trim());
                                
                                DateTime today = DateTime.Today;  

                                insertD.Parameters.AddWithValue("@date", today); 

                                insertD.ExecuteNonQuery();
                                displayCategoriesData();

                                MessageBox.Show("Categoria adicionada com sucesso!", "Mensagem de êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Conexão com banco de dados falhou: " + ex, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
