# alo-mundo-dotnet
Uma simples aplicação bancária em C#, desenvolvida no linux, com dotnet core 3.1.

Vídeos tutoriais utilizados como referência:
- [C# 101](https://www.youtube.com/playlist?list=PLdo4fOcmZ0oVxKLQCHpiUWun7vlJJvUiN)
- [.NET Core 101](https://www.youtube.com/playlist?list=PLdo4fOcmZ0oWoazjhXQzBKMrFuArxpW80)


# Lista de comandos utilizados
- Cria um arquivo de solução: `dotnet new sln -n meuAppDotNET`
- Cria uma biblioteca de códigos: `dotnet new classlib -o BibliotecaCoisasBancarias`
- Cria uma aplicação console: `dotnet new console -o aplicacaoBancaria`
- Adiciona no projeto da aplicação, a dependência da biblioteca anterior: `dotnet add aplicacaoBancaria.csproj reference ../BibliotecaCoisasBancarias/BibliotecaCoisasBancarias.csproj`
- Adiciona o projeto da aplicação ao arquivo de solução: `dotnet sln meuAppDotNET add ./aplicacaoBancaria/aplicacaoBancaria.csproj`
- Adiciona o projeto da biblioteca ao arquivo de solução: `dotnet sln meuAppDotNET add ./BibliotecaCoisasBancarias/BibliotecaCoisasBancarias.csproj`
- Adiciona uma dependência a um pacote chamado Humanizer no projeto da biblioteca: `dotnet add BibliotecaCoisasBancarias.csproj package Humanizer.Core.pt --version 2.8.26`
- Executa a aplicação console: `dotnet run`
- Cria um projeto xUnit: `dotnet new xunit -o TestesBancarios`
- Adiciona o projeto xUnit à solução: `dotnet sln meuAppDotNET.sln add TestesBancarios/TestesBancarios.csproj`
- Executa o teste especificado: `dotnet test`
