namespace Ejercicio23
{
    public class Program
    {
        public static void Main()
        {
            int numero;
            int resultado;
            int doble;

            Console.WriteLine("Ingrese un número");
            numero = Convert.ToInt32(Console.ReadLine());
            doble = numero * 2;
            resultado = doble * 25;
            Console.WriteLine($"El resultado es: {resultado}");
        }
    }
}