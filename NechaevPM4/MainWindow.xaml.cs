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

namespace NechaevPM4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Name.Text.Length < 3 || Name.Text.Length > 30)
            {
                Name.Background = Brushes.Red;
            }
           

        }

        private void FirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
                if (FirstName.Text.Length < 2 || FirstName.Text.Length > 35) 
                {
                FirstName.Background = Brushes.Red;
                }
                
            

        }

        private void Old_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (Old.Text.Length > 2)
            {
                FirstName.Background = Brushes.Red;
            }



        }


        private void Birthday_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
  }

