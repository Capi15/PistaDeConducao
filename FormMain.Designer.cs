namespace PistaDeConducao
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxArea = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerAnima = new System.Windows.Forms.Timer(this.components);
            this.guardarPista = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.iniciarSimulacao = new System.Windows.Forms.Button();
            this.forcaM = new System.Windows.Forms.Label();
            this.massa = new System.Windows.Forms.Label();
            this.velocidade = new System.Windows.Forms.Label();
            this.textF = new System.Windows.Forms.TextBox();
            this.textM = new System.Windows.Forms.TextBox();
            this.textV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArea)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxArea
            // 
            this.pictureBoxArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxArea.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBoxArea.Location = new System.Drawing.Point(183, 27);
            this.pictureBoxArea.Name = "pictureBoxArea";
            this.pictureBoxArea.Size = new System.Drawing.Size(605, 411);
            this.pictureBoxArea.TabIndex = 0;
            this.pictureBoxArea.TabStop = false;
            this.pictureBoxArea.SizeChanged += new System.EventHandler(this.pictureBoxArea_SizeChanged);
            this.pictureBoxArea.Click += new System.EventHandler(this.pictureBoxArea_Click);
            this.pictureBoxArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxArea_Paint);
            this.pictureBoxArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxArea_MouseUp);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timerAnima
            // 
            this.timerAnima.Enabled = true;
            this.timerAnima.Interval = 16;
            this.timerAnima.Tick += new System.EventHandler(this.timerAnima_Tick);
            // 
            // guardarPista
            // 
            this.guardarPista.Location = new System.Drawing.Point(12, 27);
            this.guardarPista.Name = "guardarPista";
            this.guardarPista.Size = new System.Drawing.Size(165, 23);
            this.guardarPista.TabIndex = 2;
            this.guardarPista.Text = "Guardar Pista";
            this.guardarPista.UseVisualStyleBackColor = true;
            this.guardarPista.Click += new System.EventHandler(this.guardarPista_Click);
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(12, 56);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(165, 23);
            this.limpar.TabIndex = 3;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // iniciarSimulacao
            // 
            this.iniciarSimulacao.Location = new System.Drawing.Point(12, 85);
            this.iniciarSimulacao.Name = "iniciarSimulacao";
            this.iniciarSimulacao.Size = new System.Drawing.Size(165, 23);
            this.iniciarSimulacao.TabIndex = 4;
            this.iniciarSimulacao.Text = "Iniciar Simulação";
            this.iniciarSimulacao.UseVisualStyleBackColor = true;
            // 
            // forcaM
            // 
            this.forcaM.AutoSize = true;
            this.forcaM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forcaM.Location = new System.Drawing.Point(8, 311);
            this.forcaM.Name = "forcaM";
            this.forcaM.Size = new System.Drawing.Size(108, 20);
            this.forcaM.TabIndex = 5;
            this.forcaM.Text = "Força Máxima";
            // 
            // massa
            // 
            this.massa.AutoSize = true;
            this.massa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.massa.Location = new System.Drawing.Point(8, 357);
            this.massa.Name = "massa";
            this.massa.Size = new System.Drawing.Size(56, 20);
            this.massa.TabIndex = 6;
            this.massa.Text = "Massa";
            // 
            // velocidade
            // 
            this.velocidade.AutoSize = true;
            this.velocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocidade.Location = new System.Drawing.Point(8, 404);
            this.velocidade.Name = "velocidade";
            this.velocidade.Size = new System.Drawing.Size(88, 20);
            this.velocidade.TabIndex = 7;
            this.velocidade.Text = "Velocidade";
            // 
            // textF
            // 
            this.textF.Location = new System.Drawing.Point(130, 313);
            this.textF.Name = "textF";
            this.textF.Size = new System.Drawing.Size(47, 20);
            this.textF.TabIndex = 8;
            this.textF.TextChanged += new System.EventHandler(this.textF_TextChanged);
            // 
            // textM
            // 
            this.textM.Location = new System.Drawing.Point(130, 357);
            this.textM.Name = "textM";
            this.textM.Size = new System.Drawing.Size(47, 20);
            this.textM.TabIndex = 9;
            this.textM.TextChanged += new System.EventHandler(this.textM_TextChanged);
            // 
            // textV
            // 
            this.textV.Location = new System.Drawing.Point(130, 404);
            this.textV.Name = "textV";
            this.textV.Size = new System.Drawing.Size(47, 20);
            this.textV.TabIndex = 10;
            this.textV.TextChanged += new System.EventHandler(this.textV_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textV);
            this.Controls.Add(this.textM);
            this.Controls.Add(this.textF);
            this.Controls.Add(this.velocidade);
            this.Controls.Add(this.massa);
            this.Controls.Add(this.forcaM);
            this.Controls.Add(this.iniciarSimulacao);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.guardarPista);
            this.Controls.Add(this.pictureBoxArea);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArea)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxArea;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timerAnima;
        private System.Windows.Forms.Button guardarPista;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button iniciarSimulacao;
        private System.Windows.Forms.Label forcaM;
        private System.Windows.Forms.Label massa;
        private System.Windows.Forms.Label velocidade;
        private System.Windows.Forms.TextBox textF;
        private System.Windows.Forms.TextBox textM;
        private System.Windows.Forms.TextBox textV;
    }
}

