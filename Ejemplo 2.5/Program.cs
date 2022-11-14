namespace Ejemplo25
{
    public class Program
    {
        public static void Main()
        {
            decimal a, b, c, at, ar, ato;

            Console.WriteLine("Ingrese la longitud de A");
            a = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Infrese la longitud de B");
            b = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud de C");
            c = decimal.Parse(Console.ReadLine());

            ar = b * c;
            at = ((a - c) * b) / 2;
            ato = ar + at;

            Console.WriteLine($"El area total del lote es {ato}");
        }
    }
}
