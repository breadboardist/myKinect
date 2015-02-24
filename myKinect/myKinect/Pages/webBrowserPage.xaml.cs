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

namespace myKinect.Pages
{
    /// <summary>
    /// Interaction logic for webBrowserPage.xaml
    /// </summary>
    public partial class webBrowserPage : UserControl
    {
        public webBrowserPage()
        {
            InitializeComponent();
            webGrid.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
            webGrid.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            browser.Source = new Uri("http://www.google.com");
        }

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            initialPage iniPage = new initialPage();
            webGrid.Children.Clear();
            webGrid.Children.Add(iniPage);
        }
    }
}
