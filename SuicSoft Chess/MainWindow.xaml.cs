using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Net.Mail;
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

namespace SuicSoft_Chess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            Debug.WriteLine("Started UI Init @ " + DateTime.Now.Millisecond.ToString());
            InitializeComponent();
            Debug.WriteLine("Ended UI Init @ " + DateTime.Now.Millisecond.ToString());
        }

      

        #region Variables
 private string s = "";
 private Brush clr;

        #endregion
       
        #region ChessMadness(64 times of the same thing)

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
 s = A1.Content.ToString();
                }
                catch (Exception)
                {

                   
                }
               
                A1.Content = "";
                clr = A1.Foreground;
               
            }
            else
            {
                if (s == "♙" & (clr == Brushes.Black)) { var pawnp = new PawnPromotion(); pawnp.ShowDialog(); switch (pawnp.P) { case PawnPromotion.Piece.Queen:s = "♕"; break; case PawnPromotion.Piece.Castle:s = "♖"; break; case PawnPromotion.Piece.Bishop:s = "♗"; break; case PawnPromotion.Piece.Horse:s = "♘"; break; } }
                A1.Content = s;
                A1.Foreground = clr;
                s = "";
            }
            
        }




        private void B1_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
  s = B1.Content.ToString();
                }
                catch (Exception)
                {
                    
                  
                }
              
                B1.Content = "";
                clr = B1.Foreground;
            }
            else
            {
                if (s == "♙" & (clr == Brushes.Black)) { var pawnp = new PawnPromotion(); pawnp.ShowDialog(); switch (pawnp.P) { case PawnPromotion.Piece.Queen:s = "♕"; break; case PawnPromotion.Piece.Castle:s = "♖"; break; case PawnPromotion.Piece.Bishop:s = "♗"; break; case PawnPromotion.Piece.Horse:s = "♘"; break; } }
                B1.Content = s;
                B1.Foreground = clr;
                s = "";
            }
        }

        private void C1_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
 s = C1.Content.ToString();
                }
                catch (Exception)
                {
                    
                    
                }
               
                C1.Content = "";
                clr = C1.Foreground;
            }
               
            else
            {
                if (s == "♙" & (clr == Brushes.Black)) { var pawnp = new PawnPromotion(); pawnp.ShowDialog(); switch (pawnp.P) { case PawnPromotion.Piece.Queen:s = "♕"; break; case PawnPromotion.Piece.Castle:s = "♖"; break; case PawnPromotion.Piece.Bishop:s = "♗"; break; case PawnPromotion.Piece.Horse:s = "♘"; break; } }
                C1.Content = s;
                C1.Foreground = clr;
                s = "";
            }
        }

        private void D1_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
