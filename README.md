# SocialConnect API

API de rede social desenvolvida com ASP.NET Core e Entity Framework Core.

## Sobre o projeto

A SocialConnect API é uma aplicação backend que simula os principais recursos de uma rede social, permitindo gerenciamento de usuários, publicações, comentários, curtidas e seguidores.

O projeto foi desenvolvido para praticar conceitos de desenvolvimento de APIs REST utilizando ASP.NET Core, Entity Framework Core e SQL Server.

## Tecnologias utilizadas

- ASP.NET Core
- Entity Framework Core
- SQL Server
- Swagger/OpenAPI
- C#
- REST API

## Funcionalidades

### Usuários

- Criar usuário
- Listar usuários
- Buscar usuário por ID
- Atualizar usuário
- Remover usuário

### Publicações

- Criar publicação
- Listar publicações
- Buscar publicação por ID
- Atualizar publicação
- Remover publicação

### Comentários

- Criar comentário
- Listar comentários
- Atualizar comentário
- Remover comentário

### Curtidas

- Curtir publicação
- Remover curtida
- Consultar curtidas

### Seguidores

- Seguir usuário
- Deixar de seguir usuário
- Consultar seguidores

### Estrutura do Projeto

- Controllers
- Services
- DTOs
- Models
- Data (DbContext)
- Migrations

## Como executar

1. Clone o repositório
2. Configure a string de conexão no arquivo appsettings.json
3. Execute as migrations:
dotnet ef database update

4. Execute a aplicação:
dotnet run

Acesse o Swagger:
https://localhost:xxxx/swagger

##Autor

Kauan da Silva

Projeto desenvolvido para fins de estudo e construção de portfólio.

