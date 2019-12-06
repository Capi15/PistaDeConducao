using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PistaDeConducao
{
    class Reta
    {
        private Vector2 posInicio;
        private Vector2 posFim;
        private SizeF dim;
        private SolidBrush pincel;

        public Reta (Vector2 posInicio, Vector2 posFim)
        {
            this.posInicio = posInicio;
            this.posFim = posFim;
            dim = new SizeF((posFim.X - posInicio.X), (posFim.Y - posInicio.Y));
        }

        public Vector2 PosInicio
        {
            get { return posInicio; }
            set { posInicio = value; }
        }

        public Vector2 PosFim
        {
            get { return posFim; }
            set { posFim = value; }
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
            PointF localInicio = new PointF(PosInicio.X, PosInicio.Y);
            RectangleF retangulo = new RectangleF(localInicio, dim);
            g.FillRectangle(pincel, retangulo);
        }
    }
}
