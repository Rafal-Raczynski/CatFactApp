// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using CatFactApp;
using CatFactApp.Utils;
using CatFactApp.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Http;

var host = Host.CreateDefaultBuilder()
    .ConfigureServices(services =>
    {
        services.AddHttpClient<ICatFactService, CatFactService>();
        services.AddTransient<IFileWriter, FileWriter>();
        services.AddTransient<App>();
    })
    .Build();

await host.Services.GetRequiredService<App>().RunAsync();
