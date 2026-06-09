public class Moto : Vehiculo
{
    public Moto(string marca, string modelo, int año) : base(marca, modelo, año)
    {
    }

    public override void Acelerar()
    {
        Console.WriteLine("La moto está acelerando.");
    }

    public override void Frenar()
    {
        Console.WriteLine("La moto está frenando.");
    }
    
}