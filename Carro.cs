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
        private float MAX_SPEED = 5.0f;
        private float MAX_FORCE = 0.2f;
        private float massa = 1f;
        private float rotation;
        private Vector2 pos, vel, acel;
        private SolidBrush pincel;
        private SizeF dim;


        public Carro()
        {
            pos = new Vector2(0, 0);
            dim = new SizeF(40f, 15f);
        }

        public float Massa
        {
            get { return massa; }
            set { massa = value; }
        }
        public float MaxF
        {
            get { return MAX_FORCE; }
            set { MAX_FORCE = value; }
        }

        public float MaxS
        {
            get { return MAX_SPEED; }
            set { MAX_SPEED = value; }
        }

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
            pincel = new SolidBrush(Color.Black);
            RectangleF rectangle = new RectangleF(this.Pos.X - Dim.Width / 2, this.Pos.Y -Dim.Height / 2, Dim.Width, Dim.Height);
            g.FillRectangle(pincel, rectangle);
        }

        public Vector2 conduz(Vector2 alvo)
        {
            Vector2 forca = new Vector2(0);

            Vector2 posDesejada = Vector2.Normalize(alvo - pos) * MAX_SPEED;
            forca = posDesejada - vel;

            return forca;
        }

        public void Move()
        {
            acel = truncate(acel, MAX_FORCE);

            vel = truncate(vel + acel, MAX_SPEED);
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
