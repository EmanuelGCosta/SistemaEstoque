using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaEstoque
{
    internal class UsersData
    {
        public int Id { get; set; }
        public string Usarname { get; set; }
        public string Senha { get; set; }
        public string Funcao { get; set; }
        public string Status{ get; set; }
        public string Data {  get; set; }

        public List<UsersData> AllUsersData()
        {
            List<UsersData> listData = new List<UsersData>();

            using (SqlConnection connect 
                = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emanu\Documents\inventario.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();

                string selectData = "SELECT * FROM users";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                { 
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read()) 
                    { 
                        UsersData uData = new UsersData();
                        uData.Id = (int)reader["id"];
                        uData.Usarname = reader["username"].ToString();
                        uData.Senha = reader["password"].ToString();
                        uData.Funcao = reader["role"].ToString();
                        uData.Status = reader["status"].ToString();
                        uData.Data = reader["date"].ToString();

                        listData.Add(uData);
                    }

                }
            }

            return listData;
        }
    }
}
