using System.Net.Http;
using System.Windows;

namespace WpfApplication1
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

        private async void btnGetHtml_Click(object sender, RoutedEventArgs e)
        {
            var url = textUrl.Text;

            using (var client = new HttpClient())
            {
                try
                {
                    btnGetHtml.IsEnabled = false;
                    textHtml.Text = await client.GetStringAsync(url);
                }
                catch
                {
                    textHtml.Text = "Oops! Something went wrong.";
                }
                finally
                {
                    btnGetHtml.IsEnabled = true;
                }
            }
        }
    }
}
