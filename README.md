# BrokerCatalogDotNet

## Visão Geral do Projeto

O **BrokerCatalogDotNet** é uma aplicação web simples desenvolvida em **.NET 9.0** que funciona como um catálogo de corretoras. O projeto utiliza o framework ASP.NET Core para o *backend* (API) e uma interface *frontend* minimalista em HTML, CSS e JavaScript para consumir e exibir os dados.

A funcionalidade principal é a exposição de um *endpoint* `/corretoras` que retorna uma lista de corretoras, que é então carregada e exibida dinamicamente na página inicial.

## Instalação

Para executar este projeto localmente, você precisará ter o SDK do .NET 9.0 instalado em sua máquina.

### Pré-requisitos

*   [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

### Passos para Instalação

1.  **Clone o repositório:**
    ```bash
    git clone [URL_DO_SEU_REPOSITORIO]
    cd BrokerCatalogDotNet
    ```

2.  **Execute a aplicação:**
    Navegue até o diretório raiz do projeto (onde está o arquivo `BrokerCatalogDotNet.csproj`) e execute o comando:
    ```bash
    dotnet run
    ```

3.  **Acesse a aplicação:**
    A aplicação será iniciada e estará acessível em `http://localhost:5000` ou `http://localhost:5001` (HTTPS), conforme configurado pelo ASP.NET Core.

## Uso

Após iniciar a aplicação, siga os passos abaixo:

1.  Abra seu navegador e acesse o endereço local (ex: `http://localhost:5000`).
2.  A página inicial (`index.html`) será carregada.
3.  Clique no botão **"Carregar lista"**.
4.  O *script* JavaScript (`script.js`) fará uma requisição ao *endpoint* `/corretoras` do *backend*.
5.  A lista de corretoras (Nome Social, Município e CNPJ) será exibida dinamicamente na tela.

## Descrição do Código

O projeto é estruturado em duas partes principais: o *Backend* em C# (.NET) e o *Frontend* em tecnologias web padrão.

### Backend (C# / .NET 9.0)

| Arquivo | Descrição |
| :--- | :--- |
| `BrokerCatalogDotNet.csproj` | Define o projeto como uma aplicação web ASP.NET Core, utilizando o *target framework* `net9.0`. |
| `Program.cs` | **Ponto de entrada da aplicação.** Configura o *pipeline* HTTP do ASP.NET Core. É responsável por: <ul><li>Configurar o servidor web.</li><li>Servir arquivos estáticos (HTML, CSS, JS) da pasta `wwwroot`.</li><li>Definir o *endpoint* `/corretoras` que retorna os dados das corretoras em formato JSON.</li></ul> |
| `appsettings.json` | Arquivo de configuração padrão do ASP.NET Core, definindo configurações de *logging* e *hosts* permitidos. |

**Estrutura do Endpoint `/corretoras`:**

O *endpoint* é configurado para retornar uma lista de objetos JSON. Cada objeto representa uma corretora e contém os campos `nome_social`, `municipio` e `cnpj`.

### Frontend (HTML, CSS, JavaScript)

| Arquivo | Descrição |
| :--- | :--- |
| `index.html` | A página principal da aplicação. Contém a estrutura básica, o título, o botão **"Carregar lista"** e o elemento `<ul>` com o ID `Brokerlist` onde a lista de corretoras será injetada. |
| `script.js` | Contém a lógica de interação. A função `carregarLista()` utiliza a API `fetch` para buscar os dados do *endpoint* `/corretoras` e manipula o DOM para criar e exibir a lista de corretoras na página. |
| `style.css` | Arquivo de estilos para o layout da página, incluindo a formatação da lista de corretoras e do cabeçalho. |

---
