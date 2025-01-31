using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SistemaEstoque
{
    internal class OrdersData
    {
        SqlConnection connect
             = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emanu\Documents\inventario.mdf;Integrated Security=True;Connect Timeout=30");

        public int ID { set; get; }
        public string CID { set; get; }
        //public string PID { set; get; }
        public string PNome { set; get; }
        public string Categoria { set; get; }
        public string PrecoOrig { set; get; }
        public string QTD { set; get; }
        public string PrecoTotal { set; get; }
        //public string Date { set; get; }


        public List<OrdersData> allOrdersData()
        {
            List<OrdersData> listData = new List<OrdersData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    int custID = 0;

                    string selectCustData = "SELECT MAX(customer_id) FROM orders";

                    using (SqlCommand cmd = new SqlCommand(selectCustData, connect))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int temp = Convert.ToInt32(result);

                            if (temp == 0)
                            {
                                custID = 1;
                            }
                            else
                            {
                                custID = temp;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error ID");
                        }
                    }

                    string selectData = "SELECT * FROM orders WHERE customer_id = @cID";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cID", custID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            OrdersData oData = new OrdersData();

                            oData.ID = (int)reader["id"];
                            oData.CID = reader["customer_id"].ToString();
                            //oData.PID = reader["prod_id"].ToString();
                            oData.PNome = reader["prod_name"].ToString();
                            oData.Categoria = reader["category"].ToString();
                            oData.PrecoOrig = reader["orig_price"].ToString();
                            oData.QTD = reader["qty"].ToString();
                            oData.PrecoTotal = reader["total_price"].ToString();
                            //oData.Date = reader["order_date"].ToString();

                            listData.Add(oData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Conexão com banco de dados falhou: " + ex);
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