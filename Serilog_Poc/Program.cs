using Serilog;
using SerilogBase;
using SerilogBase.Infraestructure.Configuration;
using SerilogBase.Model;

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    #region Config Serilog Json

    //IConfigurationRoot configuration = IConfigurationEnvironment();

    //ConfigurationLog(configuration);

    #endregion

    var _enviroment = new LogBaseModel("Teste","dev","url",40);

    builder.Host.UseSerilog(LogBaseConfig.ConfigurationLogBase(_enviroment));

    builder.Services.AddLogBaseLogger(_enviroment);

    builder.Services.AddControllers();

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();


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
    Log.Logger = LogBaseConfig.ConfigurationLogBaseJson(configuration);
}