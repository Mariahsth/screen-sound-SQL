# 🎵 ScreenSound 3.0

Um aplicativo de console em C# para cadastro, gerenciamento e exibição de artistas e músicas, com persistência de dados em banco de dados SQL Server utilizando o **Entity Framework Core**.

---

## 📚 Tecnologias Utilizadas

- ✅ .NET 6.0
- ✅ C#
- ✅ Entity Framework Core 7
- ✅ SQL Server (LocalDB)  
- ✅ Visual Studio / VS Code  

---

## 💡 Funcionalidades

- ✅ Registrar artistas  
- ✅ Registrar músicas associadas a artistas  
- ✅ Listar todos os artistas cadastrados  
- ✅ Listar músicas de um artista específico  
- ✅ Listar músicas por ano de lançamento  

---

## 🧱 Estrutura do Projeto
```bash
ScreenSound/
│
├── Modelos/ # Classes de entidade (Artista, Musica etc.)
├── Banco/ # Contexto EF e classe DAL genérica
├── Menus/ # Menus interativos que executam ações
├── Migrations/ # Arquivos de migração gerados pelo EF
├── Program.cs # Ponto de entrada da aplicação
└── ScreenSound.csproj
```


---

## ⚙️ Requisitos

- .NET 6 SDK  
- SQL Server Express ou LocalDB  
- Entity Framework Core (via NuGet)  

---

## 🧪 Como Executar

```bash
# Restaura os pacotes NuGet
dotnet restore

# Aplica as migrações para criar o banco de dados
dotnet ef database update

# Executa o projeto
dotnet run
```
## 🗃️ Exemplo de Menu no Console

Boas vindas ao Screen Sound 3.0!
```text
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
```


Digite 1 para registrar um artista  
Digite 2 para registrar a música de um artista  
Digite 3 para mostrar todos os artistas  
Digite 4 para exibir todas as músicas de um artista  
Digite 5 para exibir todas as músicas por ano de lançamento  
Digite -1 para sair  

## 📦 Pacotes Instalados (via NuGet)
- Microsoft.Data.SqlClient (v5.1.0)
- Microsoft.EntityFrameworkCore.SqlServer (v7.0.9)
- Microsoft.EntityFrameworkCore.Design (v7.0.13)
- Microsoft.EntityFrameworkCore.Tools (v7.0.13)
- Microsoft.EntityFrameworkCore.Proxies (v7.0.14)

## ⚠️ Possíveis Problemas
- Conflito de versões entre SqlClient e EntityFrameworkCore
- Verifique se o recurso Data Storage and Processing está instalado no Visual Studio
- Certifique-se de que o LocalDB está instalado e funcionando (sqllocaldb info no terminal)

## 📁 Licença
Projeto desenvolvido para fins educacionais com base em curso de C# e Entity Framework Core.
