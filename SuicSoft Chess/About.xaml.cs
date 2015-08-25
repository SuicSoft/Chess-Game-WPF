using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace SuicSoft_Chess
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            var box = Microsoft.VisualBasic.Interaction.InputBox("Enter Your Name","Input from user to continue");
            if (box.Contains("ann") | box.Contains("Ann") | box.Contains("ANN") | box.Contains("aNN") | box.Contains("vanderloo") | box.Contains("Vanderloo") | box.Contains("VANDERLOO") | box.Contains("vANDERLOO") | box.Contains("kyle"))
            {
                MessageBox.Show("Hi ,Teacher. Here is some information about your pc. Your pc has " + Environment.ProcessorCount + " CPU Cores. Your .NET is " + Environment.Version + " .That is some info about your pc.");
            Process.Start("https://github.com/ButchersBoy/MaterialDesignInXamlToolkit");
            }
            else { MessageBox.Show("You do not permission to view the controls. Your PC May Be Infected or slow, to fix download some malware. 9 viruses, 2 Rootkits , 1 Keylogger, 11 trojan downloaders, 3 spyware.  YOUR PC IS NOT SAFE","Windows antimalware pro plus for free crack."); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
