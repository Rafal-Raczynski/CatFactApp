using CatFactApp;
using CatFactApp.Utils;
using CatFactApp.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder()
    .ConfigureServices(services =>
    {
        services.AddHttpClient<ICatFactService, CatFactService>();
        services.AddTransient<IFileWriter, FileWriter>();
        services.AddTransient<App>();
    })
    .Build();

await host.Services.GetRequiredService<App>().RunAsync();