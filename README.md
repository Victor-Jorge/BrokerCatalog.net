# BrokerCatalogDotNet

## Overview

BrokerCatalogDotNet is a simple web application developed in .NET 9.0 that functions as a broker catalog. The project uses the ASP.NET Core framework for the backend (API) and a minimalist frontend interface in HTML, CSS, and JavaScript to consume and display data.

The main functionality is the exposure of an `/brokers` endpoint that returns a list of brokers, which is then loaded and displayed dynamically on the home page.

## Installation

To run this project locally, you will need to have the .NET 9.0 SDK installed on your machine.

### Preconditions

*   [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

### Instalations steps

1.  **Clone the repository:**
    ```bash
    git clone [[URL_DO_SEU_REPOSITORIO]](https://github.com/Victor-Jorge/BrokerCatalog.net.git)
    cd BrokerCatalogDotNet
    ```

2.  **Execute the aplication:**
    Navigate to the project's root directory (where the `BrokerCatalogDotNet.csproj` file is located) and run the command:
    ```bash
    dotnet run
    ```

3.  **Acess the aplication:**
    The application will start and be accessible at `http://localhost:xxxx`(HTTPS), as configured by ASP.NET Core.

## Usage

After launching the application, follow the steps below:

1.  Open your browser and go to the local address (ex: `http://localhost:5287`).
2.  The home page (`index.html`) will load.
3. Click on the **“Load list”** button.
4. The JavaScript script (`script.js`) will make a request to the `/brokers` endpoint of the backend.
5. The list of brokers (Company Name, City, and CNPJ) will be dynamically displayed on the screen.

## Code description

The project is structured in two main parts: the *Backend* in C# (.NET) and the *Frontend* in standard web technologies.

### Backend (C# / .NET 9.0)

| File | Description |
| :--- | :--- |
| `BrokerCatalogDotNet.csproj` | Defines the project as an ASP.NET Core web application, using the *target framework* `net9.0`. |
| `Program.cs` |**Application entry point.** Configures the ASP.NET Core HTTP pipeline. It is responsible for: <ul><li>Configuring the web server. </li><li>Defining the `/brokers` endpoint that returns broker data in JSON format. </li></ul> |
| `appsettings.json` | Default ASP.NET Core configuration file, defining logging settings and allowed hosts. |
**Endpoint Strucutr `/corretoras`:**

The endpoint is configured to return a list of JSON objects. Each object represents a broker and contains the fields `nome_social`, `municipio` and `cnpj`.

### Frontend (HTML, CSS, JavaScript)

| File | Description |
| :--- | :--- |
| `index.html` | The application's main page. Contains the basic structure, title, **“Load list”** button, and the `<ul>` element with the ID `Brokerlist` where the list of brokers will be injected. |
| `script.js` | Contains the interaction logic. The `loadList()` function uses the `fetch` API to retrieve data from the `/brokers` endpoint and manipulates the DOM to create and display the list of brokers on the page. |
| `style.css` | Style file for the page layout, including the formatting of the list of brokers and the header. |

---
