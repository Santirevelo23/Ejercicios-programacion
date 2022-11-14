namespace Ejemplo41
{
    public class Program
    {
        public static int Main()
        {
            int i;
            float num, sum;
            i = 1;
            sum = 0;
            while (i <= 10)
            {
                Console.WriteLine("Ingresa un numero");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
                i++;
            }
            Console.WriteLine($"La suma de los 10 numeros es de {sum}");
            return 0;
        }
    }
}
