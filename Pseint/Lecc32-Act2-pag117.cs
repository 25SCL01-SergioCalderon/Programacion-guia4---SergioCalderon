internal class Program
{
    private static void Main(string[] args)
    {
        int m, d;

        Console.Write("Ingrese su mes de nacimiento: ");
        m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese su dia de nacimiento: ");
        d = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(); // Espacio en blanco

        // Estructura de control condicional (Si / SiNo Si)
        if ((m == 3 && d >= 21) || (m == 4 && d <= 19))
        {
            Console.WriteLine("Su signo es Aries");
            Console.WriteLine("Su horoscopo es de que va a ser Millonario");
        }
        else if ((m == 4 && d >= 20) || (m == 5 && d <= 20))
        {
            Console.WriteLine("Su signo es Tauro");
            Console.WriteLine("Su horoscopo es de que va a ser Reconocido");
        }
        else if ((m == 5 && d >= 21) || (m == 6 && d <= 20))
        {
            Console.WriteLine("Su signo es Geminis");
            Console.WriteLine("Su horoscopo es de que va a ser Medico");
        }
        else if ((m == 6 && d >= 21) || (m == 7 && d <= 22))
        {
            Console.WriteLine("Su signo es Cancer");
            Console.WriteLine("Su horoscopo es de que va a ser Famoso");
        }
        else if ((m == 7 && d >= 23) || (m == 8 && d <= 22))
        {
            Console.WriteLine("Su signo es Leo");
            Console.WriteLine("Su horoscopo es de que va a ser Narcicista");
        }
        else if ((m == 8 && d >= 23) || (m == 9 && d <= 22))
        {
            Console.WriteLine("Su signo es Virgo");
            Console.WriteLine("Su horoscopo es de que va a ser Humilde");
        }
        else if ((m == 9 && d >= 23) || (m == 10 && d <= 22))
        {
            Console.WriteLine("Su signo es Libra");
            Console.WriteLine("Su horoscopo es de que va a ser Musico");
        }
        else if ((m == 10 && d >= 23) || (m == 11 && d <= 21))
        {
            Console.WriteLine("Su signo es Escorpio");
            Console.WriteLine("Su horoscopo es de que va a ser Romantico");
        }
        else if ((m == 11 && d >= 22) || (m == 12 && d <= 21))
        {
            Console.WriteLine("Su signo es Sagitario");
            Console.WriteLine("Su horoscopo es de que va a ser Cocinero");
        }
        else if ((m == 12 && d >= 22) || (m == 1 && d <= 19))
        {
            Console.WriteLine("Su signo es Capricornio");
            Console.WriteLine("Su horoscopo es de que va a ser Actor");
        }
        else if ((m == 1 && d >= 20) || (m == 2 && d <= 18))
        {
            Console.WriteLine("Su signo es Acuario");
            Console.WriteLine("Su horoscopo es de que va a ser Mecanico");
        }
        else if ((m == 2 && d >= 19) || (m == 3 && d <= 20))
        {
            Console.WriteLine("Su signo es Piscis");
            Console.WriteLine("Su horoscopo es de que va a ser Noticiero");
        }
        else
        {
            Console.WriteLine("Signo no registrado");
        }

        // Pausa para mantener abierta la consola al finalizar
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
