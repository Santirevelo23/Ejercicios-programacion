namespace Ejemplo27
{
    public class Program
    {
        public static void Main()
        {

            double LPG = 3.785;
            double LV, PG, CG, W;

            Console.WriteLine("Ingrese los litros que va a vender");
            LV = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del galon");
            PG = double.Parse(Console.ReadLine());

            CG = LV / LPG;
            W = CG * PG;

            Console.WriteLine($"El valor de la venta es {W}");
            Console.WriteLine($"La cantidad de galones es {CG}");
        }
    }
}