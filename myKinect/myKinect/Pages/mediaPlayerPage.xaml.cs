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
    /// Interaction logic for mediaPlayerPage.xaml
    /// </summary>
    public partial class mediaPlayerPage : UserControl
    {
        public mediaPlayerPage()
        {
            InitializeComponent();
            mediaGrid.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
            mediaGrid.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            media.Height = System.Windows.SystemParameters.PrimaryScreenHeight-20;
            media.Width = System.Windows.SystemParameters.PrimaryScreenWidth-20;
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            media.Play();
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {
            media.Pause();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            initialPage ini = new initialPage();
            mediaGrid.Children.Clear();
            mediaGrid.Children.Add(ini);
        }

        private void fastforward_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 10);
            media.Position += ts;
        }

        private void rewind_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 10);
            media.Position -= ts;
        }

        
    }
}
