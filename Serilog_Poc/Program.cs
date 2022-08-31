using Serilog;
using SerilogBase;
using SerilogBase.Infraestructure.Configuration;
using SerilogBase.Infraestructure.Interface;
using SerilogBase.Infraestructure.Service;

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    //IConfigurationRoot configuration = IConfigurationEnvironment();

    //ConfigurationLog(configuration);


    builder.Host.UseSerilog(LogBaseConfig.ConfigurationLogBase());

    builder.Services.AddControllers();

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddSingleton(sp => sp.GetRequiredService<ILoggerFactory>().CreateLogger("DefaultLogger"));

    builder.Services.AddBMGLogger();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Erro ao compilar aplicação");
}
finally
{
    Log.Information("Encerrando aplicação");
    Log.CloseAndFlush();
}

IConfigurationRoot IConfigurationEnvironment()
{
    return new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json")
        .Build();
}

void ConfigurationLog(IConfigurationRoot configuration)
{
    Log.Logger = new LoggerConfiguration()          
            .ReadFrom.Configuration(configuration)
            .CreateLogger();
}