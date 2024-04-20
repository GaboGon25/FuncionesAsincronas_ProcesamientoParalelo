using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesAsincronas_ProcesamientoParalelo.Imagenes_a_Gris
{
    public class ImagenRepository
    {
        public async Task<Bitmap> ProcesarImagenAsync(string filePath)
        {
            return await Task.Run(() =>
            {
                using (Bitmap originalImage = new Bitmap(filePath))
                {
                    return ConvertirEscalaGris(originalImage);
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
    }
}
