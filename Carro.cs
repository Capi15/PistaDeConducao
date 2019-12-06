using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PistaDeConducao
{
    class Carro
    {
        private Vector2 pos;
        private SolidBrush pincel;
        private SizeF dim;

        public Carro()
        {
            pos = new Vector2(0, 0);
            dim = new SizeF(10f, 20f);
        }

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

        public void Draw(Graphics g)
        {
            g.ResetTransform();
            pincel = new SolidBrush(Color.Black);
            RectangleF rectangle = new RectangleF(this.Pos.X, this.Pos.Y, Dim.Width, Dim.Height);
            g.FillRectangle(pincel, rectangle);
        }

        public void Rotacao()
        {

        }
    }
}
