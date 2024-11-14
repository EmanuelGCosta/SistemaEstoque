using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemaEstoque
{
    internal class AddProductsData
    {
        public int ID { get; set; } // 0
        public string ProdID { get; set; } // 1
        public string Nome { get; set; } // 2
        public string Categoria { get; set; } // 3
        public string Preco { get; set; } // 4
        public string Estoque { get; set; } // 5
        public string ImagePath { get; set; } // 6
        public string Status { get; set; } // 7
        public string Data { get; set; } // 8

        public List<AddProductsData> AllProductsData()
        {
            List<AddProductsData> listData = new List<AddProductsData>();

            using (SqlConnection connect
                = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emanu\Documents\inventario.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();

                string selectData = "SELECT * FROM products";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        AddProductsData apData = new AddProductsData();
                        apData.ID = (int)reader["id"];
                        apData.ProdID = reader["prod_id"].ToString();
                        apData.Nome = reader["prod_name"].ToString();
                        apData.Categoria = reader["category"].ToString();
                        apData.Preco = reader["price"].ToString();
                        apData.Estoque = reader["stock"].ToString();
                        apData.ImagePath = reader["image_path"].ToString();
                        apData.Status = reader["status"].ToString();
                        apData.Data = reader["date_insert"].ToString();


                        listData.Add(apData);
                    }

                }
            }

            return listData;

        }

        public List<AddProductsData> allAvaibleProducts()
        {
            List<AddProductsData> listData = new List<AddProductsData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emanu\Documents\inventario.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();

                string selectData = "SELECT * FROM products WHERE status = @status";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@status", "Disponível");
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        AddProductsData apData = new AddProductsData();
                        apData.ID = (int)reader["id"];
                        apData.ProdID = reader["prod_id"].ToString();
                        apData.Nome = reader["prod_name"].ToString();
                        apData.Categoria = reader["category"].ToString();
                        apData.Preco = reader["price"].ToString();
                        apData.Estoque = reader["stock"].ToString();
                        apData.ImagePath = reader["image_path"].ToString();
                        apData.Status = reader["status"].ToString();
                        apData.Data = reader["date_insert"].ToString();


                        listData.Add(apData);
                    }

                }
            }

            return listData;
        }
    }
}