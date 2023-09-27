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

namespace Bojovani_Hrdy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private unit player1;
        private unit player2;

        public MainWindow()
        {
            InitializeComponent();
            player1 = new unit(500, 20);
            player1.HitBox = new Rectangle();
            player1.HitBox.Width = 40;
            player1.HitBox.Height = 80;
            

            player2 = new unit(500, 20);
            player2.HitBox = new Rectangle()
            {
                Width = 40,
                Height = 80
            };
            DrawGame();
            
        }

        private void DrawGame()
        {
            DrawTerrain();
            DrawPlayer(player1); 
            DrawPlayer(player2);
        }

        private void DrawPlayer()
        {

        }

        private void DrawPlayer(unit player)
        {

        }

        private void DrawTerrain()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = canvas.ActualWidth;
            rectangle.Height = canvas.ActualHeight;
            rectangle.Fill = Brushes.Green;
            canvas.Children.Add(rectangle);

        }
    }
}
