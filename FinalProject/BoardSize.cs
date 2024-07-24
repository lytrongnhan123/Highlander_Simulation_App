using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class BoardSize
    {
        private int btnWidth = 25;
        private int btnHeight = 25;

        private int boardWidth = 30;
        private int boardHeight = 30;

        public int BtnWidth { get => btnWidth; set => btnWidth = value; }
        public int BtnHeight { get => btnHeight; set => btnHeight = value; }
        public int BoardWidth { get => boardWidth; set => boardWidth = value; }
        public int BoardHeight { get => boardHeight; set => boardHeight = value; }
        public BoardSize() { }
    }
}
