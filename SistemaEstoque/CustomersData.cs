using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SistemaEstoque
{
    internal class CustomersData
    {
        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emanu\Documents\inventario.mdf;Integrated Security=True;Connect Timeout=30");

        public string ClienteID { set; get; }
        public string PrecoTotal { set; get; }
        public string Valor { set; get; }
        public string Troco { set; get; }
        public string Data { set; get; }

        public List<CustomersData> allCustomers()
        {
            List<CustomersData> listData = new List<CustomersData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM customers";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CustomersData cData = new CustomersData();

                            cData.ClienteID = reader["customer_id"].ToString();
                            cData.PrecoTotal = reader["total_price"].ToString();
                            cData.Valor = reader["amount"].ToString();
                            cData.Troco = reader["change"].ToString();
                            cData.Data = reader["order_date"].ToString();

                            listData.Add(cData);

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Falha na conexão com banco de dados" + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }

        public List<CustomersData> allTodayCustomers()
        {
            List<CustomersData> listData = new List<CustomersData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    DateTime today = DateTime.Today;

                    string selectData = "SELECT * FROM customers WHERE order_date = @date";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@date", today);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CustomersData cData = new CustomersData();

                            cData.ClienteID = reader["customer_id"].ToString();
                            cData.PrecoTotal = reader["total_price"].ToString();
                            cData.Valor = reader["amount"].ToString();
                            cData.Troco = reader["change"].ToString();
                            cData.Data = reader["order_date"].ToString();

                            listData.Add(cData);

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Falha na conexão com banco de dados" + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }
    }
}
