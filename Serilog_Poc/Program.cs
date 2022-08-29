using Serilog;
using Serilog.Events;
using Serilog.Filters;

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    IConfigurationRoot configuration = IConfigurationEnvironment();

    ConfigurationLog(configuration);

    builder.Host.UseSerilog(Log.Logger);

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
    Log.Logger = new LoggerConfiguration()
            //.MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Information)
            //.Enrich.FromLogContext()
            .Enrich.WithProperty("ApplicationName", $"API Serilog - {Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}")
            //.Filter.ByExcluding(Matching.FromSource("Microsoft.AspNetCore.StaticFiles"))
            //.Filter.ByExcluding(z => z.MessageTemplate.Text.Contains("Business error"))
            //.WriteTo.Async(wt => wt.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj} {Properties:j}{NewLine}{Exception}"))
            .ReadFrom.Configuration(configuration)
            .CreateLogger();
}