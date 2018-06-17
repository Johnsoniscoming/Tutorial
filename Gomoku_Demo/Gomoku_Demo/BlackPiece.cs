using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku_Demo
{
    class BlackPiece : Piece
    {
        public BlackPiece(int x, int y):base(x,y)
        {
            this.Image = Properties.Resources.black;
            
        }
    }
}
