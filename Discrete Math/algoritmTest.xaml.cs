using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для algoritmTest.xaml
    /// </summary>
    public partial class algoritmTest : Page
    {
        public algoritmTest()
        {
            InitializeComponent();
        }

        private void Button_Click_GoToMain(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close(); // Закрытие текущего окна (Page)
        }

        private void FinishTestButton_Click(object sender, RoutedEventArgs e)
        {
            int correctAnswersCount = 0;

            // Проверяем ответы на первый вопрос
            if (trueRadioButton.IsChecked == true)
            {
                correctAnswersCount++;
            }

            // Проверяем ответы на второй вопрос
            if (trueRadioButton2.IsChecked == true)
            {
                correctAnswersCount++;
            }

            // Проверяем ответы на третий вопрос
            if (trueRadioButton3.IsChecked == true)
            {
                correctAnswersCount++;
            }

            // Проверяем ответы на четвертый вопрос
            if (trueRadioButton4.IsChecked == true)
            {
                correctAnswersCount++;
            }

            // Проверяем ответы на пятый вопрос
            if (trueRadioButton5.IsChecked == true)
            {
                correctAnswersCount++;
            }

            // Проверяем ответы на шестой вопрос   
            if (trueRadioButton6.IsChecked == true)
            {
                correctAnswersCount++;
            }


            if (correctAnswersCount >= 3)
            {
                // Записываем число правильных ответов в файл
                string path = "Z:\\Documents\\thirdCourse\\Discrete Math\\Discrete Math\\correct_answers.txt";
                try
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Оценка по алгоритмам: " + correctAnswersCount + "\n");

                        // вывод результата в TextBlock
                        resultTextBlock.Text = "Количество правильных ответов: " + correctAnswersCount;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при записи файла: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Тест не пройден, решите занова");
            }

        }
    }
}
