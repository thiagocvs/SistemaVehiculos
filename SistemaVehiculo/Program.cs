using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("------------------SISTEMA DE VEHÍCULOS------------------");
            Console.WriteLine("1. Agregar Vehiculo");
            Console.WriteLine("2. Mostrar Vehículos");
            Console.WriteLine("3. Simular Aceleración y Frenado");
            Console.WriteLine("4. Salir");

            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    AñadirVehiculo(vehiculos);
                    break;
                case 2:
                    MostrarVehiculos(vehiculos);
                    break;
                case 3:
                    SimularAccion(vehiculos);
                    break;
                case 4:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

    }

    static void AñadirVehiculo(List<Vehiculo> vehiculos)
    {
        Console.WriteLine("Ingrese el tipo de vehículo (Auto/Moto):");
        string tipo = Console.ReadLine();

        if (tipo.ToLower() == "auto" )
        {
             Console.WriteLine("Ingrese la marca del vehículo:");
            string marca = Console.ReadLine();

            Console.WriteLine("Ingrese el modelo del vehículo:");
            string modelo = Console.ReadLine();

            Console.WriteLine("Ingrese el año del vehículo:");
            int año = int.Parse(Console.ReadLine());

            vehiculos.Add(new Auto(marca, modelo, año));
            Console.WriteLine("Auto agregado exitosamente.");
        }else if (tipo.ToLower() == "moto")
        {
            Console.WriteLine("Ingrese la marca del vehículo:");
            string marca = Console.ReadLine();

            Console.WriteLine("Ingrese el modelo del vehículo:");
            string modelo = Console.ReadLine();

            Console.WriteLine("Ingrese el año del vehículo:");
            int año = int.Parse(Console.ReadLine());
            vehiculos.Add(new Moto(marca, modelo, año));
            Console.WriteLine("Moto agregada exitosamente.");
        }else
        {
            Console.WriteLine("Tipo de vehículo no válido. Por favor, ingrese 'Auto' o 'Moto'.");
        }

    }

    static void MostrarVehiculos(List<Vehiculo> vehiculos)
    {
        if (vehiculos.Count == 0)
        {
            Console.WriteLine("No hay vehículos registrados.");
            return;
        }

        Console.WriteLine("-------------------LISTA DE VEHÍCULOS------------------");
        foreach (var vehiculo in vehiculos)
        {
            vehiculo.MostrarEstado();
        }
    }

    static void SimularAccion(List<Vehiculo> vehiculos)
    {
        Console.WriteLine("-------------------LISTA DE VEHÍCULOS------------------");
        for (int i = 0; i < vehiculos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {vehiculos[i].marca} {vehiculos[i].modelo} ({vehiculos[i].año})");
        }
        Vehiculo vehiculoSeleccionado = null;
        Console.WriteLine("Ingrese el número del vehículo para simular acción:");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 1 && numero <= vehiculos.Count)
        {
            vehiculoSeleccionado = vehiculos[numero - 1];
        }
        else
        {
            Console.WriteLine("Número de vehículo no válido. Intente nuevamente.");
        }
        Console.WriteLine("¿Desea acelerar o frenar? (Acelerar/Frenar)");
        string accion = Console.ReadLine();
        if (accion.ToLower() == "acelerar")
        {
            Console.Write("Ingrese la cantidad a acelerar (km/h): ");
            double cantidadAcelerar = double.Parse(Console.ReadLine());
            vehiculoSeleccionado.Acelerar(cantidadAcelerar);
        }
        else if (accion.ToLower() == "frenar")
        {
            Console.Write("Ingrese la cantidad a frenar (km/h): ");
            double cantidadFrenar = double.Parse(Console.ReadLine());
            vehiculoSeleccionado.Frenar(cantidadFrenar);
        }
        else
        {
            Console.WriteLine("Acción no válida. Por favor, ingrese 'Acelerar' o 'Frenar'.");
        }

    }
}