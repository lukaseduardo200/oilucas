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
    /// Interação lógica para tela5a.xam
    /// </summary>
    public partial class tela5a : UserControl
    {
        static double[] dinheiro = new double[13];
        public static List<funcionario> listafuncionario = new List<funcionario>();
        MainWindow main = (MainWindow)Application.Current.MainWindow;
        public tela5a()
        {
            InitializeComponent();
        }

        private void vertodoss(object sender, RoutedEventArgs e)

        {

            //funcionario novo = new funcionario();
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


            //      foreach(funcionario item in main.listafuncionario)
            //{
            //    mostralista.Items.Add( item.Nome1);
            //    mostralista.Items.Add(item.Passagem1);
            //}



            
        }

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

        //foreach (funcionario item in main.listafuncionario)
        // {
        //     Console.WriteLine("\nfuncionario = ");
        //     Console.WriteLine(item.Nome1);
        //     Console.WriteLine("passagem = ");
        //     Console.WriteLine(item.Passagem1);
        //     Console.Write("------------------------------------------------ ");

        // }
    }
}
