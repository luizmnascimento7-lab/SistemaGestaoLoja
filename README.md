# SistemaGestaoLoja

# 🏬 SistemaGestaoLoja

Sistema desenvolvido em **ASP.NET Core MVC** utilizando a linguagem **C#** e o padrão arquitetural **Model-View-Controller (MVC)**.

O projeto tem como objetivo demonstrar a implementação de um sistema CRUD (Create, Read, Update e Delete) para gerenciamento de dados de uma loja, contemplando o relacionamento entre múltiplas entidades (Categorias, Produtos, Clientes, Pedidos e Itens de Pedido), utilizando boas práticas de desenvolvimento, persistência de dados com Entity Framework Core e interface simples e funcional com Bootstrap.

---

## 📋 Tecnologias Utilizadas

- C#
- .NET 8
- ASP.NET Core MVC
- SQL Server
- Entity Framework Core
- Bootstrap 5

---

## 📦 Pacotes Utilizados

O projeto utiliza os seguintes pacotes do Entity Framework Core:

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.Design
- Microsoft.VisualStudio.Web.CodeGeneration.Design

---

## 🗄 Banco de Dados

O banco de dados foi desenvolvido utilizando o **SQL Server**.

A criação da estrutura do banco foi realizada através da abordagem **Code First**, utilizando **Migrations** do Entity Framework Core.

### Entidades e Relacionamentos

- **Categoria** → possui vários **Produtos** (1:N)
- **Cliente** → possui vários **Pedidos** (1:N)
- **Pedido** → possui vários **Itens de Pedido** (1:N)
- **Produto** → pode estar em vários **Itens de Pedido** (1:N)
- **ItemPedido** → tabela associativa entre **Pedido** e **Produto** (N:N)

---

## 🚀 Funcionalidades

- Cadastro de Categorias
- Cadastro de Produtos (vinculados a uma Categoria)
- Cadastro de Clientes
- Cadastro de Pedidos (vinculados a um Cliente)
- Cadastro de Itens de Pedido (vinculando Pedidos e Produtos)
- Alteração de registros
- Exclusão de registros
- Consulta de dados
- Interface simples e intuitiva

---

## 🎨 Interface

A interface foi desenvolvida utilizando:

- Bootstrap
- Razor Views
- Tela inicial com atalhos diretos para cada módulo do sistema

---

# ▶️ Como Executar o Projeto

## Clone o repositório

```bash
git clone https://github.com/SEU-USUARIO/SistemaGestaoLoja.git
```

## Abra a solução

Abra o projeto utilizando o **Visual Studio 2022**.

## Configure a conexão

Edite o arquivo:

```
appsettings.json
```

Configurando a string de conexão para o seu SQL Server.

## Execute as Migrations

No Console do Gerenciador de Pacotes execute:

```powershell
Update-Database
```

Ou utilize o .NET CLI:

```bash
dotnet ef database update
```

## Execute o projeto

Pressione **F5** ou clique em **Iniciar** no Visual Studio.

---

# 📂 Estrutura do Projeto

```
SistemaGestaoLoja
│
├── Controllers
├── Models
├── Views
├── Migrations
├── wwwroot
└── Program.cs
```

---

# 💻 Desenvolvido com

- ASP.NET Core MVC
- C#
- SQL Server
- Entity Framework Core
- Bootstrap

---

# 👨‍💻 Autores

### Desenvolvedor

**Luiz Miguel**

### Professor

**Wallace Oliveira dos Santos**
