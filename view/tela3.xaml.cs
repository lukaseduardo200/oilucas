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
    /// Interação lógica para tela3.xam
    /// </summary>
    /// 
    public partial class tela3 : UserControl
    {
        static double[] dinheiro = new double[13];
        public static List<funcionario> listafuncionario = new List<funcionario>();
        MainWindow main = (MainWindow)Application.Current.MainWindow;

        public tela3()
        { 
            InitializeComponent();
            
        }
        public static void RemoverElemento()
        {
            
        }

        private void removerelemento1(object sender, RoutedEventArgs e)
        {

            string remover = "";
            remover = RemoverElemento2.Text;

           

            Empresa_XEntities empresa_XEntities = new Empresa_XEntities();
            passagem passagem = new passagem();


            //var teste = empresa_XEntities.passagem.SqlQuery("  delete from passagem where id= remover"); // fazer pergunta sobre sql


            var teste2 = empresa_XEntities.passagem.SqlQuery($"select * from passagem where nome ='{remover}'").FirstOrDefault<passagem>();
            empresa_XEntities.passagem.Remove(teste2);

            empresa_XEntities.SaveChanges();
            empresa_XEntities.Dispose();

            //if (int.TryParse(RemoverElemento2.Text, out remove))
            //{
            //    if ( remove <= main.listafuncionario.Count && main.listafuncionario.Count > 0 )
            //    {


            //        main.listafuncionario.Remove(main.listafuncionario[remove-1]);

            //        MessageBox.Show("funcionario removido");

            //    }



            //for (int i = 0; i < main.listafuncionario.Count; i++)
            //{
            //    //if (RemoverElemento2.Text.Equals(main.listafuncionario[i].Nome1))
            //    //{
            //    //    int indice = i;
            //    //    main.listafuncionario.Remove(main.listafuncionario[i]);
            //    //    MessageBox.Show("funcionario removido");
            //    //}
            //}



            //for (int i = 0; i < main.listafuncionario.Count; i++)

            //{
            //    if (posicao.Text.Equals(main.listafuncionario[i].Nome1))
            //    {
            //        int indice = i;

            //        Nome1.Text = main.listafuncionario[indice].Nome1;
            //        Passagem1.Text = main.listafuncionario[indice].Passagem1.ToString();
            //        int[] notas = CalcularAsNotas(main.listafuncionario[indice].Passagem1);






            //        dinheiro1.Text = "Numero de nota de 200: " + notas[0].ToString();
            //        dinheiro2.Text = "Numero de nota de 100: " + notas[1].ToString();
            //        dinheiro3.Text = "Numero de nota de 50: " + notas[2].ToString();
            //        dinheiro4.Text = "Numero de nota de 20: " + notas[3].ToString();
            //        dinheiro5.Text = "Numero de nota de 10: " + notas[4].ToString();
            //        dinheiro6.Text = "Numero de nota de 5: " + notas[5].ToString();
            //        dinheiro7.Text = "Numero de nota de 2: " + notas[6].ToString();
            //        dinheiro8.Text = "moeda de nota de 1: " + notas[7].ToString();
            //        dinheiro9.Text = "moeda de 0,50: " + notas[8].ToString();
            //        dinheiro10.Text = "moeda de 0,25: " + notas[9].ToString();
            //        dinheiro11.Text = "moeda de 0,10: " + notas[10].ToString();
            //        dinheiro12.Text = "moeda de 0,05: " + notas[11].ToString();
            //        dinheiro13.Text = "moeda de 0,01: " + notas[12].ToString();
        }
                }





            }
        
    


