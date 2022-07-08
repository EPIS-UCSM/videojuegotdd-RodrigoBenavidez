namespace JuegoSnake
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seleccioneNivelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivel1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivel2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivel3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivel4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continuarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivel5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivel6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivel7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivel8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nroManzanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manzanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manzanasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manzanasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.manzanasToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.manzanasToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.manzanasToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.manzanasToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.manzanasToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.manzanasToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.manzanasToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.manzanasToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.manzanasToolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPuntos.Location = new System.Drawing.Point(540, 384);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(51, 54);
            this.lblPuntos.TabIndex = 1;
            this.lblPuntos.Text = "0";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNivel.Location = new System.Drawing.Point(85, 405);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(27, 28);
            this.lblNivel.TabIndex = 3;
            this.lblNivel.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nivel";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccioneNivelToolStripMenuItem,
            this.nroManzanasToolStripMenuItem,
            this.pausarToolStripMenuItem,
            this.continuarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seleccioneNivelToolStripMenuItem
            // 
            this.seleccioneNivelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nivel1ToolStripMenuItem,
            this.nivel2ToolStripMenuItem,
            this.nivel3ToolStripMenuItem,
            this.nivel4ToolStripMenuItem,
            this.nivel5ToolStripMenuItem,
            this.nivel6ToolStripMenuItem,
            this.nivel7ToolStripMenuItem,
            this.nivel8ToolStripMenuItem});
            this.seleccioneNivelToolStripMenuItem.Name = "seleccioneNivelToolStripMenuItem";
            this.seleccioneNivelToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.seleccioneNivelToolStripMenuItem.Text = "Seleccione Nivel";
            this.seleccioneNivelToolStripMenuItem.Click += new System.EventHandler(this.seleccioneNivelToolStripMenuItem_Click);
            // 
            // nivel1ToolStripMenuItem
            // 
            this.nivel1ToolStripMenuItem.Name = "nivel1ToolStripMenuItem";
            this.nivel1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nivel1ToolStripMenuItem.Text = "Nivel 1";
            this.nivel1ToolStripMenuItem.Click += new System.EventHandler(this.nivel1ToolStripMenuItem_Click);
            // 
            // nivel2ToolStripMenuItem
            // 
            this.nivel2ToolStripMenuItem.Name = "nivel2ToolStripMenuItem";
            this.nivel2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nivel2ToolStripMenuItem.Text = "Nivel 2";
            this.nivel2ToolStripMenuItem.Click += new System.EventHandler(this.nivel2ToolStripMenuItem_Click);
            // 
            // nivel3ToolStripMenuItem
            // 
            this.nivel3ToolStripMenuItem.Name = "nivel3ToolStripMenuItem";
            this.nivel3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nivel3ToolStripMenuItem.Text = "Nivel 3";
            this.nivel3ToolStripMenuItem.Click += new System.EventHandler(this.nivel3ToolStripMenuItem_Click);
            // 
            // nivel4ToolStripMenuItem
            // 
            this.nivel4ToolStripMenuItem.Name = "nivel4ToolStripMenuItem";
            this.nivel4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nivel4ToolStripMenuItem.Text = "Nivel 4";
            this.nivel4ToolStripMenuItem.Click += new System.EventHandler(this.nivel4ToolStripMenuItem_Click);
            // 
            // continuarToolStripMenuItem
            // 
            this.continuarToolStripMenuItem.Name = "continuarToolStripMenuItem";
            this.continuarToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.continuarToolStripMenuItem.Text = "Continuar";
            this.continuarToolStripMenuItem.Click += new System.EventHandler(this.continuarToolStripMenuItem_Click);
            // 
            // nivel5ToolStripMenuItem
            // 
            this.nivel5ToolStripMenuItem.Name = "nivel5ToolStripMenuItem";
            this.nivel5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nivel5ToolStripMenuItem.Text = "Nivel 5";
            this.nivel5ToolStripMenuItem.Click += new System.EventHandler(this.nivel5ToolStripMenuItem_Click);
            // 
            // nivel6ToolStripMenuItem
            // 
            this.nivel6ToolStripMenuItem.Name = "nivel6ToolStripMenuItem";
            this.nivel6ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nivel6ToolStripMenuItem.Text = "Nivel 6";
            this.nivel6ToolStripMenuItem.Click += new System.EventHandler(this.nivel6ToolStripMenuItem_Click);
            // 
            // nivel7ToolStripMenuItem
            // 
            this.nivel7ToolStripMenuItem.Name = "nivel7ToolStripMenuItem";
            this.nivel7ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nivel7ToolStripMenuItem.Text = "Nivel 7";
            this.nivel7ToolStripMenuItem.Click += new System.EventHandler(this.nivel7ToolStripMenuItem_Click);
            // 
            // nivel8ToolStripMenuItem
            // 
            this.nivel8ToolStripMenuItem.Name = "nivel8ToolStripMenuItem";
            this.nivel8ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nivel8ToolStripMenuItem.Text = "Nivel 8";
            this.nivel8ToolStripMenuItem.Click += new System.EventHandler(this.nivel8ToolStripMenuItem_Click);
            // 
            // pausarToolStripMenuItem
            // 
            this.pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            this.pausarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.pausarToolStripMenuItem.Text = "Pausar";
            this.pausarToolStripMenuItem.Click += new System.EventHandler(this.pausarToolStripMenuItem_Click);
            // 
            // nroManzanasToolStripMenuItem
            // 
            this.nroManzanasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manzanasToolStripMenuItem,
            this.manzanasToolStripMenuItem1,
            this.manzanasToolStripMenuItem2,
            this.manzanasToolStripMenuItem3,
            this.manzanasToolStripMenuItem4,
            this.manzanasToolStripMenuItem5,
            this.manzanasToolStripMenuItem6,
            this.manzanasToolStripMenuItem7,
            this.manzanasToolStripMenuItem8,
            this.manzanasToolStripMenuItem9,
            this.manzanasToolStripMenuItem10,
            this.manzanasToolStripMenuItem11});
            this.nroManzanasToolStripMenuItem.Name = "nroManzanasToolStripMenuItem";
            this.nroManzanasToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.nroManzanasToolStripMenuItem.Text = "Nro Manzanas";
            this.nroManzanasToolStripMenuItem.Click += new System.EventHandler(this.nroManzanasToolStripMenuItem_Click);
            // 
            // manzanasToolStripMenuItem
            // 
            this.manzanasToolStripMenuItem.Name = "manzanasToolStripMenuItem";
            this.manzanasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manzanasToolStripMenuItem.Text = "3 Manzanas";
            this.manzanasToolStripMenuItem.Click += new System.EventHandler(this.manzanasToolStripMenuItem_Click);
            // 
            // manzanasToolStripMenuItem1
            // 
            this.manzanasToolStripMenuItem1.Name = "manzanasToolStripMenuItem1";
            this.manzanasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.manzanasToolStripMenuItem1.Text = "5 Manzanas";
            this.manzanasToolStripMenuItem1.Click += new System.EventHandler(this.manzanasToolStripMenuItem1_Click);
            // 
            // manzanasToolStripMenuItem2
            // 
            this.manzanasToolStripMenuItem2.Name = "manzanasToolStripMenuItem2";
            this.manzanasToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.manzanasToolStripMenuItem2.Text = "7 Manzanas";
            this.manzanasToolStripMenuItem2.Click += new System.EventHandler(this.manzanasToolStripMenuItem2_Click);
            // 
            // manzanasToolStripMenuItem3
            // 
            this.manzanasToolStripMenuItem3.Name = "manzanasToolStripMenuItem3";
            this.manzanasToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.manzanasToolStripMenuItem3.Text = "9 Manzanas";
            this.manzanasToolStripMenuItem3.Click += new System.EventHandler(this.manzanasToolStripMenuItem3_Click);
            // 
            // manzanasToolStripMenuItem4
            // 
            this.manzanasToolStripMenuItem4.Name = "manzanasToolStripMenuItem4";
            this.manzanasToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.manzanasToolStripMenuItem4.Text = "11 Manzanas";
            this.manzanasToolStripMenuItem4.Click += new System.EventHandler(this.manzanasToolStripMenuItem4_Click);
            // 
            // manzanasToolStripMenuItem5
            // 
            this.manzanasToolStripMenuItem5.Name = "manzanasToolStripMenuItem5";
            this.manzanasToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.manzanasToolStripMenuItem5.Text = "13 Manzanas";
            this.manzanasToolStripMenuItem5.Click += new System.EventHandler(this.manzanasToolStripMenuItem5_Click);
            // 
            // manzanasToolStripMenuItem6
            // 
            this.manzanasToolStripMenuItem6.Name = "manzanasToolStripMenuItem6";
            this.manzanasToolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.manzanasToolStripMenuItem6.Text = "15 Manzanas";
            this.manzanasToolStripMenuItem6.Click += new System.EventHandler(this.manzanasToolStripMenuItem6_Click);
            // 
            // manzanasToolStripMenuItem7
            // 
            this.manzanasToolStripMenuItem7.Name = "manzanasToolStripMenuItem7";
            this.manzanasToolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.manzanasToolStripMenuItem7.Text = "20 Manzanas";
            this.manzanasToolStripMenuItem7.Click += new System.EventHandler(this.manzanasToolStripMenuItem7_Click);
            // 
            // manzanasToolStripMenuItem8
            // 
            this.manzanasToolStripMenuItem8.Name = "manzanasToolStripMenuItem8";
            this.manzanasToolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
            this.manzanasToolStripMenuItem8.Text = "25 Manzanas";
            this.manzanasToolStripMenuItem8.Click += new System.EventHandler(this.manzanasToolStripMenuItem8_Click);
            // 
            // manzanasToolStripMenuItem9
            // 
            this.manzanasToolStripMenuItem9.Name = "manzanasToolStripMenuItem9";
            this.manzanasToolStripMenuItem9.Size = new System.Drawing.Size(180, 22);
            this.manzanasToolStripMenuItem9.Text = "30 Manzanas";
            this.manzanasToolStripMenuItem9.Click += new System.EventHandler(this.manzanasToolStripMenuItem9_Click);
            // 
            // manzanasToolStripMenuItem10
            // 
            this.manzanasToolStripMenuItem10.Name = "manzanasToolStripMenuItem10";
            this.manzanasToolStripMenuItem10.Size = new System.Drawing.Size(180, 22);
            this.manzanasToolStripMenuItem10.Text = "50 Manzanas";
            this.manzanasToolStripMenuItem10.Click += new System.EventHandler(this.manzanasToolStripMenuItem10_Click);
            // 
            // manzanasToolStripMenuItem11
            // 
            this.manzanasToolStripMenuItem11.Name = "manzanasToolStripMenuItem11";
            this.manzanasToolStripMenuItem11.Size = new System.Drawing.Size(180, 22);
            this.manzanasToolStripMenuItem11.Text = "70 Manzanas";
            this.manzanasToolStripMenuItem11.Click += new System.EventHandler(this.manzanasToolStripMenuItem11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoSnake.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(603, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoverPieza);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seleccioneNivelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivel1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivel2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivel3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivel4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continuarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivel5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivel6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivel7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivel8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nroManzanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manzanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manzanasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manzanasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem manzanasToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem manzanasToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem manzanasToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem manzanasToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem manzanasToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem manzanasToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem manzanasToolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem manzanasToolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem manzanasToolStripMenuItem11;
    }
}

