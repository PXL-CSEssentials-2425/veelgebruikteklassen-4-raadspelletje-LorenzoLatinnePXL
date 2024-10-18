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
using Microsoft.VisualBasic;

namespace Raadspelletjes
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

        private void startButton(object sender, RoutedEventArgs e)
        {
            int inputUser;
            int tries = 0;
            Random rnd = new Random();
            int winningNumber = rnd.Next(0, 101);
            bool isValidInput = true;
            bool hasWon = false;


            while (!hasWon)
            {
                do
                {
                    isValidInput = int.TryParse(Interaction.InputBox("Geef een getal tussen 0 en 100: ", "Raadspel", "0"), out inputUser);
                }
                while (!isValidInput);


                if (inputUser > winningNumber)
                {
                    MessageBox.Show("Raad lager", "Raadspel", MessageBoxButton.OK);
                    tries++;
                }
                else if (inputUser < winningNumber)
                {
                    MessageBox.Show("Raad hoger", "Raadspel", MessageBoxButton.OK);
                    tries++;
                }
                else
                {
                    tries++;
                    MessageBox.Show($"Proficiat! U heeft het getal geraden in {tries} beurten");
                    hasWon = true;
                }
            }
        }

        private void sluitenButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
