using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesAsincronas_ProcesamientoParalelo
{
    public interface IFileRepositoryConvertidor
    {
        Task<string> ReadFileAsync(string filePath);
        Task SaveFileAsync(string filePath, string content);
    }
}
