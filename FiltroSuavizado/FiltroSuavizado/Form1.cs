using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltroSuavizado
{
    public partial class Form1 : Form
    {
        Bitmap imagenOriginal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagenes|*.jpg;*.png;*.bmp";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                pbOriginal.Image = img;
                imagenOriginal = new Bitmap(img);
            }
        }

        private void btnSuavizar_Click(object sender, EventArgs e)
        {
            if (imagenOriginal == null)
            {
                MessageBox.Show("porfavor carga  una imagen");
                return;
            }

            int ancho = imagenOriginal.Width;
            int alto = imagenOriginal.Height;
            Bitmap imagenSuavizada = new Bitmap(ancho, alto);

            for (int x = 1; x < ancho - 1;x++ )
            {                
                for (int y = 1; y < alto - 1;y++ )
                {
                    int sumaR = 0, sumaG = 0, sumaB = 0;
                    for (int i = -1; i <= 1;i++ )
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color pixel = imagenOriginal.GetPixel(x + i, y + j);
                            sumaR += pixel.R;
                            sumaG += pixel.G;
                            sumaB += pixel.B;
                        }
                    }

                    int promedioR = sumaR / 9;
                    int promedioG = sumaG / 9;
                    int promedioB = sumaB / 9;

                    Color nuevoColor = Color.FromArgb(promedioR, promedioG, promedioB);
                    imagenSuavizada.SetPixel(x,y,nuevoColor);
                }
            }
            pbResultado.Image = imagenSuavizada;

        }

    }
}
