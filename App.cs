using CatFactApp.Services;
using CatFactApp.Utils;
using CatFactApp.Models;
using System.Threading.Tasks;
using System;

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
            try
            {
                var fact = await _catFactService.GetCatFactAsync();
                await _fileWriter.AppendFactAsync("cat_facts.txt", fact);
                Console.WriteLine($"Saved fact: {fact.Fact} (length: {fact.Length})");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}