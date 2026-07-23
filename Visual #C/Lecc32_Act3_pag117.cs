using System;

class Triangulo
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Clasificador de Triángulos ===\n");

        // Solicitar las medidas de los tres lados
        Console.Write("Ingresa la medida del lado 1: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la medida del lado 2: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la medida del lado 3: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        // Validar que los lados formen un triángulo válido
        if (lado1 + lado2 <= lado3 || lado1 + lado3 <= lado2 || lado2 + lado3 <= lado1)
        {
            Console.WriteLine("\nEstas medidas no forman un triángulo válido.");
        }
        else
        {
            Console.WriteLine("\nResultado: Se trata de un triángulo " + ClasificarTriangulo(lado1, lado2, lado3));
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }

    static string ClasificarTriangulo(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "equilátero.";
        }
        else if (a == b || b == c || a == c)
        {
            return "isósceles.";
        }
        else
        {
            return "escaleno.";
        }
    }
}
