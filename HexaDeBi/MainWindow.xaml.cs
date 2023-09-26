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

namespace HexaDeBi
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            string TextInput = InputText.Text;

            foreach (char c in TextInput)
                Console.WriteLine(Convert.ToString(c, 2).PadLeft(8, '0'));
            Console.ReadLine();

            binaryText.Text = "Binary: " + Console.ReadLine();
        }
    }
}
