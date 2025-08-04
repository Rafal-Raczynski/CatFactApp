using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactApp.Utils
{
    public class FileWriter : IFileWriter
{
    public async Task AppendLineAsync(string fileName, string content)
    {
        await File.AppendAllTextAsync(fileName, content + Environment.NewLine);
    }
}
}
