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

namespace WPF_DZ_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string currentText = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private int currentCharIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
            UpdateInstruction();
        }
        private void UpdateInstruction()
        {
            if (currentCharIndex < currentText.Length)
            {
                InstructionText.Text = $"Натисніть: {currentText[currentCharIndex]}";
            }
            else
            {
                InstructionText.Text = "Вітаємо! Ви завершили тренування.";
            }
        }

        private void Key_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null && clickedButton.Content.ToString() == currentText[currentCharIndex].ToString())
            {
                currentCharIndex++;
                UpdateInstruction();
            }
        }
    }
}