s = D1.Content.ToString();
                }
                catch (Exception)
                {
                    
                
                }
                
                D1.Content = "";
                clr = D1.Foreground;
            }
            else
            {
                if (s == "♙" & (clr == Brushes.Black)) { var pawnp = new PawnPromotion(); pawnp.ShowDialog(); switch (pawnp.P) { case PawnPromotion.Piece.Queen:s = "♕"; break; case PawnPromotion.Piece.Castle:s = "♖"; break; case PawnPromotion.Piece.Bishop:s = "♗"; break; case PawnPromotion.Piece.Horse:s = "♘"; break; } }
                D1.Content = s;
                D1.Foreground = clr;
                s = "";
            }
        }

        private void E1_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
 s = E1.Content.ToString();
                }
                catch (Exception)
                {
                    
                   
                }
               
                E1.Content = "";
                clr = E1.Foreground;
            }
            else
            {
                if (s == "♙" & (clr == Brushes.Black)) { var pawnp = new PawnPromotion(); pawnp.ShowDialog(); switch (pawnp.P) { case PawnPromotion.Piece.Queen:s = "♕"; break; case PawnPromotion.Piece.Castle:s = "♖"; break; case PawnPromotion.Piece.Bishop:s = "♗"; break; case PawnPromotion.Piece.Horse:s = "♘"; break; } }
                E1.Content = s;
                E1.Foreground = clr;
                s = "";
            }
        }

        private void F1_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
                    s = F1.Content.ToString();
                }
                catch (Exception)
                {
                    
                    
                }

                F1.Content = "";
                clr = F1.Foreground;
            }
            else
            {
                if (s == "♙" & (clr == Brushes.Black)) { var pawnp = new PawnPromotion(); pawnp.ShowDialog(); switch (pawnp.P) { case PawnPromotion.Piece.Queen:s = "♕"; break; case PawnPromotion.Piece.Castle:s = "♖"; break; case PawnPromotion.Piece.Bishop:s = "♗"; break; case PawnPromotion.Piece.Horse:s = "♘"; break; } }
                F1.Content = s;
                F1.Foreground = clr;
                s = "";
            }
        }

        private void G1_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
    s = G1.Content.ToString();
                }
                catch (Exception)
                {
                    
                   
                }
            
                G1.Content = "";
                clr = G1.Foreground;
            }
            else
            {
                if (s == "♙" & (clr == Brushes.Black)) { var pawnp = new PawnPromotion(); pawnp.ShowDialog(); switch (pawnp.P) { case PawnPromotion.Piece.Queen:s = "♕"; break; case PawnPromotion.Piece.Castle:s = "♖"; break; case PawnPromotion.Piece.Bishop:s = "♗"; break; case PawnPromotion.Piece.Horse:s = "♘"; break; } }
                G1.Content = s;
                G1.Foreground = clr;
                s = "";
            }
        }

        private void H1_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
      s = H1.Content.ToString();
                }
                catch (Exception)
                {
                    
                   
                }
          
                H1.Content = "";
                clr = H1.Foreground;
            }
            else
            {
                if (s == "♙" & (clr == Brushes.Black)) { var pawnp = new PawnPromotion(); pawnp.ShowDialog(); switch (pawnp.P) { case PawnPromotion.Piece.Queen:s = "♕"; break; case PawnPromotion.Piece.Castle:s = "♖"; break; case PawnPromotion.Piece.Bishop:s = "♗"; break; case PawnPromotion.Piece.Horse:s = "♘"; break; } }
                H1.Content = s;
                H1.Foreground = clr;
                s = "";
            }
        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
                    s = A2.Content.ToString();
                }
                catch (Exception)
                {

                 
                }
               
                A2.Content = "";
                clr = A2.Foreground;
            }
            else
            {
                A2.Content = s;
                A2.Foreground = clr;
                s = "";
            }
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
          s = B2.Content.ToString();
                }
                catch (Exception)
                {
                    
                    
                }
      
                B2.Content = "";
                clr = B2.Foreground;
            }
            else
            {
                B2.Content = s;
                B2.Foreground = clr;
                s = "";
            }
        }

        private void C2_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
 s = C2.Content.ToString();
                }
                catch (Exception)
                {
                    
                    
                }
               
                C2.Content = "";
                clr = C2.Foreground;
            }
            else
            {
                C2.Content = s;
                C2.Foreground = clr;
                s = "";
            }
        }

        private void D2_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
   s = D2.Content.ToString();
                }
                catch (Exception)
                {
                    
                   
                }
             
                D2.Content = "";
                clr = D2.Foreground;
            }
            else
            {
                D2.Content = s;
                D2.Foreground = clr;
                s = "";
            }
        }

        private void E2_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
 s = E2.Content.ToString();
                }
                catch (Exception)
                {
                    
          
                }
               
                E2.Content = "";
                clr = E2.Foreground;
            }
            else
            {
                E2.Content = s;
                E2.Foreground = clr;
                s = "";
            }
        }

        private void F2_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
    s = F2.Content.ToString();
                }
                catch (Exception)
                {
                                    }
            
                F2.Content = "";
                clr = F2.Foreground;
            }
            else
            {
                F2.Content = s;
                F2.Foreground = clr;
                s = "";
            }
        }

        private void G2_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
       s = G2.Content.ToString();
                }
                catch (Exception)
                {
                    
                }
         
                G2.Content = "";
                clr = G2.Foreground;
            }
            else
            {
                G2.Content = s;
                G2.Foreground = clr;
                s = "";
            }
        }

        private void H2_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
