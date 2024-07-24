using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FinalProject
{
    public class BoardManagement
    {
        public List<Highlander> highlanders { get; set; }
        public Grid Board { get; set; }
        public Button[,] buttons { get; set; }
        public BoardManagement(Grid board) 
        { 
            Board = board;
        }
        public void generateRandomHighlander(int boardWidth, int boardHeight, int quantity, int boxWidth, int boxHeight)
        {
            Board.Children.Clear();
            Board.ColumnDefinitions.Clear();
            Board.RowDefinitions.Clear();
            Random random = new Random();

            HighlandersGeneration hg = new HighlandersGeneration(quantity);

            for (int i = 0; i < boardHeight; i++)
            {
                Board.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
            }

            for (int j = 0; j < boardWidth; j++)
            {
                Board.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Auto });
            }

            List<Highlander> highlanders = new List<Highlander>();
            highlanders.AddRange(hg.GoodSide);
            highlanders.AddRange(hg.BadSide);
            Button[,] btns = new Button[boardHeight, boardWidth];
            for (int i = 0; i < boardHeight; i++)
            {
                for (int j = 0; j < boardWidth; j++)
                {
                    Button btn = new Button()
                    {
                        Width = boxWidth,
                        Height = boxHeight,
                        Margin = new Thickness(0)
                    };
                    btn.Click += Button_Click;
                    Grid.SetRow(btn, i);
                    Grid.SetColumn(btn, j);

                    Board.Children.Add(btn);
                    btns[i, j] = btn;
                }
            }
            buttons = btns;
            for (int k = 0; k < highlanders.Count(); k++)
            {
                int row, col;

                do
                {
                    row = random.Next(boardHeight);
                    col = random.Next(boardWidth);
                } while (btns[row, col].Content != null);
                //highlanders[k].Pos.X = row;
                //highlanders[k].Pos.Y = col;

                btns[row, col].Content = highlanders[k].Id;
            }
            this.highlanders = highlanders;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string id = Convert.ToString(button.Content);
            Highlander highlander = new Highlander();
            for (int i = 0;i< highlanders.Count; i++)
            {
                if (highlanders[i].Id == id)
                {
                    highlander = highlanders[i];
                }
            }
            if (id != null)
            {
                MessageBox.Show(String.Format("ID: {0}\nName: {1}\nAge: {2}\nPower Level: {3}\n", highlander.Id, highlander.Name, highlander.Age, highlander.PowerLevel));
            }
        }


    }
}
