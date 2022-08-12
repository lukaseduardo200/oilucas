using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using model;
using System.Diagnostics;
using System.Data.SqlClient;

namespace WpfApp3.view


{
    /// <summary>
    /// Interação lógica para tela1.xam
    /// </summary>
    public partial class tela1 : UserControl
    {
        static double[] dinheiro = new double[13];

        MainWindow main = (MainWindow)Application.Current.MainWindow;
        public tela1()
        {
            InitializeComponent();
            
        }


       

        private void NovoFuncionario(object sender, RoutedEventArgs e)
        {
            if (!NomeFun.Text.Equals("") || PassagemFun.Text.Equals("")  )
            {
                //funcionario novo = new funcionario();
                //double helper;

                //novo.Nome1 = NomeFun.Text;
                //double.TryParse(PassagemFun.Text, out helper);

                //novo.Passagem1 = helper;

                //main.listafuncionario.Add(novo);

                Empresa_XEntities empresa_XEntities = new Empresa_XEntities();
                passagem passagem = new passagem();

                double helper;

                
                passagem.nome = NomeFun.Text;
                passagem.passagemfun= float.Parse(PassagemFun.Text.Replace(".",","));
              

                 


                empresa_XEntities.passagem.Add(passagem);
                empresa_XEntities.SaveChanges();
                empresa_XEntities.Dispose();

                NomeFun.Text = "";
                PassagemFun.Text = "";

                
            }

        }
    }
}
        