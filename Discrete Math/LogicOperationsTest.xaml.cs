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
    /// Логика взаимодействия для LogicOperationsTest.xaml
    /// </summary>
    public partial class LogicOperationsTest : Page
    {
        public LogicOperationsTest()
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
            if (falseRadioButton.IsChecked == true)
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
            if (falseRadioButton5.IsChecked == true)
            {
                correctAnswersCount++;
            }

            // Проверяем ответы на шестой вопрос
            if (falseRadioButton6.IsChecked == true)
            {
                correctAnswersCount++;
            }


            if (correctAnswersCount >= 3)
            {
                MessageBox.Show("Тест пройден!");

                //Изменяем цвет правильных ответов
                RadioButton[] trueRadioButtons = { falseRadioButton, trueRadioButton2, trueRadioButton3, trueRadioButton4, falseRadioButton5, falseRadioButton6 };
                foreach (RadioButton radioButton in trueRadioButtons)
                {
                    if (radioButton.IsChecked == true)
                    {
                        radioButton.Foreground = Brushes.Green;
                    }
                }

                // Записываем число правильных ответов в файл
                string path = "Z:\\Documents\\thirdCourse\\Discrete Math\\Discrete Math\\correct_answers.txt";
                try
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Оценка по логическим операциям: " + correctAnswersCount + "\n");

                        // вывод результата в TextBlock
                        resultTextBlock.Text = "Количество правильных ответов: " + correctAnswersCount;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при записи файла: " + ex.Message);
                }

                // Неправильный ответ, меняем цвет фона RadioButton'ов с неправильными ответами

                // Создание массива StackPanel
                StackPanel[] stackPanels = new StackPanel[] { stackPanel, stackPanel2, stackPanel3, stackPanel4, stackPanel5, stackPanel6 };

                // Перебор каждого StackPanel
                foreach (StackPanel sp in stackPanels)
                {
                    // Перебор каждого дочернего элемента StackPanel
                    foreach (object radioButton in sp.Children)
                    {
                        if (radioButton is RadioButton)
                        {
                            if ((bool)(radioButton as RadioButton).IsChecked == false && radioButton != falseRadioButton &&
                                radioButton != trueRadioButton2 && radioButton != trueRadioButton3 &&
                                radioButton != trueRadioButton4 && radioButton != falseRadioButton5 && radioButton != falseRadioButton6)
                            {
                                (radioButton as RadioButton).Background = Brushes.Red;
                            }
                            else
                            {
                                (radioButton as RadioButton).Background = Brushes.Transparent;
                            }
                        }
                    }
                }


            }
            else
            {
                MessageBox.Show("Тест не пройден, решите занова");
            }
            
        }

    }
}
