using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaEstoque
{
    public partial class CashierOrder : UserControl
    {

        SqlConnection 
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emanu\Documents\inventario.mdf;Integrated Security=True;Connect Timeout=30");

        public CashierOrder()
        {
            InitializeComponent();
            displayAllAvaibleProducts();
            displayAllCategories();
        }

        public void displayAllAvaibleProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.allAvaibleProducts();

            dataGridView1.DataSource = listData;
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

        public void displayAllCategories()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectCategories = "SELECT * FROM categories";

                    using (SqlCommand cmd = new SqlCommand(selectCategories, connect)) 
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader()) 
                        {
                            cashierOrder_category.Items.Clear();

                            while(reader.Read())
                            {
                                string Item = reader.GetString(1);
                                cashierOrder_category.Items.Add(Item);
                            }
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Conexão com banco de dados falhou!" + ex, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }

            }

        }

        private void cashierOrder_category_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
