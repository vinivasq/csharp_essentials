string datateste = "2024-07-15 11:11";

Teste teste = new()
{
  Data = datateste
};


class Teste
{
  public string DataString { get; set; } = string.Empty;
  public DateTime Data { get { return Data; } set { Convert.ToDateTime(value); } }
}