public class Moto : Vehiculo
{
    public Moto(string marca, string modelo, int año) : base(marca, modelo, año)
    {
    }

    public override void Acelerar(double cantidad)
    {
        Console.WriteLine("La moto está acelerando.");
    }

    public override void Frenar(double cantidad)
    {
        Console.WriteLine("La moto está frenando.");
    }
    
}