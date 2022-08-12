using model;
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
using WpfApp3.view;



namespace WpfApp3

{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<funcionario> listafuncionario = new List<funcionario>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelecionarMenu(object sender, SelectionChangedEventArgs e)
        {

            int escolha = Menu.SelectedIndex;
            
            if (escolha>=0)
            {
                switch (escolha)
                {
                    case 0: 
                        telas.Children.Clear(); 
                        telas.Children.Add(new tela1());
                      
                        break;


                    case 1:
                        telas.Children.Clear();
                        telas.Children.Add(new tela2());
                        break;

                    case 2:
                        telas.Children.Clear();
                        telas.Children.Add(new tela3());
                        break;

                    case 3:
                        telas.Children.Clear();
                        telas.Children.Add(new tela4a());
                        break;

                    case 4:
                        telas.Children.Clear();
                        telas.Children.Add(new tela5a());
                        break;
                        

                   

                    case 5:
                        System.Windows.Forms.DialogResult reposta = System.Windows.Forms.MessageBox.Show("deseja mesmo sair ? ", "aviso", (System.Windows.Forms.MessageBoxButtons)MessageBoxButton.YesNo);

                        

                        if( reposta==System.Windows.Forms.DialogResult.Yes)
                        {
                            this.Close();
                            break;
                        }
                        break;

                }
            }
            
        }
    }
}
