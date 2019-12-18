using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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


        private void pictureBoxArea_MouseDown(object sender, MouseEventArgs e)
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
            areaDeJogo.move();
            redesenhaArea();
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            areaDeJogo = new AreaDeJogo(pictureBoxArea.Size);
        }

        private async void guardarPista_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "text Documents|*.txt", ValidateNames = true })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    using(StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        await sw.WriteAsync(areaDeJogo.getString());
                        MessageBox.Show("Pista guardada com sucesso!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void numericUpDownFM_ValueChanged(object sender, EventArgs e)
        {
            areaDeJogo.Carro.MaxF = (float)numericUpDownFM.Value;
        }

        private void numericUpDownM_ValueChanged(object sender, EventArgs e)
        {
            areaDeJogo.Carro.Massa = (float)numericUpDownM.Value;
        }

        private void numericUpDownV_ValueChanged(object sender, EventArgs e)
        {
            areaDeJogo.Carro.MaxS = (float)numericUpDownV.Value;
        }

        private void iniciarSimulacao_Click(object sender, EventArgs e)
        {
            areaDeJogo.Comeca = true; 
        }

        private async void selecionarPista_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter="Text Documents|*.txt", ValidateNames = true, Multiselect = false })
            {
                if(ofd.ShowDialog()== DialogResult.OK)
                {
                    using(StreamReader sr = new StreamReader(ofd.FileName))
                    {

                        areaDeJogo.DadosPonto = await sr.ReadToEndAsync();
                    }
                }
            }

            areaDeJogo.addFicheiroLista();

            //C:\Users\bruno\source\repos\PistaDeConducao
        }
    }
}
