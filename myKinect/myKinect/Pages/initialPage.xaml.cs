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
    /// Interaction logic for initialPage.xaml
    /// </summary>
    public partial class initialPage : UserControl
    {
        public System.Media.SoundPlayer player = new System.Media.SoundPlayer("button-select.wav");
        public initialPage()
        {
            InitializeComponent();
            initialGrid.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
            initialGrid.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
        }

        private void webBrowserButton_Click(object sender, RoutedEventArgs e)
        {
            player.Play();
            webBrowserPage web = new webBrowserPage();
            initialGrid.Children.Clear();
            initialGrid.Children.Add(web);
        }

        private void KinectTileButton_Click(object sender, RoutedEventArgs e)
        {
            player.Play();
            mediaPlayerPage media = new mediaPlayerPage();
            initialGrid.Children.Clear();
            initialGrid.Children.Add(media);
        }

        private void musicPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            player.Play();
            musicPlayerPage music = new musicPlayerPage();
            initialGrid.Children.Clear();
            initialGrid.Children.Add(music);
        }

        private void KinectTileButton_Click_1(object sender, RoutedEventArgs e)
        {
            player.Play();
            Application.Current.Shutdown();
        }

        private void picturePage_Click(object sender, RoutedEventArgs e)
        {
            player.Play();
            picturePage pic = new picturePage();
            initialGrid.Children.Clear();
            initialGrid.Children.Add(pic);
        }

        private void textEditorButton_Click(object sender, RoutedEventArgs e)
        {
            player.Play();
            textEditorPage tex = new textEditorPage();
            initialGrid.Children.Clear();
            initialGrid.Children.Add(tex);
        }
    }
}
