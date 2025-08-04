using System.Threading.Tasks;
using CatFactApp.Models;

namespace CatFactApp.Utils
{
    public interface IFileWriter
    {
        Task AppendFactAsync(string fileName, CatFact fact);
    }
}