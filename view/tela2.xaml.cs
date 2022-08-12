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

namespace WpfApp3.view
{
    /// <summary>
    /// Interação lógica para tela2.xam
    /// </summary>
    public partial class tela2 : UserControl
    {
        MainWindow main = (MainWindow)Application.Current.MainWindow;
        static double[] dinheiro = new double[13];
        public static List<funcionario> listafuncionario = new List<funcionario>();

        public tela2()
        {
            InitializeComponent();

        }
        ////public  void PesquisarElemento()
        ////{
        ////    dinheiro[0] = 200;
        ////    dinheiro[1] = 100;
        ////    dinheiro[2] = 50;
        ////    dinheiro[3] = 20;
        ////    dinheiro[4] = 10;
        ////    dinheiro[5] = 5;
        ////    dinheiro[6] = 2;
        ////    dinheiro[7] = 1;
        ////    dinheiro[8] = 0.50;
        ////    dinheiro[9] = 0.25;
        ////    dinheiro[10] = 0.10;
        ////    dinheiro[11] = 0.5;
        ////    dinheiro[12] = 0.1;
        ////    while (true)
        ////    {
        ////        Console.WriteLine("escolha uma altenativa de 1 a {0} \n Digite exit para sair", listafuncionario.Count);
        ////        string altenativa;
        ////        altenativa = posicao.Text;
        ////        int indice;

        ////        if (altenativa.Equals("exit"))
        ////        {
        ////            break;
        ////        }


        ////        if (int.TryParse(altenativa, out indice))
        ////        {
        ////            if (indice > main.listafuncionario.Count || indice <= 0)
        ////            {
        ////                Console.WriteLine("valor invalido");
        ////            }
        ////            else
        ////            {  Nome1.Text = main.listafuncionario[indice].Nome1;
        ////                Passagem1.Text= main.listafuncionario [indice].Passagem1.ToString();



        ////                int[] notas = CalcularAsNotas(main.listafuncionario[indice - 1].Passagem1);


        ////                for (int j = 0; j < notas.Length; j++)
        ////                {

        ////                    dinheiro1.Text = main.listafuncionario [notas[j]].ToString();


        ////                }

        ////            }


        ////        }








        ////    }
        ////}
        public static int[] CalcularAsNotas(double Passagem1)
        {
            int[] notas = new int[13];
            //funcionario novo = new funcionario();


            notas[0] = 0;
            notas[1] = 0;
            notas[2] = 0;
            notas[3] = 0;
            notas[4] = 0;
            notas[5] = 0;
            notas[6] = 0;
            notas[7] = 0;
            notas[8] = 0;
            notas[9] = 0;
            notas[10] = 0;
            notas[11] = 0;
            notas[12] = 0;





            double valorpassagem;
            valorpassagem = Passagem1;





            for (int i = 0; i < dinheiro.Length; i++)
            {
                var aux = dinheiro[i];
                notas[i] = (int)(valorpassagem / aux);
                valorpassagem = valorpassagem % dinheiro[i];









            }





            return notas;
        }

        private void Pesquisafuncionario(object sender, RoutedEventArgs e)
        {
            Empresa_XEntities empresa_XEntities = new Empresa_XEntities();
            passagem passagem = new passagem();
            dinheiro[0] = 200;
            dinheiro[1] = 100;
            dinheiro[2] = 50;
            dinheiro[3] = 20;
            dinheiro[4] = 10;
            dinheiro[5] = 5;
            dinheiro[6] = 2;
            dinheiro[7] = 1;
            dinheiro[8] = 0.50;
            dinheiro[9] = 0.25;
            dinheiro[10] = 0.10;
            dinheiro[11] = 0.05;
            dinheiro[12] = 0.01;
       string nome="";
            nome = posicao.Text;



                //if (int.TryParse(posicao.Text, out indice))
                //{

            //    if (indice > listafuncionario.Count && indice <= 0)
            //    {


            //        MessageBox.Show("valor invalido ");








            //    }
            //    else
            //    {
            //        Nome1.Text = main.listafuncionario[indice - 1].Nome1;
            //        Passagem1.Text = main.listafuncionario[indice - 1].Passagem1.ToString();
            //        int[] notas = CalcularAsNotas(main.listafuncionario[indice - 1].Passagem1);






            //    dinheiro1.Text = "Numero de nota de 200: " + notas[0].ToString();
            //    dinheiro2.Text = "Numero de nota de 100: " + notas[1].ToString();
            //        dinheiro3.Text = "Numero de nota de 50: " + notas[2].ToString();
            //        dinheiro4.Text = "Numero de nota de 20: " + notas[3].ToString();
            //        dinheiro5.Text = "Numero de nota de 10: " + notas[4].ToString();
            //        dinheiro6.Text = "Numero de nota de 5: " + notas[5].ToString();
            //    dinheiro7.Text = "Numero de nota de 2: " + notas[6].ToString();
            //    dinheiro8.Text = "moeda de nota de 1: " + notas[7].ToString();
            //        dinheiro9.Text = "moeda de 0,50: " + notas[8].ToString();
            //        dinheiro10.Text = "moeda de 0,25: " + notas[9].ToString();
            //        dinheiro11.Text = "moeda de 0,10: " + notas[10].ToString();
            //        dinheiro12.Text = "moeda de 0,05: " + notas[11].ToString();
            //        dinheiro13.Text = "moeda de 0,01: " + notas[12].ToString();
            //    }



            //}

            //if(posicao.Text.Equals(main.listafuncionario[].(Nome1)))

            
                    var Teste = empresa_XEntities.passagem.SqlQuery($"Select * from passagem where nome='{nome}'").FirstOrDefault<passagem>();
                    //Nome1.Text = listafuncionario[1].nome;
                    //Passagem4.Text = main.listafuncionario[indice].
                    int[] notas = CalcularAsNotas(Teste.passagemfun);
                    //passagem.nome = Nome1.Text;
                    //passagem.nome= listafuncionario[indice].nome;
                    //passagem.passagem1.ToString();
                    //passagem.passagem1 = float.Parse(Passagem4.Text);

            Nome1.Text = Teste.nome;
            Passagem4.Text = Teste.passagemfun.ToString();





                    dinheiro1.Text = "Numero de nota de 200: " + notas[0].ToString();
                    dinheiro2.Text = "Numero de nota de 100: " + notas[1].ToString();
                    dinheiro3.Text = "Numero de nota de 50: " + notas[2].ToString();
                    dinheiro4.Text = "Numero de nota de 20: " + notas[3].ToString();
                    dinheiro5.Text = "Numero de nota de 10: " + notas[4].ToString();
                    dinheiro6.Text = "Numero de nota de 5: " + notas[5].ToString();
                    dinheiro7.Text = "Numero de nota de 2: " + notas[6].ToString();
                    dinheiro8.Text = "moeda de nota de 1: " + notas[7].ToString();
                    dinheiro9.Text = "moeda de 0,50: " + notas[8].ToString();
                    dinheiro10.Text = "moeda de 0,25: " + notas[9].ToString();
                    dinheiro11.Text = "moeda de 0,10: " + notas[10].ToString();
                    dinheiro12.Text = "moeda de 0,05: " + notas[11].ToString();
                    dinheiro13.Text = "moeda de 0,01: " + notas[12].ToString();
      
           
        }
    } }
