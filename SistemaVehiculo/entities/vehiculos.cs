public abstract class Vehiculo
{
    private string Marca;
    private string Modelo;
    private int Año;
    private double VelocidadActual;

    public Vehiculo(string marca, string modelo, int año)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Año = año;
        this.VelocidadActual = 0;
    }

    public string marca { get => Marca; set => Marca = value; }
    public string modelo { get => Modelo; set => Modelo = value; }
    public int año { get => Año; set => Año = value; }
    public double velocidadActual { get => VelocidadActual; set => VelocidadActual = value; }



    public abstract void Acelerar(double cantidad);
    public abstract void Frenar(double cantidad);

    public void MostrarEstado()
    {
        Console.WriteLine($"Vehículo: {Marca} {Modelo} ({Año})");
        Console.WriteLine($"Velocidad Actual: {VelocidadActual}");
    }
}