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
        private float rotation;
        private Vector2 pos, vel, acel;
        private SizeF dim;
        private PointF[] pontosBody;



        public Carro()
        {
            dim = new SizeF(40f, 15f);
            pos = new Vector2(0, 0);
            vel = new Vector2(0.1f);
            acel = new Vector2(0.1f);

            this.pontosBody = new PointF[] {
                new PointF(-dim.Width / (float)2, -dim.Height / (float)2),
                new PointF(dim.Width/(float)2, 0),
                new PointF(-dim.Width/(float)2, dim.Height/(float)2),
                new PointF(-dim.Width / (float)2, -dim.Height / (float)2)
            };
        }


        public float Massa { get; set; } = 1f;
        public float MaxF { get; set; } = 0.2f;

        public float MaxS { get; set; } = 5.0f;

        public Vector2 Vel
        {
            get { return vel; }
            set { vel = value; }
        }

        public Vector2 Acel
        {
            get { return acel; }
            set { acel = value; }
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
            g.RotateTransform(this.rotation);
            g.TranslateTransform(this.Pos.X, this.Pos.Y, System.Drawing.Drawing2D.MatrixOrder.Append);

            g.FillPolygon(Brushes.Blue, this.pontosBody);
        }

        public Vector2 Seek(Ponto alvo)
        {

            Vector2 forca = new Vector2(0);

            Vector2 desejo = Vector2.Normalize(alvo.Pos - pos) * MaxS;
            forca = desejo - vel;

            return forca;
        }

        public void Move()
        {
            acel = (this.truncate(acel, MaxF)/ Massa);
            vel = this.truncate(vel + acel, MaxS);
            pos += vel;

            rotation = (float)Math.Atan2(vel.Y, vel.X) * 180 / (float)Math.PI;

        }

        private Vector2 truncate(Vector2 vetor, float max)
        {
            if (vetor.Length() > max)
            {
                vetor = Vector2.Normalize(vetor) * max;
            }
            return vetor;
        }


    }
}
