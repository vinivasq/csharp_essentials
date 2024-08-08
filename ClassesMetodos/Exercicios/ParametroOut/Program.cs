
Console.WriteLine("Digite um valor a ser calculado");

int potencia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O resultado da potência é {CalculaPotenciaVelocidade(potencia, out double velocidade)} e a velociade é: {velocidade}");

double CalculaPotenciaVelocidade(int potencia, out double velocidade)
{
  double resultado = potencia * potencia;

  velocidade = resultado * 1.75;

  return resultado;
}