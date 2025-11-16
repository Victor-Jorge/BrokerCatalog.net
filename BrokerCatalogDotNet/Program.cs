using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//permite servir arquivos estáticos da pasta wwwroot
app.UseDefaultFiles();
app.UseStaticFiles();

// Endpoint /corretoras chamado pelo HTML
app.MapGet("/corretoras", async () =>
{

    var httpClient = new HttpClient();

    // Faz a requisição GET para o endpoint da API externa
    var url = "https://brasilapi.com.br/api/cvm/corretoras/v1";
    var reponse = await httpClient.GetAsync(url);
    var json = await reponse.Content.ReadAsStringAsync();


    // Desserializa o JSON recebido em uma lista de objetos Broker
    var corretoras = JsonSerializer.Deserialize<List<Broker>>(json);

    // Retorna a lista de corretoras como JSON
    return corretoras;
});

app.Run();

// Classe usada para representar a corretora
public class Broker
{
    public string cnpj { get; set; }
    public string nome_social { get; set; }
    public string municipio { get; set; }
}

