internal class Program
{
    private static void Main(string[] args)
    {
        double cL, d, e, yen, pM, pA;
        string r;

        double td = 0.13;
        double te = 0.11;
        double tyen = 21.16;
        double tpM = 2.29;
        double tpA = 193.56;

        do
        {
            Console.Clear(); 

            Console.WriteLine("<<<Convertidor de Monedas>>>");
            Console.Write("Ingrese la cantidad de moneda: ");
            cL = Convert.ToDouble(Console.ReadLine());

            d = cL * td;
            e = cL * te;
            yen = cL * tyen;
            pM = cL * tpM;
            pA = cL * tpA;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"El equivalente en dolares es de: {d}");
            Console.WriteLine($"El equivalente en euros es de: {e}");
            Console.WriteLine($"El equivalente en yenes es de: {yen}");
            Console.WriteLine($"El equivalente en pesos mexicanos es de: {pM}");
            Console.WriteLine($"El equivalente en pesos argentinos es de: {pA}");
            Console.WriteLine("---------------------------------------");

            Console.Write("¿Desea hacer otra conversion? (S/N): ");
            r = Console.ReadLine();

        } while (r != "N" && r != "n");

        Console.WriteLine("\nPrograma finalizado. ¡Hasta luego!");
    }
}