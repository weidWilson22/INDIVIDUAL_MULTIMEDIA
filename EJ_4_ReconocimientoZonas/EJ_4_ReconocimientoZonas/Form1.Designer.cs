namespace EJ_4_ReconocimientoZonas
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNombreZona = new System.Windows.Forms.TextBox();
            this.btnCargarMapa = new System.Windows.Forms.Button();
            this.btnReconocer = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rbGuardar = new System.Windows.Forms.RadioButton();
            this.rbReconocer = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(753, 488);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // txtNombreZona
            // 
            this.txtNombreZona.Location = new System.Drawing.Point(839, 165);
            this.txtNombreZona.Name = "txtNombreZona";
            this.txtNombreZona.Size = new System.Drawing.Size(167, 20);
            this.txtNombreZona.TabIndex = 1;
            // 
            // btnCargarMapa
            // 
            this.btnCargarMapa.Location = new System.Drawing.Point(839, 46);
            this.btnCargarMapa.Name = "btnCargarMapa";
            this.btnCargarMapa.Size = new System.Drawing.Size(133, 23);
            this.btnCargarMapa.TabIndex = 2;
            this.btnCargarMapa.Text = "Cargar Mapa";
            this.btnCargarMapa.UseVisualStyleBackColor = true;
            this.btnCargarMapa.Click += new System.EventHandler(this.btnCargarMapa_Click);
            // 
            // btnReconocer
            // 
            this.btnReconocer.Location = new System.Drawing.Point(859, 227);
            this.btnReconocer.Name = "btnReconocer";
            this.btnReconocer.Size = new System.Drawing.Size(160, 23);
            this.btnReconocer.TabIndex = 3;
            this.btnReconocer.Text = "Reconocer Zona";
            this.btnReconocer.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(856, 292);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(83, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Zona detectada";
            // 
            // rbGuardar
            // 
            this.rbGuardar.AutoSize = true;
            this.rbGuardar.Location = new System.Drawing.Point(829, 322);
            this.rbGuardar.Name = "rbGuardar";
            this.rbGuardar.Size = new System.Drawing.Size(63, 17);
            this.rbGuardar.TabIndex = 5;
            this.rbGuardar.TabStop = true;
            this.rbGuardar.Text = "Guardar";
            this.rbGuardar.UseVisualStyleBackColor = true;
            // 
            // rbReconocer
            // 
            this.rbReconocer.AutoSize = true;
            this.rbReconocer.Location = new System.Drawing.Point(971, 322);
            this.rbReconocer.Name = "rbReconocer";
            this.rbReconocer.Size = new System.Drawing.Size(78, 17);
            this.rbReconocer.TabIndex = 6;
            this.rbReconocer.TabStop = true;
            this.rbReconocer.Text = "Reconocer";
            this.rbReconocer.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 505);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbReconocer);
            this.Controls.Add(this.rbGuardar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnReconocer);
            this.Controls.Add(this.btnCargarMapa);
            this.Controls.Add(this.txtNombreZona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNombreZona;
        private System.Windows.Forms.Button btnCargarMapa;
        private System.Windows.Forms.Button btnReconocer;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RadioButton rbGuardar;
        private System.Windows.Forms.RadioButton rbReconocer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
    }
}

