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
                string filePath = openFileDialog.FileName;

                try
                {
                    Bitmap processedImage = await imagenRepository.ProcesarImagenAsync(filePath);
                    pbImagen.Image = processedImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error processing image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
