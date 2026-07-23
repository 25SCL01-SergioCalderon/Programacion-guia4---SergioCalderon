internal class Program
{
    private static void Main(string[] args)
    {
        int u, c;
        string jn;
        Random aleatorio = new Random();

        do
        {
            Console.Clear(); 
            Console.WriteLine("Elige una opcion:");
            Console.WriteLine("1. Piedra");
            Console.WriteLine("2. Papel");
            Console.WriteLine("3. Tijeras");
            Console.Write("Tu eleccion: ");
            u = Convert.ToInt32(Console.ReadLine());

            while (u < 1 || u > 3)
            {
                Console.Write("Opcion invalida. Elige 1, 2 o 3: ");
                u = Convert.ToInt32(Console.ReadLine());
            }

            c = aleatorio.Next(1, 4);

            if (c == 1)
            {
                Console.WriteLine("La computadora eligio: Piedra");
            }
            else if (c == 2)
            {
                Console.WriteLine("La computadora eligio: Papel");
            }
            else
            {
                Console.WriteLine("La computadora eligio: Tijeras");
            }

            if (u == c)
            {
                Console.WriteLine("¡Es un empate!");
            }
            else if ((u == 1 && c == 3) || (u == 2 && c == 1) || (u == 3 && c == 2))
            {
                Console.WriteLine("¡Ganaste tu! Felicidades.");
            }
            else
            {
                Console.WriteLine("¡Gano la computadora! Suerte para la proxima.");
            }

            Console.WriteLine();
            Console.Write("¿Quieres jugar de nuevo? (S/N): ");
            jn = Console.ReadLine();

        } while (jn != "N" && jn != "n");

        Console.WriteLine("\n¡Gracias por jugar! Hasta la proxima.");
    }
}