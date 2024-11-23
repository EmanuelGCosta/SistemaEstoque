using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SistemaEstoque
{
    public partial class AdminAddProducts : UserControl
    {

        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emanu\Documents\inventario.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminAddProducts()
        {
            InitializeComponent();
            displayCategories();
            displayAllProducts();
        }

        public void refresData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refresData);
                return;
            }
            addProducts_category.Items.Clear();
            displayCategories();
            displayAllProducts();
        }

        public void displayAllProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.AllProductsData();

            dataGridView1.DataSource = listData;

        }

        public bool checkEmptyFIelds()
        {
            if (addProducts_prodID.Text == "" || addProducts_prodName.Text == "" || addProducts_category.SelectedIndex == -1
                || addProducts_prodPrice.Text == "" || addProducts_prodStock.Text == "" || addProducts_imageView.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayCategories()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM categories";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                addProducts_category.Items.Add(reader["category"].ToString());

                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha na conexão com banco de dados: " + ex, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


        private void addProducts_addBtn_Click(object sender, EventArgs e)
        {

            if (checkEmptyFIelds())
            {
                MessageBox.Show("Campos em branco", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM products WHERE prod_id = @prodID";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Produto com ID: " + addProducts_prodID.Text.Trim() + " já existe!", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                                string relativePath = Path.Combine("Products_Directory", addProducts_prodID.Text.Trim() + ".jpg");
                                string path = Path.Combine(baseDirectory, relativePath);

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addProducts_imageView.ImageLocation, path, true);

                                string insertData = "INSERT INTO products " +
                                    "(prod_id, prod_name, category, price, stock, image_path, status, date_insert) " +
                                    "VALUES (@prodID, @prodName, @cat, @price, @stock, @path, @status, @date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                                    insertD.Parameters.AddWithValue("@prodName", addProducts_prodName.Text.Trim());
                                    insertD.Parameters.AddWithValue("@cat", addProducts_category.SelectedItem);
                                    insertD.Parameters.AddWithValue("@price", addProducts_prodPrice.Text.Trim());
                                    insertD.Parameters.AddWithValue("@stock", addProducts_prodStock.Text.Trim());
                                    insertD.Parameters.AddWithValue("@path", path);

                                    string status = "";
                                    if (Convert.ToInt32(addProducts_prodStock.Text) > 0)
                                    {
                                        status = "Disponível";
                                    }
                                    else
                                    {
                                        status = "Não disponível";
                                    }
                                    insertD.Parameters.AddWithValue("@status", status);

                                    DateTime date = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", date);

                                    insertD.ExecuteNonQuery();
                                    clearFields();
                                    displayAllProducts();
                                    MessageBox.Show("Adicionado com sucesso! ", "Mensagem de êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Conexão com o banco de dados falhou: " + ex, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();

                    }
                }
            }

        }

        public bool checkConnection()
        {
            if (connect.State != ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void clearFields()
        {
            addProducts_prodID.Text = "";
            addProducts_prodName.Text = "";
            addProducts_category.SelectedIndex = -1;
            addProducts_prodPrice.Text = "";
            addProducts_prodStock.Text = "";
            //addProducts_prodStatus.SelectedIndex = -1;
            addProducts_imageView.Image = null;
        }

        private void addProducts_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addProducts_imageView.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {

            }

        }

        private void buaddProducts_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;

                addProducts_prodID.Text = row.Cells[1].Value.ToString();
                addProducts_prodName.Text = row.Cells[2].Value.ToString();
                addProducts_category.Text = row.Cells[3].Value.ToString();
                addProducts_prodPrice.Text = row.Cells[4].Value.ToString();
                addProducts_prodStock.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                try
                {
                    if (imagePath != null)
                    {
                        addProducts_imageView.Image = Image.FromFile(imagePath);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de imagem: " + ex, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                }


                //addProducts_prodStatus.Text = row.Cells[7].Value.ToString();
            }
        }

        private void buttoaddProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (checkEmptyFIelds())
            {
                MessageBox.Show("Campos em branco", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja atualizar o produto com o ID: " + addProducts_prodID.Text.Trim() + "?", "Mensagem de confirmação"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE products SET prod_id = @prodID, prod_name = @prodName" +
                                ", category = @cat, price = @price, stock = @stock, status = @status WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@id", getID);
                                updateD.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodName", addProducts_prodName.Text.Trim());
                                updateD.Parameters.AddWithValue("@cat", addProducts_category.SelectedItem);
                                updateD.Parameters.AddWithValue("@price", addProducts_prodPrice.Text.Trim());
                                updateD.Parameters.AddWithValue("@stock", addProducts_prodStock.Text.Trim());

                                string status = "";
                                if (Convert.ToInt32(addProducts_prodStock.Text) > 0)
                                {
                                    status = "Disponível";
                                }
                                else
                                {
                                    status = "Não disponível";
                                }
                                updateD.Parameters.AddWithValue("@status", status);


                                updateD.ExecuteNonQuery();
                                clearFields();
                                displayAllProducts();
                                MessageBox.Show("Atualizado com sucesso! ", "Mensagem de êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Conexão com o banco de dados falhou: " + ex, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }

        }

        private void addProducts_deleteBtn_Click(object sender, EventArgs e)
        {
            if (checkEmptyFIelds())
            {
                MessageBox.Show("Campos em branco", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja DELETAR o produto com o ID: " + addProducts_prodID.Text.Trim() + "?", "Mensagem de confirmação"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string deleteData = "DELETE FROM products WHERE id = @id";

                            using (SqlCommand deleteD = new SqlCommand(deleteData, connect))
                            {
                                deleteD.Parameters.AddWithValue("@id", getID);

                                deleteD.ExecuteNonQuery();
                                clearFields();
                                displayAllProducts();
                                MessageBox.Show("Deletado com sucesso! ", "Mensagem de êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Conexão com o banco de dados falhou: " + ex, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}

