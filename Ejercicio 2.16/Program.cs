namespace Ejercicio216
{
    public class Program
    {
        public static void Main()
        {
            int sumatotia = 0;
            int contador = 1;
            int limite = 10;

            for (contador = 1; contador<= limite; contador++)
            {
                sumatotia = sumatotia + contador;
                Console.WriteLine($"El resultado es: {sumatotia}");
            }

        }
    }
}