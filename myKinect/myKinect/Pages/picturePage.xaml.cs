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
    /// Interaction logic for picturePage.xaml
    /// </summary>
    public partial class picturePage : UserControl
    {
        public picturePage()
        {
            InitializeComponent();
            pictureGrid.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
            pictureGrid.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            
        }

        int n = 1;
        
        public void incrementImage() 
        {
            picFrame.Source = new BitmapImage(new Uri("picture" + n + ".bmp", UriKind.RelativeOrAbsolute));
            n += 1;
            if (n > 6) { n = 1; }
        }

        private void previous_Click(object sender, RoutedEventArgs e)
        {
            incrementImage();
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            incrementImage();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            initialPage ini = new initialPage();
            pictureGrid.Children.Clear();
            pictureGrid.Children.Add(ini);
        }
    }
}
