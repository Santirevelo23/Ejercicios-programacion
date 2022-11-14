namespace Ejemplo32
{

    public class Program
    {

        public static void Main()
        {
 
            Console.WriteLine("Ingrese un numero");

            int numero = int.Parse(Console.ReadLine());
            if (numero == 0)
            {

                Console.WriteLine("El numero " + numero + " es un numero neutro");

            }
            else if (numero > 0)
            {
                Console.WriteLine("El numero " + numero + " es positivo");
            }
            else
            {
                Console.WriteLine("El numero " + numero + " es negativo");
            }
        }

    }
}