s = H2.Content.ToString();
                }
                catch (Exception)
                {
                    
                    
                }
                
                H2.Content = "";
                clr = H2.Foreground;
            }
            else
            {
                H2.Content = s;
                H2.Foreground = clr;
                s = "";
            }
        }

        private void A3_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
 s = A3.Content.ToString();
                }
                catch (Exception)
                {
                    
                   
                }

            
                A3.Content = "";
                clr = A3.Foreground;
            }
            else
            {
                A3.Content = s;
                A3.Foreground = clr;
                s = "";
            }
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
                    s = B3.Content.ToString();
                }
                catch (Exception)
                {


                }


                B3.Content = "";
                clr = B3.Foreground;
            }
            else
            {
                B3.Content = s;
                B3.Foreground = clr;
                s = "";
            }
        }

        private void C3_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
                    s = C3.Content.ToString();
                }
                catch (Exception)
                {


                }


                C3.Content = "";
                clr = C3.Foreground;
            }
            else
            {
                C3.Content = s;
                C3.Foreground = clr;
                s = "";
            }
        }

        private void D3_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
                    s = D3.Content.ToString();
                }
                catch (Exception)
                {


                }


                D3.Content = "";
                clr = D3.Foreground;
            }
            else
            {
                D3.Content = s;
                D3.Foreground = clr;
                s = "";
            }
        }

        private void E3_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
                    s = E3.Content.ToString();
                }
                catch (Exception)
                {


                }


                E3.Content = "";
                clr = E3.Foreground;
            }
            else
            {
                E3.Content = s;
                E3.Foreground = clr;
                s = "";
            }
        }

        private void F3_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
                    s = F3.Content.ToString();
                }
                catch (Exception)
                {


                }


                F3.Content = "";
                clr = F3.Foreground;
            }
            else
            {
                F3.Content = s;
                F3.Foreground = clr;
                s = "";
            }
        }

        private void G3_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
                    s = G3.Content.ToString();
                }
                catch (Exception)
                {


                }


                G3.Content = "";
                clr = G3.Foreground;
            }
            else
            {
                G3.Content = s;
                G3.Foreground = clr;
                s = "";
            }
        }

        private void H3_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
                    s = H3.Content.ToString();
                }
                catch (Exception)
                {


                }


                H3.Content = "";
                clr = H3.Foreground;
            }
            else
            {
                H3.Content = s;
                H3.Foreground = clr;
                s = "";

            }
        }

        private void A4_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try
                {
                    s = A4.Content.ToString();
                }
                catch (Exception)
                {


                }


                A4.Content = "";
                clr = A4.Foreground;
            }
            else
            {
                A4.Content = s;
                A4.Foreground = clr;
                s = "";
            }
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try{s = B4.Content.ToString();}catch (Exception){}
                B4.Content = "";
                clr = B4.Foreground;
            }
            else
            {
                B4.Content = s;
                B4.Foreground = clr;
                s = "";
            }
        }

        private void C4_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = C4.Content.ToString(); }
                catch (Exception) { }
                C4.Content = "";
                clr = C4.Foreground;
            }
            else
            {
                C4.Content = s;
                C4.Foreground = clr;
                s = "";
            }
        }

        private void D4_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = D4.Content.ToString(); }
                catch (Exception) { }
                D4.Content = "";
                clr = D4.Foreground;
            }
            else
            {
                D4.Content = s;
                D4.Foreground = clr;
                s = "";
            }
        }

        private void E4_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = E4.Content.ToString(); }
                catch (Exception) { }
                E4.Content = "";
                clr = E4.Foreground;
            }
            else
            {
                E4.Content = s;
                E4.Foreground = clr;
                s = "";
            }
        }

        private void F4_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = F4.Content.ToString(); }
                catch (Exception) { }
                F4.Content = "";
                clr = F4.Foreground;
            }
            else
            {
                F4.Content = s;
                F4.Foreground = clr;
                s = "";
            }
        }

        private void G4_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = G4.Content.ToString(); }
                catch (Exception) { }
                G4.Content = "";
                clr = G4.Foreground;
            }
            else
            {
                G4.Content = s;
                G4.Foreground = clr;
                s = "";
            }
        }

        private void H4_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = H4.Content.ToString(); }
                catch (Exception) { }
                H4.Content = "";
                clr = H4.Foreground;
            }
            else
            {
                H4.Content = s;
                H4.Foreground = clr;
                s = "";
            }
        }

        private void A5_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = A5.Content.ToString(); }
                catch (Exception) { }
                A5.Content = "";
                clr = A5.Foreground;
            }
            else
            {
                A5.Content = s;
                A5.Foreground = clr;
                s = "";
            }
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = B5.Content.ToString(); }
                catch (Exception) { }
                B5.Content = "";
                clr = B5.Foreground;
            }
            else
            {
                B5.Content = s;
                B5.Foreground = clr;
                s = "";
            }
        }

        private void C5_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = C5.Content.ToString(); }
                catch (Exception) { }
                C5.Content = "";
                clr = C5.Foreground;
            }
            else
            {
                C5.Content = s;
                C5.Foreground = clr;
                s = "";
            }
        }

        private void D5_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = D5.Content.ToString(); }
                catch (Exception) { }
                D5.Content = "";
                clr = D5.Foreground;
            }
            else
            {
                D5.Content = s;
                D5.Foreground = clr;
                s = "";
            }
        }

        private void E5_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = E5.Content.ToString(); }
                catch (Exception) { }
                E5.Content = "";
                clr = E5.Foreground;
            }
            else
            {
                E5.Content = s;
                E5.Foreground = clr;
                s = "";
            }
        }

        private void F5_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = F5.Content.ToString(); }
                catch (Exception) { }
                F5.Content = "";
                clr = F5.Foreground;
            }
            else
            {
                F5.Content = s;
                F5.Foreground = clr;
                s = "";
            }
        }

        private void G5_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = G5.Content.ToString(); }
                catch (Exception) { }
                G5.Content = "";
                clr = G5.Foreground;
            }
            else
            {
                G5.Content = s;
                G5.Foreground = clr;
                s = "";
            }
        }

        private void H5_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = H5.Content.ToString(); }
                catch (Exception) { }
                H5.Content = "";
                clr = H5.Foreground;
            }
            else
            {
                H5.Content = s;
                H5.Foreground = clr;
                s = "";
            }
        }

        private void A6_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = A6.Content.ToString(); }
                catch (Exception) { }
                A6.Content = "";
                clr = A6.Foreground;
            }
            else
            {
                A6.Content = s;
                A6.Foreground = clr;
                s = "";
            }
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = B6.Content.ToString(); }
                catch (Exception) { }
                B6.Content = "";
                clr = B6.Foreground;
            }
            else
            {
                B6.Content = s;
                B6.Foreground = clr;
                s = "";
            }
        }

        private void C6_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = C6.Content.ToString(); }
                catch (Exception) { }
                C6.Content = "";
                clr = C6.Foreground;
            }
            else
            {
                C6.Content = s;
                C6.Foreground = clr;
                s = "";
            }
        }

        private void D6_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = D6.Content.ToString(); }
                catch (Exception) { }
                D6.Content = "";
                clr = D6.Foreground;
            }
            else
            {
                D6.Content = s;
                D6.Foreground = clr;
                s = "";
            }
        }

        private void E6_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = E6.Content.ToString(); }
                catch (Exception) { }
                E6.Content = "";
                clr = E6.Foreground;
            }
            else
            {
                E6.Content = s;
                E6.Foreground = clr;
                s = "";
            }
        }

        private void F6_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = F6.Content.ToString(); }
                catch (Exception) { }
                F6.Content = "";
                clr = F6.Foreground;
            }
            else
            {
                F6.Content = s;
                F6.Foreground = clr;
                s = "";
            }
        }

        private void G6_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = G6.Content.ToString(); }
                catch (Exception) { }
                G6.Content = "";
                clr = G6.Foreground;
            }
            else
            {
                G6.Content = s;
                G6.Foreground = clr;
                s = "";
            }
        }

        private void H6_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = H6.Content.ToString(); }
                catch (Exception) { }
                H6.Content = "";
                clr = H6.Foreground;
            }
            else
            {
                H6.Content = s;
                H6.Foreground = clr;
                s = "";
            }
        }

        private void A7_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = A7.Content.ToString(); }
                catch (Exception) { }
                A7.Content = "";
                clr = A7.Foreground;
            }
            else
            {
                A7.Content = s;
                A7.Foreground = clr;
                s = "";
            }
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = B7.Content.ToString(); }
                catch (Exception) { }
                B7.Content = "";
                clr = B7.Foreground;
            }
            else
            {
                B7.Content = s;
                B7.Foreground = clr;
                s = "";
            }
        }

        private void C7_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = C7.Content.ToString(); }
                catch (Exception) { }
                C7.Content = "";
                clr = C7.Foreground;
            }
            else
            {
                C7.Content = s;
                C7.Foreground = clr;
                s = "";
            }
        }

        private void D7_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = D7.Content.ToString(); }
                catch (Exception) { }
                D7.Content = "";
                clr = D7.Foreground;
            }
            else
            {
                D7.Content = s;
                D7.Foreground = clr;
                s = "";
            }
        }

        private void E7_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = E7.Content.ToString(); }
                catch (Exception) { }
                E7.Content = "";
                clr = E7.Foreground;
            }
            else
            {
                E7.Content = s;
                E7.Foreground = clr;
                s = "";
            }
        }

        private void F7_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = F7.Content.ToString(); }
                catch (Exception) { }
                F7.Content = "";
                clr = F7.Foreground;
            }
            else
            {
                F7.Content = s;
                F7.Foreground = clr;
                s = "";
            }
        }

        private void G7_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = G7.Content.ToString(); }
                catch (Exception) { }
                G7.Content = "";
                clr = G7.Foreground;
            }
            else
            {
                G7.Content = s;
                G7.Foreground = clr;
                s = "";
            }
        }

        private void H7_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = H7.Content.ToString(); }
                catch (Exception) { }
                H7.Content = "";
                clr = H7.Foreground;
            }
            else
            {
                H7.Content = s;
                H7.Foreground = clr;
                s = "";
            }
        }

        private void A8_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = A8.Content.ToString(); }
                catch (Exception) { }
                A8.Content = "";
                clr = A8.Foreground;
            }
            else
            {
                if (s == "♙" & !(clr == Brushes.Black)) { var pawnp = new PawnPromotion(); pawnp.ShowDialog(); switch (pawnp.P) { case PawnPromotion.Piece.Queen:s = "♕"; break; case PawnPromotion.Piece.Castle:s = "♖"; break; case PawnPromotion.Piece.Bishop:s = "♗"; break; case PawnPromotion.Piece.Horse:s = "♘"; break; } }
                A8.Content = s;
                A8.Foreground = clr;
                s = "";
            }
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = B8.Content.ToString(); }
                catch (Exception) { }
                B8.Content = "";
                clr = B8.Foreground;
            }
            else
            {
                if (s == "♙" & !(clr == Brushes.Black)) { var pawnp = new PawnPromotion(); pawnp.ShowDialog(); switch (pawnp.P) { case PawnPromotion.Piece.Queen:s = "♕"; break; case PawnPromotion.Piece.Castle:s = "♖"; break; case PawnPromotion.Piece.Bishop:s = "♗"; break; case PawnPromotion.Piece.Horse:s = "♘"; break; } }
                B8.Content = s;
                B8.Foreground = clr;
                
                s = "";
            }
        }

        private void C8_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = C8.Content.ToString(); }
                catch (Exception) { }
                C8.Content = "";
                clr = C8.Foreground;
            }
            else
            {
                if (s == "♙" & !(clr == Brushes.Black)) { var pawnp = new PawnPromotion(); pawnp.ShowDialog(); switch (pawnp.P) { case PawnPromotion.Piece.Queen:s = "♕"; break; case PawnPromotion.Piece.Castle:s = "♖"; break; case PawnPromotion.Piece.Bishop:s = "♗"; break; case PawnPromotion.Piece.Horse:s = "♘"; break; } }
                C8.Content = s;
                C8.Foreground = clr;
                s = "";
            }
        }

        private void D8_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = D8.Content.ToString(); }
                catch (Exception) { }
                D8.Content = "";
                clr = D8.Foreground;
            }
            else
            {
                if (s == "♙" & !(clr == Brushes.Black)) { var pawnp = new PawnPromotion(); pawnp.ShowDialog(); switch (pawnp.P) { case PawnPromotion.Piece.Queen:s = "♕"; break; case PawnPromotion.Piece.Castle:s = "♖"; break; case PawnPromotion.Piece.Bishop:s = "♗"; break; case PawnPromotion.Piece.Horse:s = "♘"; break; } }
                D8.Content = s;
                D8.Foreground = clr;
                s = "";
            }
        }

        private void E8_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = E8.Content.ToString(); }
                catch (Exception) { }
                E8.Content = "";
                clr = E8.Foreground;
            }
            else
            {
                if (s == "♙" & !(clr == Brushes.Black)) { var pawnp = new PawnPromotion(); pawnp.ShowDialog(); switch (pawnp.P) { case PawnPromotion.Piece.Queen:s = "♕"; break; case PawnPromotion.Piece.Castle:s = "♖"; break; case PawnPromotion.Piece.Bishop:s = "♗"; break; case PawnPromotion.Piece.Horse:s = "♘"; break; } }
                E8.Content = s;
                E8.Foreground = clr;
                s = "";
            }
        }

        private void F8_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = F8.Content.ToString(); }
                catch (Exception) { }
                F8.Content = "";
                clr = F8.Foreground;
            }
            else
            {
                if (s == "♙" & !(clr == Brushes.Black)) { var pawnp = new PawnPromotion(); pawnp.ShowDialog(); switch (pawnp.P) { case PawnPromotion.Piece.Queen:s = "♕"; break; case PawnPromotion.Piece.Castle:s = "♖"; break; case PawnPromotion.Piece.Bishop:s = "♗"; break; case PawnPromotion.Piece.Horse:s = "♘"; break; } }
                F8.Content = s;
                F8.Foreground = clr;
                s = "";
            }
        }

        private void G8_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = G8.Content.ToString(); }
                catch (Exception) { }
                G8.Content = "";
                clr = G8.Foreground;
            }
            else
            {
                if (s == "♙" & !(clr == Brushes.Black)) { var pawnp = new PawnPromotion(); pawnp.ShowDialog(); switch (pawnp.P) { case PawnPromotion.Piece.Queen:s = "♕"; break; case PawnPromotion.Piece.Castle:s = "♖"; break; case PawnPromotion.Piece.Bishop:s = "♗"; break; case PawnPromotion.Piece.Horse:s = "♘"; break; } }
                G8.Content = s;
                G8.Foreground = clr;
                s = "";
            }
        }

        private void H8_Click(object sender, RoutedEventArgs e)
        {
            if (s == "")
            {
                try { s = H8.Content.ToString(); }
                catch (Exception) { }
                H8.Content = "";
                clr = H8.Foreground;
            }
            else
            {
                if (s == "♙" & !(clr == Brushes.Black)) { var pawnp = new PawnPromotion(); pawnp.ShowDialog(); switch (pawnp.P) { case PawnPromotion.Piece.Queen:s = "♕"; break; case PawnPromotion.Piece.Castle:s = "♖"; break; case PawnPromotion.Piece.Bishop:s = "♗"; break; case PawnPromotion.Piece.Horse:s = "♘"; break; } }
                H8.Content = s;
                H8.Foreground = clr;
                s = "";
            }
        }

        #endregion

        #region Other
private void About_Click(object sender, RoutedEventArgs e)
        {
         var ab = new About();
         ab.ShowDialog();
            
        }

        public static string GetCPUName()
        {
            var val = "" ;
            ManagementObjectSearcher mos =
  new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject mo in mos.Get())
            {
                val =(mo["Name"].ToString());
            }
            return val;
        }

        public static string GetOSFriendlyName()
        {
            string result = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                result = os["Caption"].ToString();
                break;
            }
            return result;
        }

        public static string GetManufacturer()
        {
            var val = "";
            // create management class object
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            //collection to store all management objects
            ManagementObjectCollection moc = mc.GetInstances();
            if (moc.Count != 0)
            {
                foreach (ManagementObject mo in mc.GetInstances())
                {
                    // display general system information
                    val = val + "  " + "\nMachine Make: " + "  " + mo["Manufacturer"].ToString();
                }
            }
            return val;
        }
        #endregion

       
    }
}
