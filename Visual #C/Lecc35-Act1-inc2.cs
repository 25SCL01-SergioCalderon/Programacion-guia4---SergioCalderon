internal class Program
{
    private static void Main(string[] args)
    {
        double p, pa, c;
        int b200, b100, b50, b20, residuo;

        Console.Write("Ingrese el precio del producto: Q");
        p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el billete con el que pago el cliente: Q");
        pa = Convert.ToDouble(Console.ReadLine());

        if (pa < p)
        {
            Console.WriteLine("EL dinero es insuficiente para la compra");
        }
        else
        {
            c = pa - p;
            Console.WriteLine($"\nEl cambio total es de: Q{c}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Desglose del Cambio:");

            int cambioEntero = Convert.ToInt32(Math.Truncate(c));
            double cambioRestante = (c - cambioEntero);

            b200 = cambioEntero / 200;
            residuo = cambioEntero % 200; 

            b100 = residuo / 100;
            residuo = residuo % 100;

            b50 = residuo / 50;
            residuo = residuo % 50;

            b20 = residuo / 20;
            residuo = residuo % 20;

            double totalRestante = residuo + cambioRestante;

            if (b200 > 0)
            {
                Console.WriteLine($"Billetes de 200: {b200}");
            }
            if (b100 > 0)
            {
                Console.WriteLine($"Billetes de 100: {b100}");
            }
            if (b50 > 0)
            {
                Console.WriteLine($"Billetes de 50: {b50}");
            }
            if (b20 > 0)
            {
                Console.WriteLine($"Billetes de 20: {b20}");
            }
            if (totalRestante > 0)
            {
                Console.WriteLine($"El cambio restante (monedas) es de: Q{totalRestante:F2}");
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}