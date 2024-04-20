using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FuncionesAsincronas_ProcesamientoParalelo
{
    public partial class FrmConversor : Form
    {
        private readonly IFileRepositoryConvertidor _fileRepository;
        public FrmConversor()
        {
            InitializeComponent();
            _fileRepository = new LocalFileRepositoryConvertidor();
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            string filePath = txtArchivo.Text.Trim();

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Ingrese la ruta del archivo.");
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("El archivo no existe.");
                return;
            }

            await ProcessFileAsync(filePath);

            MessageBox.Show("Proceso completado. Revise el archivo para comprobar");
        }

        private async Task ProcessFileAsync(string filePath)
        {
            try
            {
                string text = await _fileRepository.ReadFileAsync(filePath);
                string upperCaseText = text.ToUpper();
                await _fileRepository.SaveFileAsync(filePath, upperCaseText);

                lbDetalle.Items.Add(text);
                lbDetalle.Items.Add(upperCaseText);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el archivo: {ex.Message}");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtArchivo.Clear();
            lbDetalle.Items.Clear();
        }
    }
}
