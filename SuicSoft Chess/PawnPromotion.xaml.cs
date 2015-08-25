using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SuicSoft_Chess
{
    /// <summary>
    /// Interaction logic for PawnPromotion.xaml
    /// </summary>
    public partial class PawnPromotion : MahApps.Metro.Controls.MetroWindow
    {
        public PawnPromotion()
        {
            InitializeComponent();
           
        }
        public enum Piece 
        {
            Cancel = 0,
            Queen = 1,
            Castle = 2,
            Bishop = 3,
            Horse = 4

        }
        public Piece P = Piece.Cancel;

        private void Queen_Click(object sender, RoutedEventArgs e)
        {
            P = Piece.Queen;
            Close();
        }

        private void Castle_Click(object sender, RoutedEventArgs e)
        {
            P = Piece.Castle;
            Close();
        }

        private void Bishop_Click(object sender, RoutedEventArgs e)
        {
            P = Piece.Bishop;
            Close();
        }

        private void Horse_Click(object sender, RoutedEventArgs e)
        {
            P = Piece.Horse;
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void CustomWindow2_Closed(object sender, EventArgs e)
        {
           
        }

       
    }
}
