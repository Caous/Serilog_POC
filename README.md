
![SERILOG](https://user-images.githubusercontent.com/38294660/191805936-6db05147-7198-45a2-a8a3-554832001e5b.png)


### <h2>Fala Dev, seja muito bem-vindo
   Está POC é para mostrar como podemos implementar o Serilog em diversos projetos com injeção de dependência, também te explico oque é o Serilog e como usar em diversas ocasiões. Espero que encontre oque procura  <img src="https://media.giphy.com/media/WUlplcMpOCEmTGBtBW/giphy.gif" width="30"> 
</em></p></h5>
  
  </br>
  


<img align="right" src="https://cdn.buttercms.com/Ngn0ZIvrQBSjuFz2EqKN" width="200" height="200"/>


</br></br>

### <h2>Serilog <a href="https://serilog.net/" target="_blank"><img alt="Serilog" src="https://img.shields.io/badge/Serilog-v2.11.0-blue?style=flat&logo=google-chrome"></a>

 <a href="https://serilog.net/" target="_blank">Serilog</a> é um framework muito forte por permitir que seus usuários que o utilizarem, possam fazer gerenciamento do Log em suas aplicações, seja uma aplicação Web API, Web, Console ou até mesmo um Library Class. Permite gravação de Log do sistema como um todo, a utilizam da Framework Serilog permite integração com diversos sistemas .Net e também podendo armazenar esses log em banco de dados, ferramentas analíticas, e-mails e afins.

Legal né? Mas agora a pergunta é como posso usar o Serilog abaixo dou um exemplo de caso de uso.

</br></br>

### <h2>[Cenário de Uso]
Agora vamos imaginar o seguinte cenário, você precisa configurar o Serilog apenas para uma aplicação, mas então depois disto precisa monitorar o log de diversas aplicações, ao invés de fazer diversas configurações para Log, por que não criar um Base? Que possa ser implementado via injeção de dependência ou até mesmo uma instância simples de objeto. É exatamente isso que estou prestes a te mostrar para isso precisara instalar alguns caras.

### <h2> Dependência
Instalação do Serilog e para sua configuração e utilização ao máximo vamos instalar outros frameworks que possam ajudar a monitorar.

Biblioteca principal do Serilog
```C#
dotnet add package Serilog.AspNetCore
```
Enrichers são para monitoramento da aplicação (servidor) etc...

```C#
dotnet add package Serilog.Enrichers.Environment
dotnet add package Serilog.Enrichers.Process
dotnet add package Serilog.Enrichers.Thread
```

Configurações do Serilog
```C#
dotnet add package Serilog.Expressions
dotnet add package Serilog.Settings.Configuration
dotnet add package Serilog.Sinks.Async
```

### <h2> Criação de Classes

Classe de configuração base, permito você ter dois jeitos de criar sua configuração do Serilog
```C#
 public static class LogBaseConfig
    {

        public static ILogger ConfigurationLogBase()
        {
            return Log.Logger = new LoggerConfiguration()
           .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Information)
           .Enrich.FromLogContext()
           .Enrich.WithProperty("ApplicationName", $"API Serilog")
           .Filter.ByExcluding(Matching.FromSource("Microsoft.AspNetCore.StaticFiles"))
           .Filter.ByExcluding(z => z.MessageTemplate.Text.Contains("Business error"))
           //.WriteTo.Async(wt => wt.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj} {Properties:j}{NewLine}{Exception}"))
           .WriteTo.File(@"C:\\LogApplication\log-.txt", outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj} {Properties:j}{NewLine}{Exception}", rollingInterval: RollingInterval.Day)
           .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj} {Properties:j}{NewLine}{Exception}")
           .CreateLogger();

        }

        public static ILogger ConfigurationLogBaseJson(IConfiguration configuration)
        {
            return Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .CreateLogger();
        }
    }
```

Agora vamos criar sua interface com as configurações que você desejar e fazer sua injeção de dependência
```C#
public interface ILogBase 
    {
        LogBase CreateModel(string nameSystem, LogLevel levelLog, string errorMensagem);

        void WriteLog(LogBase log);
    }
```
</br>

```C#
public class LogBaseService : ILogBase
    {
        private Serilog.ILogger _logger;

        public LogBaseService()
        {
            _logger = LogBaseConfig.ConfigurationLogBase();
            
        }

        //public LogBaseService(IConfiguration configuration)
        //{
        //    _logger = LogBaseConfig.ConfigurationLogBaseJson(configuration);
        //}

        public LogBase CreateModel(string nameSystem, LogLevel levelLog, string errorMensagem)
        {
            return new LogBase() { NameSystem = nameSystem, LevelInformation = levelLog, ErrorMensagem = errorMensagem };
        }

        public void WriteLog(LogBase log)
        {
            
            switch (log.LevelInformation)
            {
                case LogLevel.Information:
                    _logger.Information(log.ErrorMensagem);
                    break;
                case LogLevel.Warning:
                    _logger.Warning(log.ErrorMensagem);
                    break;
            }            

        }
    }
```

E por ultimo vamos criar uma classe extension para caso desejar implementar D.I

```C#
   public static class LogBaseExtension
    {
        public static void AddLogBaseLogger(this IServiceCollection services) {
            services.AddScoped<ILogBase, LogBaseService>();
        }
    }
```


### <h5> [IDE Utilizada]</h5>
![VisualStudio](https://img.shields.io/badge/Visual_Studio_2019-000000?style=for-the-badge&logo=visual%20studio&logoColor=purple)

### <h5> [Linguagem Programação Utilizada]</h5>
![C#](https://img.shields.io/badge/C%23-000000?style=for-the-badge&logo=c-sharp&logoColor=purple)



### <h5> [Web 🌐 - Utilizado]</h5>
![HTML5](https://img.shields.io/badge/-HTML5-000000?style=for-the-badge&logo=HTML5)
![CSS3](https://img.shields.io/badge/-CSS3-000000?style=for-the-badge&logo=CSS3)
![JavaScript](https://img.shields.io/badge/-JavaScript-000000?style=for-the-badge&logo=javascript)





### <h5> [Versionamento de projeto] </h5>
![Github](http://img.shields.io/badge/-Github-000000?style=for-the-badge&logo=Github&logoColor=green)

</br></br></br></br>


<p align="center">
  <i>🤝🏻 Vamos nos conectar!</i>

  <p align="center">
    <a href="https://www.linkedin.com/in/gusta-nascimento/" alt="Linkedin"><img src="https://github.com/nitish-awasthi/nitish-awasthi/blob/master/174857.png" height="30" width="30"></a>
    <a href="https://www.instagram.com/gusta.nascimento/" alt="Instagram"><img src="https://github.com/nitish-awasthi/nitish-awasthi/blob/master/instagram-logo-png-transparent-background-hd-3.png" height="30" width="30"></a>
    <a href="mailto:caous.g@gmail.com" alt="E-mail"><img src="https://github.com/nitish-awasthi/nitish-awasthi/blob/master/gmail-512.webp" height="30" width="30"></a>   
  </p>
