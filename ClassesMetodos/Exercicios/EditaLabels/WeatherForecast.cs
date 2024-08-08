using System.Text.Json;

namespace EditaLabels;

public class WeatherForecast
{
  private readonly HttpClient _httpClient;
  private readonly JsonSerializerOptions _jsonOptions;

  public DateOnly Date { get; set; }

  public int TemperatureC { get; set; }

  public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

  public string? Summary { get; set; }


  public WeatherForecast(HttpClient httpClient)
  {
    this._httpClient = httpClient;
    _jsonOptions = new()
    {
      PropertyNameCaseInsensitive = true,
      PropertyNamingPolicy = new LowerCaseNamingPolicy()
    };
  }

  public async void EditaLabels()
  {
    try
    {
      _httpClient.DefaultRequestHeaders.Add("PRIVATE-TOKEN", "glpat-ArLz4sesw5o37FPfv4mh");
      List<ProjectResponse> Projects = new() { };

      for (int i = 1; i <= 4; i++)
      {

        HttpResponseMessage httpReturn = await _httpClient.GetAsync($"http://10.1.50.15/api/v4/projects?page={i}&per_page=100");

        string response = await httpReturn.Content.ReadAsStringAsync();

        Projects.AddRange(JsonSerializer.Deserialize<List<ProjectResponse>>(response, _jsonOptions));
      }

      Projects.ForEach(async project =>
      {

        HttpResponseMessage httpResponse = await _httpClient.GetAsync($"http://10.1.50.15/api/v4//projects/{project.Id}/labels?search=Feature");


        httpResponse = await _httpClient.PutAsJsonAsync($"http://10.1.50.15/api/v4//projects/:id/labels/:label_id", new object());

      });



    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }

  }


}
