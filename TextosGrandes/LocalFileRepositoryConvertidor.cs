using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesAsincronas_ProcesamientoParalelo
{
    public class LocalFileRepositoryConvertidor : IFileRepositoryConvertidor
    {
        public async Task<string> ReadFileAsync(string filePath)
        {
            return await Task.Run(() => File.ReadAllText(filePath));
        }

        public async Task SaveFileAsync(string filePath, string content)
        {
            await Task.Run(() => File.WriteAllText(filePath, content));
        }
    }
}
