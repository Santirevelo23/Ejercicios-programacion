namespace Ejemplo44
{
    public class Program
    {
        public static void Main()
        {
            int edad = 0;
            int suma = 0;
            int total;
            int promedio = 0;

            Console.WriteLine("Digite el total de alumnos");
            total = int.Parse(Console.ReadLine());
            for (int i = 1; i <= total; i++)
            {
                Console.WriteLine("Digite su edad ({0})", i);
                edad = int.Parse(Console.ReadLine());

                suma = suma + edad;
                i = i + 0;
                promedio = suma / total;
            }
            Console.WriteLine($"El promedio de edades de todo el grupo es: {promedio}");

        }
    }
}
