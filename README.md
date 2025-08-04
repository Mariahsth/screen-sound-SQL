# 🎵 ScreenSound 3.0

Um aplicativo no Swagger em C# para cadastro, gerenciamento e exibição de artistas, músicas e gêneros, com API REST e persistência de dados em banco de dados SQL Server utilizando o **Entity Framework Core**.
<p align="center">
  <img width="800" src="https://github.com/user-attachments/assets/debc9e1c-8d0c-4fc3-877b-7af9a4c8ba56" alt="Tela do Swagger da API ScreenSound" />
</p>

---

## 📚 Tecnologias Utilizadas

- ✅ .NET 8.0
- ✅ C#
- ✅ Entity Framework Core 7
- ✅ SQL Server (LocalDB)
- ✅ Swagger UI
- ✅ Visual Studio / VS Code  

---

## 💡 Funcionalidades

- ✅ Registrar, listar, atualizar e deletar artistas associados aos conjuntos de músicas cadastradas
- ✅ Registrar, listar, atualizar e deletar músicas associadas a artistas e gêneros musicais
- ✅ Registrar, listar e deletar gêneros musicais associados a músicas cadastradas
- ✅ Listar artistas por nome
- ✅ Listar músicas de um artista específico  
- ✅ Listar músicas por ano de lançamento  

---

## 🧱 Estrutura do Projeto
```bash
ScreenSound/
│
├── Menus/ # Menus interativos que executam ações
├── Program.cs # Ponto de entrada da aplicação do console


ScreenSound.API/
│
├── Properties/ #  Arquivos de configuração do projeto gerados automaticamente (.NET)
├── Endpoints/ # Define os endpoints da API (rotas e handlers)
├── Pages/ # Pasta gerada automaticamente
├── Requests/ # Modelos que representam os dados recebidos nas requisições (DTOs de entrada)
├── Response/ # Modelos utilizados para retornar dados ao cliente (DTOs de saída)
├── Program.cs # Ponto de entrada da aplicação da API (configuração do app e serviços)

ScreenSound.Shared.Data/
│
├── Banco/ # Contexto EF e classe DAL genérica
├── Migrations/ # Arquivos de migração gerados pelo EF

ScreenSound.Shared.Modelos/
│
├── Modelos/ # Classes de entidade (Artista, Musica, Genero etc.)

```


---

## ⚙️ Requisitos

#### 💻 Ambiente de Desenvolvimento
- .NET 8 SDK
- SQL Server Express ou LocalDB (recomendado para desenvolvimento local)
- Um editor de código como Visual Studio 2022+ (com suporte a .NET 8 e ferramentas EF Core) ou Visual Studio Code
  
### 📦 Pacotes NuGet Utilizados

#### 📚 Entity Framework Core
- Microsoft.EntityFrameworkCore.SqlServer 7.0.9
- Microsoft.EntityFrameworkCore.Design 7.0.13
- Microsoft.EntityFrameworkCore.Tools 7.0.13
- Microsoft.EntityFrameworkCore.Proxies 7.0.14 (para lazy loading)

#### 🔗 Conexão com SQL Server
- Microsoft.Data.SqlClient 5.1.0

#### 📘 Swagger/OpenAPI
- Microsoft.AspNetCore.OpenApi 8.0.0
- Swashbuckle.AspNetCore 6.5.0
- Swashbuckle.AspNetCore.Swagger 6.5.0
- Swashbuckle.AspNetCore.SwaggerUI 6.5.0

### 🔌 Outras Dependências
- Lazy Loading habilitado via UseLazyLoadingProxies() no DbContext
- Estrutura Modular - O projeto é dividido em múltiplos projetos C# (.csproj):
  - 📂**ScreenSound.Shared.Data**: Camada de dados e acesso ao banco (EF Core)
  - 📂**ScreenSound.Shared.Modelos**: Contém os modelos de domínio (entidades)

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

## ⚠️ Possíveis Problemas
- Conflito de versões entre SqlClient e EntityFrameworkCore
- Verifique se o recurso Data Storage and Processing está instalado no Visual Studio
- Certifique-se de que o LocalDB está instalado e funcionando (sqllocaldb info no terminal)

## 📁 Licença
Projeto desenvolvido para fins educacionais com base em curso de C# e Entity Framework Core.
