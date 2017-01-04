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



namespace Biblioteka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Katalog Katalog = new Katalog();
        public MainWindow()
        {
            InitializeComponent();
         
            
        }
        private void DodajKsiazke(object sender, RoutedEventArgs e)
        {
            NowaKsiazka Nowa = new NowaKsiazka();
            this.myFrame.NavigationService.Navigate(Nowa);

           
        }

        private void myFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
