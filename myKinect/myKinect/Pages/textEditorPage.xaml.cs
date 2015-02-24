using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for textEditorPage.xaml
    /// </summary>
    public partial class textEditorPage : UserControl
    {

        public System.Media.SoundPlayer player = new System.Media.SoundPlayer("button-select.wav");

        public textEditorPage()
        {
            InitializeComponent();
            textGrid.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
            textGrid.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            LoadText();
            
        }

        public async void LoadText()
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {
                using (StreamReader sr = new StreamReader(mydocpath + @"\MyText.txt"))
                {
                    String line = await sr.ReadToEndAsync();
                    text.Text = line;
                }
            }
            catch (Exception ex)
            {
                text.Text = "";
            }
        }
        private void q_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "Q";
        }

        private void w_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "W";
        }

        private void e_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "E";
        }

        private void r_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "R";
        }

        private void t_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "T";
        }

        private void y_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "Y";
        }

        private void u_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "U";
        }

        private void i_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "I";
        }

        private void o_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "O";
        }

        private void p_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "P";
        }

        private void a_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "A";
        }

        private void s_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "S";
        }

        private void d_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "D";
        }

        private void f_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "F";
        }

        private void g_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "G";
        }

        private void h_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "H";
        }

        private void j_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "J";
        }

        private void k_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "K";
        }

        private void l_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "L";
        }

        private void z_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "Z";
        }

        private void x_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "X";
        }

        private void c_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "C";
        }

        private void v_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "V";
        }

        private void b_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "B";
        }

        private void n_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "N";
        }

        private void m_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "M";
        }

        private void backspace_Click(object sender, RoutedEventArgs e)
        {
            player.Play();
            initialPage ini = new initialPage();
            textGrid.Children.Clear();
            textGrid.Children.Add(ini);
        }

        private async void save_Click(object sender, RoutedEventArgs e)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb = new StringBuilder();

            sb.Append(text.Text);
            sb.AppendLine();
            sb.AppendLine();

            using (StreamWriter outfile = new StreamWriter(mydocpath + @"\MyText.txt", true))
            {
                await outfile.WriteAsync(sb.ToString());
            }
        }
    }
}
