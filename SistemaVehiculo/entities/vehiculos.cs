public abstract class Vehiculo
{
    private string Marca;
    private string Modelo;
    private int Año;

    public Vehiculo(string marca, string modelo, int año)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Año = año;
    }

    public string marca { get => Marca; set => Marca = value; }
    public string modelo { get => Modelo; set => Modelo = value; }
    public int año { get => Año; set => Año = value; }




    public abstract void Acelerar();
    public abstract void Frenar();

    public void MostrarEstado()
        {
            Console.WriteLine($"Vehículo: {Marca} {Modelo} ({Año})");
        }
}