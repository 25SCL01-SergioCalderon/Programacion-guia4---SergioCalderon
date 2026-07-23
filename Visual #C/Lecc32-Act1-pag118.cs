internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;

        
        Console.WriteLine("Ingrese el numero de la lista:");
        Console.WriteLine("1. Joaquin Menocal: 3456-9023");
        Console.WriteLine("2. Jose Portillo: 5479-0899");
        Console.WriteLine("3. Javier Lobos: 1983-0138");
        Console.WriteLine("4. Francisco Gil: 1278-2511");
        Console.WriteLine("5. Diego Chocochic: 8078-1739");
        Console.WriteLine("6. Marco Alvarado: 6720-8197");
        Console.WriteLine("7. Juan Pablo: 7179-3871");
        Console.WriteLine("8. Oscar Flores: 9011-4781");
        Console.WriteLine("9. Pedro Figueroa: 0812-1200");
        Console.WriteLine("10. Daniel Azmithia: 1000-0000");
        Console.Write("Seleccione un numero: ");

        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Actor profesional");
                break;
            case 2:
                Console.WriteLine("Marimbista de concierto");
                break;
            case 3:
                Console.WriteLine("Jugador de voleyball");
                break;
            case 4:
                Console.WriteLine("Bajista de banda");
                break;
            case 5:
                Console.WriteLine("Programador de confianza");
                break;
            case 6:
                Console.WriteLine("Contador de la familia");
                break;
            case 7:
                Console.WriteLine("Mecanico del centro");
                break;
            case 8:
                Console.WriteLine("Florista de la colonia"); 
                break;
            case 9:
                Console.WriteLine("Doctor del corazon");
                break;
            case 10:
                Console.WriteLine("Veterinario del perro");
                break;
            default:
                Console.WriteLine("No se encuentra ese numero");
                break;
        }
    }
}