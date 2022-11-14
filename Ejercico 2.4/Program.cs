namespace Ejercico24
{
    public class Program
    {
        public static void Main()
        {
            int num1;
            int num2;
            int num3;
            int num4;

            int suma, producto;
            double media;

            Console.WriteLine("Ingresa el primer número");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer número");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el cuarto número");
            num4 = int.Parse(Console.ReadLine());

            producto = num1 * num2 * num3 * num4;
            suma = num1 + num2 + num3 + num4;
            media = suma / 4;

            Console.WriteLine($"El resultado de la suma es {suma}");
            Console.WriteLine($"El resultado del producto es {producto}");
            Console.WriteLine($"El resultado de la media es {media}");
        }
    }
}