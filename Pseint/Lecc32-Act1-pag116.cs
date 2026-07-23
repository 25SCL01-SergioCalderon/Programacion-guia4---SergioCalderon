internal class Program
{
    private static void Main(string[] args)
    {
        double m, r;
        int op;

        Console.Write("Ingrese la cantidad de metros: ");
        // Convertimos la entrada de texto a un número decimal (double)
        m = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Seleccione una opcion:");
        Console.WriteLine("1. milimetros");
        Console.WriteLine("2. centimetros");
        Console.WriteLine("3. decimetros");
        Console.WriteLine("4. hectometros");
        Console.WriteLine("5. kilometros");
        Console.Write("Opcion: ");

        op = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(); 

        switch (op)
        {
            case 1:
                r = m * 1000;
                Console.WriteLine($"{r} milimetros");
                break;
            case 2:
                r = m * 100;
                Console.WriteLine($"{r} centimetros");
                break;
            case 3:
                r = m * 10;
                Console.WriteLine($"{r} decimetros");
                break;
            case 4:
                r = m / 100;
                Console.WriteLine($"{r} hectometros");
                break;
            case 5:
                r = m / 1000;
                Console.WriteLine($"{r} kilometros");
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }

        
    }
}