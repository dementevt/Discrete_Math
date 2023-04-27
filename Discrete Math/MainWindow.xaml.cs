using System;
using System.IO;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_LogicOperations_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow navWin = new NavigationWindow();
            navWin.Content = new LogicOperationsPage();
            navWin.Show();

            // Скрываем главное окно
            Window window = Window.GetWindow(sender as DependencyObject);
            window.Close();

        }

        private void Button_Combinatorica_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow navWin = new NavigationWindow();
            navWin.Content = new combinatorica();
            navWin.Show();


            // Скрываем главное окно
            Window window = Window.GetWindow(sender as DependencyObject);
            window.Close();
        }

        private void Button_Grapg_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow navWin = new();
            navWin.Content = new graph();
            navWin.Show();

            // Скрываем главное окно
            Window window = Window.GetWindow(sender as DependencyObject);
            window.Close();
        }

        private void Button_Algoritm_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow navWin = new();
            navWin.Content = new algoritm();
            navWin.Show();

            // Скрываем главное окно
            Window window = Window.GetWindow(sender as DependencyObject);
            window.Close();
        }

        private void Button_Struckt_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow navWin = new();
            navWin.Content = new struckt();
            navWin.Show();

            // Скрываем главное окно
            Window window = Window.GetWindow(sender as DependencyObject);
            window.Close();
        }

        //Кнопка для вывода результатов тестов
        private string oldContents = "";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string filePath = "Z:\\Documents\\thirdCourse\\Discrete Math\\Discrete Math\\correct_answers.txt";
            string fileContents = File.ReadAllText(filePath);
            if (fileContents != oldContents) // сравнение с предыдущим содержимым
            {
                resultTextBlock.Text = fileContents;
                oldContents = fileContents; // сохранение нового содержимого
            }
        }



    }

}

