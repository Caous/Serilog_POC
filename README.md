
![SERILOG](https://user-images.githubusercontent.com/38294660/191805936-6db05147-7198-45a2-a8a3-554832001e5b.png)


### <h2>Fala Dev, seja muito bem-vindo,
   Está POC é para mostrar como podemos implementar o Serilog em diversos projetos com injeção de dependência, também te explico oque é o Serilog espero que encontre oque procura  <img src="https://media.giphy.com/media/WUlplcMpOCEmTGBtBW/giphy.gif" width="30"> 
</em></p></h5>
  
  </br>
  


<img align="right" src="https://cdn.buttercms.com/Ngn0ZIvrQBSjuFz2EqKN" width="200" height="200"/>


</br></br>

### <h2>Serilog <a href="https://serilog.net/" target="_blank"><img alt="Serilog" src="https://img.shields.io/badge/Serilog-v2.11.0-blue?style=flat&logo=google-chrome"></a>

 <a href="https://serilog.net/" target="_blank">Serilog</a> é um framework muito forte por permitir que seus usuários que o utilizarem, possam fazer gerenciamento do Log em suas aplicações, seja uma aplicação Web API, Web, Console ou até mesmo um Library Class, permite gravação de Log do sistema como um todo, a utilizam da Framework Serilog permite integração com diversos sistemas C# e também podendo armazenar esses log em banco de dados, ferramentas analíticas e afins.

</br></br>

### <h2>[Cenário de Uso]
Agora vamos imaginar o seguinte cenário, você precisa configurar o Serilog apenas para uma aplicação, mas então depois disto precisa monitorar o log de diversas aplicações, ao invés de fazer diversas configurações para Log,  por que não criar um Base? Que possa ser implementado via injeção de dependência ou até mesmo uma instância simples de Log. É exatamente isso que estou prestes a te mostrar para isso precisara instalar alguns caras.

### <h2> Depêndencia
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
