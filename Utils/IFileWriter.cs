using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactApp.Utils
{
    public interface IFileWriter
    {
        Task AppendLineAsync(string fileName, string content);

    }
}
