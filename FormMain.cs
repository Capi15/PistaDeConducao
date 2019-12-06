using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PistaDeConducao
{
    public partial class FormMain : Form
    {

        private AreaDeJogo areaDeJogo;
        public FormMain()
        {

            InitializeComponent();
            areaDeJogo = new AreaDeJogo(pictureBoxArea.Size);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            desenhaArea(g);
        }

        private void desenhaArea(Graphics g)
        {
            g.Clear(pictureBoxArea.BackColor);
            areaDeJogo.Draw(g);
        }


        private void redesenhaArea()
        {
            BufferedGraphicsContext currentContext;
            BufferedGraphics myBuffer;
            currentContext = BufferedGraphicsManager.Current;
            myBuffer = currentContext.Allocate(this.pictureBoxArea.CreateGraphics(),
                this.pictureBoxArea.DisplayRectangle);
            Graphics g = myBuffer.Graphics;

            desenhaArea(g);

            myBuffer.Render();
            myBuffer.Dispose();
        }

        private void pictureBoxArea_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBoxArea_MouseUp(object sender, MouseEventArgs e)
        {
            
            areaDeJogo.mouseOnClick(e.X, e.Y);
        }

        private void pictureBoxArea_SizeChanged(object sender, EventArgs e)
        {
            areaDeJogo.Area = pictureBoxArea.Size;
            pictureBoxArea.Invalidate();
        }

        private void timerAnima_Tick(object sender, EventArgs e)
        {
            redesenhaArea();
        }
    }
}
