using CatFactApp.Services;
using CatFactApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactApp
{
   public class App
{
    private readonly ICatFactService _catFactService;
    private readonly IFileWriter _fileWriter;

    public App(ICatFactService catFactService, IFileWriter fileWriter)
    {
        _catFactService = catFactService;
        _fileWriter = fileWriter;
    }

    public async Task RunAsync()
    {
        var fact = await _catFactService.GetCatFactAsync();
        await _fileWriter.AppendLineAsync("cat_facts.txt", fact);
        Console.WriteLine($"Saved fact: {fact}");
    }
}

}
