using System;
using System.IO;
using System.Threading.Tasks;
using CatFactApp.Models;

namespace CatFactApp.Utils
{
    public class FileWriter : IFileWriter
    {
        public async Task AppendFactAsync(string fileName, CatFact fact)
        {
            // Katalog startowy aplikacji (tam gdzie jest .csproj)
            string projectRoot = GetProjectRoot();

            // Katalog Data w katalogu projektu
            string dataDir = Path.Combine(projectRoot, "Data");
            if (!Directory.Exists(dataDir))
                Directory.CreateDirectory(dataDir);

            // Ścieżka do pliku z nazwą podaną w parametrze (np. cat_facts.txt)
            string filePath = Path.Combine(dataDir, fileName);

            bool writeHeader = !File.Exists(filePath) || new FileInfo(filePath).Length == 0;

            using (var stream = new StreamWriter(filePath, append: true))
            {
                // Automatyczny nagłówek
                if (writeHeader)
                    await stream.WriteLineAsync(string.Join(",", typeof(CatFact).GetProperties().Select(p => p.Name.ToLower())));

                await stream.WriteLineAsync(string.Join(",", typeof(CatFact).GetProperties().Select(p =>
                {
                    var value = p.GetValue(fact);
                    return p.PropertyType == typeof(string) ? $"\"{value}\"" : value?.ToString();
                })));
            }
        }
        
        private string GetProjectRoot()
        {
            string dir = AppContext.BaseDirectory;
            while (!string.IsNullOrEmpty(dir) && Directory.Exists(dir))
            {
                var csprojFiles = Directory.GetFiles(dir, "*.csproj");
                if (csprojFiles.Length > 0)
                    return dir;

                var parent = Directory.GetParent(dir);
                if (parent == null || parent.FullName == dir)
                    break;
                dir = parent.FullName;
            }
            // Jeśli nie znajdzie .csproj, zwraca katalog startowy aplikacji
            return AppContext.BaseDirectory;
        }
    }
}