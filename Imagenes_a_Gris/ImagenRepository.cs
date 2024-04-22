using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesAsincronas_ProcesamientoParalelo.Imagenes_a_Gris
{
    public class ImagenRepository
    {
        public async Task ProcesarImagen(string inputFilePath, string outputFilePath)
        {
            await Task.Run(() =>
            {
                using (Bitmap ImagenOriginal = new Bitmap(inputFilePath))
                {
                    Bitmap EscalaGrisImagen = ConvertirEscalaGris(ImagenOriginal);
                    EscalaGrisImagen.Save(outputFilePath);
                }
            });
        }

        private Bitmap ConvertirEscalaGris(Bitmap original)
        {
            Bitmap EscalaGrisImagen = new Bitmap(original.Width, original.Height);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color ColorPixel = original.GetPixel(x, y);
                    int ValorGris = (int)(ColorPixel.R * 0.3 + ColorPixel.G * 0.59 + ColorPixel.B * 0.11);
                    Color ColorGris = Color.FromArgb(ValorGris, ValorGris, ValorGris);
                    EscalaGrisImagen.SetPixel(x, y, ColorGris);
                }
            }

            return EscalaGrisImagen;
        }

        public string ObtenerRutaArchivoSalida(string inputFilePath)
        {
            string directory = System.IO.Path.GetDirectoryName(inputFilePath);
            string fileName = System.IO.Path.GetFileNameWithoutExtension(inputFilePath);
            string outputFileName = $"{fileName}_escalagris.jpg";
            return System.IO.Path.Combine(directory, outputFileName);
        }



    }
}
