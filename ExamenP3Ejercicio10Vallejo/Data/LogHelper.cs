using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenP3Ejercicio10Vallejo.Data
{
    public static class LogHelper
    {
        public static async Task Agregarlog(string nombre)
        {
            string log = $"Se incluyo el registro de {nombre}  el {DateTime.Now:dd/MM/yyyy HH:mm}\n";
            string path = Path.Combine(FileSystem.AppDataDirectory, "logs_Ejercicio10Vallejo.txt");
            await File.AppendAllTextAsync(path, log);
        }
        public static async Task<string> LeerLogs()
        {
            string path = Path.Combine(FileSystem.AppDataDirectory, "logs_Ejercicio10Vallejo.txt");
            return File.Exists(path) ? await File.ReadAllTextAsync(path) : "No hay registros disponibles xd.";

        }
    }
}
