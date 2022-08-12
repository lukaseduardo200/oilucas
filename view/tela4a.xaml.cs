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

namespace WpfApp3.view
{
    /// <summary>
    /// Interação lógica para tela4a.xam
    /// </summary>
    public partial class tela4a : UserControl
    {
        MainWindow main = (MainWindow)Application.Current.MainWindow;
        static double[] dinheiro = new double[13];
        public static List<funcionario> listafuncionario = new List<funcionario>();
        public tela4a()
        {
            InitializeComponent();
        }
        //public static void CalcularASoma()
        //{

        //    dinheiro[0] = 200;
        //    dinheiro[1] = 100;
        //    dinheiro[2] = 50;
        //    dinheiro[3] = 20;
        //    dinheiro[4] = 10;
        //    dinheiro[5] = 5;
        //    dinheiro[6] = 2;
        //    dinheiro[7] = 1;
        //    dinheiro[8] = 0.50;
        //    dinheiro[9] = 0.25;
        //    dinheiro[10] = 0.10;
        //    dinheiro[11] = 0.5;
        //    dinheiro[12] = 0.1;

        //    int[] totalnotas = new int[13];
        //    totalnotas[0] = 0;
        //    totalnotas[1] = 0;
        //    totalnotas[2] = 0;
        //    totalnotas[3] = 0;
        //    totalnotas[4] = 0;
        //    totalnotas[5] = 0;
        //    totalnotas[6] = 0;
        //    totalnotas[7] = 0;
        //    totalnotas[8] = 0;
        //    totalnotas[9] = 0;
        //    totalnotas[10] = 0;
        //    totalnotas[11] = 0;
        //    totalnotas[12] = 0;

        //    foreach (funcionario fun in listafuncionario)
        //    {
        //        int[] notasFun = CalcularAsNotas(fun.Passagem1);



        //        for (int i = 0; i < totalnotas.Length; i++)
        //        {

        //            totalnotas[i] = totalnotas[i] + notasFun[i];






        //        }
        //    }

        //    for (int j = 0; j < totalnotas.Length; j++)
        //    {
        //        Console.WriteLine("{0} nota(s) de {1}", totalnotas[j], dinheiro[j]);
                      
        //    }

        //}

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

        private void resultado1(object sender, RoutedEventArgs e)
        {
            int[] totalnotas = new int[13];
            totalnotas[0] = 0;
            totalnotas[1] = 0;
            totalnotas[2] = 0;
            totalnotas[3] = 0;
            totalnotas[4] = 0;
            totalnotas[5] = 0;
            totalnotas[6] = 0;
            totalnotas[7] = 0;
            totalnotas[8] = 0;
            totalnotas[9] = 0;
            totalnotas[10] = 0;
            totalnotas[11] = 0;
            totalnotas[12] = 0;

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

            Empresa_XEntities empresa_XEntities = new Empresa_XEntities();
            passagem passagem = new passagem();


            var Teste = empresa_XEntities.passagem.SqlQuery($"Select * from passagem where nome=passagemfun").FirstOrDefault<passagem>();
            int[] notas = CalcularAsNotas(Teste.passagemfun);



            foreach (funcionario fun in main.listafuncionario)
            {
             





                for (int i = 0; i < totalnotas.Length; i++)
                {

                    totalnotas[i] = totalnotas[i] + notas[i];


                  



                }


                resultado0.Text = "Numero de nota de 200: " + totalnotas[0].ToString();



                resultado2.Text = "Numero de nota de 100: " + totalnotas[1].ToString();
                resultado3.Text = "Numero de nota de 50: " + totalnotas[2].ToString();
                resultado4.Text = "Numero de nota de 20: " + totalnotas[3].ToString();
                resultado5.Text = "Numero de nota de 10: " + totalnotas[4].ToString();
                resultado6.Text = "Numero de nota de 5: " + totalnotas[5].ToString();
                resultado7.Text = "moeda de nota de 1: " + totalnotas[6].ToString();
                resultado8.Text = "moeda de 0,50: " + totalnotas[7].ToString();
                resultado9.Text = "moeda de 0,25: " + totalnotas[8].ToString();
                resultado10.Text = "moeda de 0,15: " + totalnotas[9].ToString();
                resultado11.Text = "moeda de 0,10: " + totalnotas[10].ToString();
                resultado12.Text = "moeda de 0,5: " + totalnotas[11].ToString();
                resultado13.Text = "moeda de 0,1: " + totalnotas[12].ToString();




            }

      

        } 
    }
}


