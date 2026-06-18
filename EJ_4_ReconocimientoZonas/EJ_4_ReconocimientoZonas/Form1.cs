using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EJ_4_ReconocimientoZonas
{
    public partial class Form1 : Form
    {
        string cadenaConexion = @"Server=DESKTOP-A8IF6A9\MSSQLSERVER01;Database=MapaZonasDB;Integrated Security=True;TrustServerCertificate=True;";
        Bitmap mapaBitmap;

        public Form1()
        {
            InitializeComponent();
        }
        private void btnCargarMapa_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = img;
                mapaBitmap = new Bitmap(img);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (mapaBitmap == null)
            {
                MessageBox.Show("carga la imagen.");
                return;
            }
            Color colorPixel = mapaBitmap.GetPixel(e.X, e.Y);
            if (rbGuardar.Checked)
            {
                string nombreZona = txtNombreZona.Text.Trim();
                if (string.IsNullOrEmpty(nombreZona))
                {
                    MessageBox.Show("Escribe un nombre para la zona antes de hacer clic.");
                    return;
                }

                GuardarMuestraEnBD(nombreZona, colorPixel);
            }
            else if (rbReconocer.Checked)
            {
                ReconocerZona(colorPixel);
            }
        }
        private void GuardarMuestraEnBD(string nombreZona, Color color)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string query = "INSERT INTO MuestrasZonas (NombreZona, ValorR, ValorG, ValorB) VALUES (@Nombre, @R, @G, @B)";
                SqlCommand comando = new SqlCommand(query, conexion);
                
                comando.Parameters.AddWithValue("@Nombre", nombreZona);
                comando.Parameters.AddWithValue("@R", color.R);
                comando.Parameters.AddWithValue("@G", color.G);
                comando.Parameters.AddWithValue("@B", color.B);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar en BD: " + ex.Message);
                }
            }
        }
        private void ReconocerZona(Color colorPixelClic)
        {
            Dictionary<string, int> conteoCoincidencias = new Dictionary<string, int>();
            double umbralDistancia = 60.0; 

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT NombreZona, ValorR, ValorG, ValorB FROM MuestrasZonas";
                SqlCommand comando = new SqlCommand(query, conexion);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        string nombreZonaBD = reader["NombreZona"].ToString();
                        int rBD = Convert.ToInt32(reader["ValorR"]);
                        int gBD = Convert.ToInt32(reader["ValorG"]);
                        int bBD = Convert.ToInt32(reader["ValorB"]);

                        double distancia = Math.Sqrt(Math.Pow(colorPixelClic.R - rBD, 2) +
                                                     Math.Pow(colorPixelClic.G - gBD, 2) +
                                                     Math.Pow(colorPixelClic.B - bBD, 2));

                        if (distancia <= umbralDistancia)
                        {
                            if (conteoCoincidencias.ContainsKey(nombreZonaBD))
                            {
                                conteoCoincidencias[nombreZonaBD]++;
                            } else
                            {
                                conteoCoincidencias.Add(nombreZonaBD, 1);
                            }
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            if (conteoCoincidencias.Count > 0)
            {
                string zonaGanadora = "";
                int maxCoincidencias = 0;
                StringBuilder mensaje = new StringBuilder();
                mensaje.AppendLine("Conteo de coincidencias por categoría:");

                foreach (var item in conteoCoincidencias)
                {
                    mensaje.AppendLine(string.Format("-{0}: {1} coincidencias",item.Key,item.Value));

                    if (item.Value > maxCoincidencias)
                    {
                        maxCoincidencias = item.Value;
                        zonaGanadora = item.Key;
                    }
                }
                lblResultado.Text = "Zona detectada: " + zonaGanadora;
                MessageBox.Show(mensaje.ToString(), "Resultado del Reconocimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblResultado.Text = "Zona detectada: Desconocida";
                MessageBox.Show( "Sin resultados");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}