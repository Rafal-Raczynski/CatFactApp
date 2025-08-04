using System.IO;
using System.Threading.Tasks;
using CatFactApp.Models;

namespace CatFactApp.Utils
{
    public class FileWriter : IFileWriter
    {
        public async Task AppendFactAsync(string fileName, CatFact fact)
        {
            bool writeHeader = !File.Exists(fileName) || new FileInfo(fileName).Length == 0;

            using (var stream = new StreamWriter(fileName, append: true))
            {
                if (writeHeader)
                    await stream.WriteLineAsync("facts,length");
                await stream.WriteLineAsync($"{fact.Fact.Replace(",", " ")},{fact.Length}");
            }
        }
    }
}