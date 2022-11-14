namespace Ejercicio47
{
    public class Program
    {
        public static void Main()
        {
            int num1;
            int num2;

            Console.WriteLine("Ingrese el numero mayor");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero menor");
            num2 = int.Parse(Console.ReadLine());

            if (num1 % num2 == 0)
            {
                Console.WriteLine(num2 + " es divisor de " + num1);
            }
            else
            {
                Console.WriteLine(num2 + " no es divisor de " + num1);
            }
        }
    }
}