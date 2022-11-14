namespace Ejemplo210
{
    public class Program
    {
        public static void Main()
        {
            double metros, pulgadas, telafinal;
            Console.WriteLine("Escriba los metros que necesita de tela");
            metros = double.Parse(Console.ReadLine());

            pulgadas = metros / 0.0254;

            Console.WriteLine($"La cantidad de tela que necesita en pulgadas es de: {pulgadas}");


        }
    }
}