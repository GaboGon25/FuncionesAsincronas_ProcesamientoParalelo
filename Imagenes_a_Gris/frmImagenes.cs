using FuncionesAsincronas_ProcesamientoParalelo.Imagenes_a_Gris;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncionesAsincronas_ProcesamientoParalelo
{
    public partial class frmImagenes : Form
    {
        public ImagenRepository imagenRepository;
        public frmImagenes()
        {
            InitializeComponent();
            imagenRepository = new ImagenRepository();
        }

        private async void btnProcesar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string inputfilePath = openFileDialog.FileName;
                string outputfilePath = imagenRepository.ObtenerRutaArchivoSalida(inputfilePath);
                

                try
                {
                    await imagenRepository.ProcesarImagen(inputfilePath, outputfilePath);
                    MessageBox.Show("Procesamiento completado. Imagen en escala de grises guardada correctamente. Puede buscar su imagen a gris de donde lo obtuvo", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
       
    }
}
