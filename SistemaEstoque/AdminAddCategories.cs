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

                            using (SqlCommand insertD = new SqlCommand(insertData, connect))
                            {
                                insertD.Parameters.AddWithValue("@cat", addCategory_category.Text.Trim());

                                DateTime today = DateTime.Today;

                                insertD.Parameters.AddWithValue("@date", today);

                                insertD.ExecuteNonQuery();
                                clearFields();
                                displayCategoriesData();

                                MessageBox.Show("Categoria adicionada com sucesso!", "Mensagem de êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Conexão com banco de dados falhou: " + ex, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

        }

        public void clearFields()
        {
            addCategory_category.Text = "";
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

        private int getID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;

                addCategory_category.Text = row.Cells[1].Value.ToString();
            }
        }

        private void addCategory_updateBtn_Click(object sender, EventArgs e)
        {
            if (addCategory_category.Text == "")
            {
                MessageBox.Show("Campo em branco", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Tem certezaque deseja atualizar a categoria com ID de: " + getID + "?", "Mensagem de confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();


                        string updateData = "UPDATE categories SET category = @cat WHERE id = @id";

                        using (SqlCommand updateD = new SqlCommand(updateData, connect))
                        {
                            updateD.Parameters.AddWithValue("@cat", addCategory_category.Text.Trim());
                            updateD.Parameters.AddWithValue("@id", getID);

                            updateD.ExecuteNonQuery();
                            clearFields();
                            displayCategoriesData();

                            MessageBox.Show("Categoria atualizada com sucesso!", "Mensagem de êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Conexão com banco de dados falhou: " + ex, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void addCategory_removeBtn_Click(object sender, EventArgs e)
        {
            if (addCategory_category.Text == "")
            {
                MessageBox.Show("Campo em branco", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Tem certezaque deseja remover a categoria com ID de: " + getID + "?", "Mensagem de confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();


                        string removeData = "DELETE FROM categories WHERE id = @id";

                        using (SqlCommand deleteD = new SqlCommand(removeData, connect))
                        {
                            deleteD.Parameters.AddWithValue("@cat", addCategory_category.Text.Trim());
                            deleteD.Parameters.AddWithValue("@id", getID);

                            deleteD.ExecuteNonQuery();
                            clearFields();
                            displayCategoriesData();

                            MessageBox.Show("Categoria deletada com sucesso!", "Mensagem de êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Conexão com banco de dados falhou: " + ex, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
