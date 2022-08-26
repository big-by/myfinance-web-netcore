using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace myfinance_web_netcore.Infra
{
    public class DAL
    {
        private SqlConnection conn;

        private string connectionString;

        public static IConfiguration? Configuration;

        private static DAL? Instance;

        public static DAL GetInstance()
        {
            if (Instance == null) {
                Instance = new();
            }
            return Instance;
        }

        private DAL()
        {
            connectionString = Configuration.GetValue<string>("connectionString");
        }

        public void Conectar()
        {
            conn = new();
            conn.ConnectionString = connectionString;
            conn.Open();

        }

        public void Desconectar()
        {
            conn.CloseAsync();
        }

        public DataTable RetornaDataTable(string sql)
        {
            var dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dataTable);
            
            return dataTable;
        }

        //CRUD
        public void ExecutarComandoSQL(string sql)
        {
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.ExecuteNonQuery();
        }
    }
}