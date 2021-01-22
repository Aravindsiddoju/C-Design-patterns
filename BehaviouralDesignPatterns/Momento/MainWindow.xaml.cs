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

namespace Momento
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Create a care taker object that contains the collection.
        CareTaker careTaker = new CareTaker();

        // originator sets the value of the statement.
        Originator originator = new Originator();

        int saveFiles = 0, currentStatement = -1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string text = theStatement.Text;
            originator.Set(text);
            careTaker.AddMomento(originator.StoreInMomento());
            saveFiles++;
            currentStatement++;
            btnUndo.IsEnabled = true;
        }

        private void btnUndo_Click(object sender, RoutedEventArgs e)
        {
            if(currentStatement >= 0)
            {
                currentStatement--;
                string textBox = originator.RestoreFromMomento(careTaker.GetMomento(currentStatement));
                theStatement.Text = textBox;
                btnRedo.IsEnabled = true;
            }
            else
            {
                btnUndo.IsEnabled = false;
            }
        }

        private void btnRedo_Click(object sender, RoutedEventArgs e)
        {
            if((saveFiles-1) > currentStatement)
            {
                currentStatement++;
                string textBoxString = originator.RestoreFromMomento(careTaker.GetMomento(currentStatement));

                theStatement.Text = textBoxString;

                btnUndo.IsEnabled = false;
            }
            else
            {
                btnRedo.IsEnabled = false;
            }
        }
    }
}
