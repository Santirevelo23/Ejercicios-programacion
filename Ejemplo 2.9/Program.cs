namespace Ejemplo29
{
    public class Program
    {
        public static void Main()
        {
            int Nh, Vh, Sd, Ss;
            int semana = 7;

            Console.WriteLine("Ingrese las horas que trabajo");
            Nh = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la hora");
            Vh = int.Parse(Console.ReadLine());

            Sd = Nh * Vh;
            Ss = Sd * semana;

            Console.WriteLine($"El sueldo semanal es {Ss}");
        }
    }
}