namespace Ejemplo31
{
    public class Program
    {
        public static void Main()
        {
            int num1;
            int num2;

            Console.WriteLine("Digite el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());


            if (num1 > num2)
            {
                Console.WriteLine($"El numero mayor es: {num1}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"El numero mayor es: {num2}");
            }
        }
    }
}

