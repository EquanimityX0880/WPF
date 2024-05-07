using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

        // What if I have more than one Button? Does each button use this function?
        // Why don't the buttons move with the scale of the window, but the Message Box does?
        // the Content property of HelloButton updates to OK only after the messagebox is closed.
        //  
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (HelloButton.IsChecked == true) { MessageBox.Show("Hello."); }
            else if (GoodbyeButton.IsChecked == true) { MessageBox.Show("Goodbye."); }
            // HelloButton.Content = "OK";

        }
    }
}