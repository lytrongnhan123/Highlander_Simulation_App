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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BoardManagement bm;
        BoardSize bs;
        public MainWindow()
        {
            InitializeComponent();
            tblOptions.Text = loadOptionMessage();
            

        }

        private void btnGenerateHighLander_Click(object sender, RoutedEventArgs e)
        {
            bm = new BoardManagement(BoardGrid);
            bs = new BoardSize();
            try
            {
                bs.BoardHeight = Convert.ToInt32(tbRow.Text);
                bs.BoardWidth = Convert.ToInt32(tbCol.Text);
                bs.BtnHeight = Convert.ToInt32(tbHeight.Text);
                bs.BtnWidth = Convert.ToInt32(tbWidth.Text);
                
                int quantity = Convert.ToInt32(tbQuantity.Text);

                bm.generateRandomHighlander(bs.BoardWidth, bs.BoardHeight, quantity, bs.BtnHeight, bs.BtnWidth);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }
        public static string loadOptionMessage()
        {
            return "- Option 1: Simulation will continue until \nthere is 1 highlander left" +
                "\n- Option 2: A certain number of simulation \nruns occurs. Type in the number of iterations:";
        }

        
    }
}
