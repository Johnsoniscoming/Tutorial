using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Gomoku_Demo
{
    abstract class Piece : PictureBox
    {
        private static readonly int Image_Width = 30;
        public Piece(int x,int y)
        {
            this.BackColor = Color.Transparent;
            this.Location =new Point(x- Image_Width/2, y- Image_Width/2);
            this.Size = new Size(Image_Width, Image_Width);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
