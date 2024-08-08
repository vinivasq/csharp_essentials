var car1 = new Car("Onix", "Chevrolet", 2023, 105);
var car2 = new Car("Ecosport", "Ford", 1998, 112);

car1.Accelerate();
car2.Accelerate();

Console.WriteLine($"{car1.Model}, {car1.Manufactorer}, {car1.Year}, {car1.Power}");
Console.WriteLine($"{car2.Model}, {car2.Manufactorer}, {car2.Year}, {car2.Power}");

car1.GetMaxSpeed();
car2.GetMaxSpeed();

car1.ShowInfo(manufactorer: car1.Manufactorer, model: car1.Model);
car2.ShowInfo(manufactorer: car2.Manufactorer, model: car2.Model, year: car2.Year);

Console.ReadLine();

class Car
{
  public Car(string model, string manufactorer, int year, int power)
  {
    this.Model = model;
    this.Manufactorer = manufactorer;
    this.Year = year;
    this.Power = power;
  }

  public string Model { get; set; }
  public string Manufactorer { get; set; }
  private int _year { get; set; }
  public int Year
  {
    get { return this._year; }
    set
    {
      if (value < 2000) this._year = 2000;
      else if (value > 2022) this._year = 2022;
    }
  }
  public int Power { get; set; }

  public void Accelerate()
  {
    Console.WriteLine($"Acelerando meu {this.Manufactorer}");
  }

  double MaxSpeed(Car car)
  {
    double maxSpeed = car.Power * 1.75;

    return maxSpeed;
  }

  public void GetMaxSpeed() //ilustrando o uso de this como parâmetro na chamada de metodos dentro da classe.
  {
    Console.WriteLine($"A velocidade máxima do carro {this.Model} é {MaxSpeed(this)}");
  }

  public void ShowInfo(string model, string manufactorer, int year = 0)
  {
    Console.WriteLine($"Modelo: {model}");
    Console.WriteLine($"Fabricante: {manufactorer}");
    if (year > 0) Console.WriteLine($"Ano: {year}");
  }

}