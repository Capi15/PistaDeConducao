using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;

namespace PistaDeConducao
{
    class AreaDeJogo
    {
        private Size area;
        private List<Ponto> pontos;
        private int mouseX;
        private int mouseY;


        public AreaDeJogo(Size area)
        {
            this.area = area;
            this.pontos = new List<Ponto>();
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
            //for (int i = 0; i < pontos.Count; i++)
            //{
            //    if (pontos[0] == null)
            //    {
            //        pontos.Draw(g);
            //    };
            //    ponto.Draw(g);
            //};

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
        }

        public void AdicionaPontos(int x, int y)
        {
            Vector2 pos = new Vector2(x, y);
            pontos.Add(new Ponto(pos));      
        }

        public void mouseOnClick(int mouseX, int mouseY)
        {
            AdicionaPontos(mouseX, mouseY);
        }

    }
}
