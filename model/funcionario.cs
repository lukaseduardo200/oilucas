using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WpfApp3;
namespace model

{

    public class funcionario
    {
        Conexao conexao = new Conexao();
       SqlCommand cmd = new SqlCommand();

        public string mensagem;


        public string Nome1 { get; set; }

        public double Passagem1 { get; set; }

        public funcionario(double passagem1, string nome1)
        {
            cmd.CommandText = "insert into ex (nome1, passagem1) values (@nome1, @passagem1)";
            cmd.Parameters.AddWithValue("@nome1",nome1);
            cmd.Parameters.AddWithValue("@passagem!", passagem1);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "cadastrada  com sucesso";
            }
            catch (Exception)
            {
                this.mensagem = "erro ao se conectar com o banco de dados";

            }
        }
   
        //public string ToString()
        //{
        //    return "O funcionario " + Nome1 + " recebe " + Passagem1.ToString("C") + " de passagem";
        //}

        //public string ToString(int valor)
        //{
        //    return Nome1 + " recebe " + Passagem1.ToString("C") + " " + valor.ToString();
        //}


    }




}
