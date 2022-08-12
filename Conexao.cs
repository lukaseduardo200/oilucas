using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WpfApp3
{
    public class Conexao

     
    {
        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-8622E0I\\WINCC;Initial Catalog=funcionarios;Integrated Security=True";
        }

        public SqlConnection conectar()
        {
            if (con.State== System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()

        { if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Close();
            }

        }
    }
}
