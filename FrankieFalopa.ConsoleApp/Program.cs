using System;
using System.Dynamic;
using System.Reflection;

namespace FrankieFalopa.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Pija Carl = new Pija();
            try
            {
                Console.WriteLine("Ingrese la marca de viagra: ");
                string Marca = Console.ReadLine();
                Console.WriteLine("Seleccione la cantidad de píldoras: ");
                Console.WriteLine("A. 1 píldora.");
                Console.WriteLine("B. 3 píldora.");
                Console.WriteLine("C. 5 píldora.");
                string Opcion = Console.ReadLine().ToLower().Replace(" ", "");
                int Cantidad;
                switch (Opcion)
                {
                    case "a": Cantidad = 1; break;
                    case "b": Cantidad = 3; break;
                    case "c": Cantidad = 5; break;
                    default: throw new ArgumentOutOfRangeException("Opción inválida.");
                }
                Carl.Erectarse(Marca, Cantidad);
                Console.WriteLine($"Tamaño: {Carl.Tamanio}.");
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}.");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Estímulo inválido: {ex.Message}");
            }
            catch(FormatException)
            {
                Console.WriteLine("¡Un número te dije, bobólico! Rajá de acá.");
            }
        }
    }
}
