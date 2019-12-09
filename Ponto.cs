using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PistaDeConducao
{
    class Ponto
    {
        private Vector2 pos;
        private SizeF dim;
        private SolidBrush pincel;


        public Ponto(Vector2 pos)
        {
            this.dim = new SizeF(20, 20);
            this.pos = pos;
        }


        //Propriadades da classe Ponto
        public Vector2 Pos
        {
            get { return pos; }
            set { pos = value; }
        }

        public SizeF Dim
        {
            get { return dim; }
            set { dim = value; }
        }

        public SolidBrush Pincel
        {
            get { return pincel; }
            set { pincel = value; }
        }

        public bool IsFirst { get; internal set; }

        public void Draw(Graphics g)
        {
            g.ResetTransform();
            pincel = new SolidBrush(this.IsFirst ? Color.Gray : Color.Orange);
            RectangleF rectangle = new RectangleF(this.Pos.X- Dim.Width/2, this.Pos.Y - Dim.Height/2, Dim.Width, Dim.Height);
            g.FillEllipse(pincel, rectangle);
        }
    }
}
