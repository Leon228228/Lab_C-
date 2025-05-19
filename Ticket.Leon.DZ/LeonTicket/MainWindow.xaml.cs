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

namespace LeonTicket
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

        private void logon_Click(object sender, RoutedEventArgs e)
        {
         if (login.Text == "Leon" && password.Password == "121296")
            {
                BuyTicket ticket = new BuyTicket();
                ticket.Show();
                this.Close();
            }

        
        
        }
    }
}