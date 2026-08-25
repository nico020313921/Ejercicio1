using System;
using SolucionCapas.Negocio;

public class Program
{
    public static void Main()
    {
        Console.Write("Ingrese código del producto: ");
        string codigo = Console.ReadLine();

        ProductoNegocio negocio = new ProductoNegocio();

        Producto producto = negocio.ObtenerProducto(codigo);

        if (producto != null)
        {
            Console.WriteLine($"Producto: {producto.Nombre}");
            Console.WriteLine($"Precio: ${producto.Precio}");
        }
        else
        {
            if (string.IsNullOrEmpty(codigo))
            {
                Console.WriteLine("Error: el código no puede estar vacío.");
            }
            else if (!codigo.StartsWith("PROD-"))
            {
                Console.WriteLine("Error: el código debe comenzar con PROD-.");
            }
            else
            {
                Console.WriteLine("No existe un producto con ese código.");
            }
        }
    }
}