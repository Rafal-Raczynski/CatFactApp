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
            // Ustalam ścieżkę folderu względem katalogu projektu
            string dataFolder = Path.Combine(Directory.GetCurrentDirectory(), "Data");
            if (!Directory.Exists(dataFolder))
                Directory.CreateDirectory(dataFolder);

            // Ścieżka do pliku
            string filePath = Path.Combine(dataFolder, "cat_facts.txt");

            bool writeHeader = !File.Exists(filePath) || new FileInfo(filePath).Length == 0;

            using (var stream = new StreamWriter(filePath, append: true))
            {
                if (writeHeader)
                    await stream.WriteLineAsync("facts,length");
                await stream.WriteLineAsync($"{fact.Fact?.Replace(",", " ")},{fact.Length}");
            }
        }
    }
}