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

namespace Discrete_Math
{
    /// <summary>
    /// Логика взаимодействия для LogicOperationsPage.xaml
    /// </summary>
    public partial class LogicOperationsPage : Page
    {
        public LogicOperationsPage()
        {
            InitializeComponent();
        }

        private void Button_Click_GoToMain(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close(); // Закрытие текущего окна (Page)
        }

        private void Button_Click_GoToTest(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new LogicOperationsTest());
        }
    }
}
