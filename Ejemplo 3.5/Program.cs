namespace Ejemplo35
{
    public class Program
    {
        public static void Main()
        {
            int ma = 0;
            int me = 0;
            int num = 0; 
            int numeros = 3;

            for (int i = 1; i <= numeros; i++)
            {
                Console.WriteLine("Digite un numero");
                num = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    ma = num;
                    me = num;
                }
                if (num > ma) { ma = num; }
                if (num < me) { me = num; }

                num = 0;
            }
            Console.WriteLine("El numero mayor es: " + ma);
            Console.WriteLine("El numero menor es: " + me);
        }
    }
}

