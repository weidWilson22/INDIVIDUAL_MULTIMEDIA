namespace FiltroSuavizado
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
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.pbResultado = new System.Windows.Forms.PictureBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSuavizar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOriginal
            // 
            this.pbOriginal.Location = new System.Drawing.Point(12, 12);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(486, 288);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginal.TabIndex = 0;
            this.pbOriginal.TabStop = false;
            // 
            // pbResultado
            // 
            this.pbResultado.Location = new System.Drawing.Point(12, 306);
            this.pbResultado.Name = "pbResultado";
            this.pbResultado.Size = new System.Drawing.Size(486, 275);
            this.pbResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResultado.TabIndex = 1;
            this.pbResultado.TabStop = false;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(554, 51);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(138, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "cargar imagen";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSuavizar
            // 
            this.btnSuavizar.Location = new System.Drawing.Point(554, 354);
            this.btnSuavizar.Name = "btnSuavizar";
            this.btnSuavizar.Size = new System.Drawing.Size(133, 23);
            this.btnSuavizar.TabIndex = 3;
            this.btnSuavizar.Text = "suavizar";
            this.btnSuavizar.UseVisualStyleBackColor = true;
            this.btnSuavizar.Click += new System.EventHandler(this.btnSuavizar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 593);
            this.Controls.Add(this.btnSuavizar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.pbResultado);
            this.Controls.Add(this.pbOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.PictureBox pbResultado;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnSuavizar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

