using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PistaDeConducao
{
    class AreaDeJogo
    {
        private Size area;
        private List<Ponto> pontos;
        private Carro carro;


        public AreaDeJogo(Size area)
        {
            this.area = area;
            this.pontos = new List<Ponto>();
            this.carro = new Carro();
        }

        public List<Ponto> Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }

        public Size Area
        {
            get { return area; }
            set
            {
                if (value.Width > 40 && value.Height > 20)
                    area = value;
            }
        }
        public void Draw(Graphics g)
        {
            

            foreach(Ponto pontoP in pontos)
            {
                if (pontos[0] == null)
                {
                    Console.WriteLine(pontoP);
                    pontoP.Pincel.Color = Color.Black;
                    pontoP.Draw(g);
                }
                pontoP.Draw(g);
            }

            this.DrawPath(g);
            carro.Draw(g);
        }

        public void AdicionaPontos(int x, int y)
        {
            Vector2 pos = new Vector2(x, y);
            Ponto p = new Ponto(pos);
            if (this.pontos.Count <= 0)
                p.IsFirst = true;
            pontos.Add(p);      
        }

        public void mouseOnClick(int mouseX, int mouseY)
        {
            AdicionaPontos(mouseX, mouseY);
        }

        public void DrawPath(Graphics g) {

            Ponto p1 = null;
            Ponto p2 = null;
            Pen p = new Pen(Color.DarkGoldenrod, 5);
            p.StartCap = LineCap.Round;
            p.EndCap = LineCap.Round;
            foreach (var ponto in this.pontos)
            {
                if (p1 == null)
                {
                    p1 = ponto;
                    continue;
                }

                p2 = ponto;

                g.DrawLine(p, p1.Pos.X, p1.Pos.Y, p2.Pos.X, p2.Pos.Y);

                p1 = p2;
            }

            if (this.pontos.Count >= 3)
                g.DrawLine(p, p2.Pos.X, p2.Pos.Y, this.pontos[0].Pos.X, this.pontos[0].Pos.Y);
                
            if(this.pontos.Count <= 0)
            {

            }
            else
            {
                carro.Pos = new Vector2(this.pontos[0].Pos.X, this.pontos[0].Pos.Y);
            }
        }
    }
}
