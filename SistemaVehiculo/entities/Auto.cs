public class Auto : Vehiculo
{
    public Auto(string marca, string modelo, int año) : base(marca, modelo, año)
    { 
    }

    public override void Acelerar(double cantidad)
    {
        velocidadActual += cantidad;
        Console.WriteLine("El auto está acelerando......");
    }

    public override void Frenar(double cantidad)
    {
        velocidadActual = velocidadActual - cantidad;
        Console.WriteLine("El auto está frenando......");
    }
}