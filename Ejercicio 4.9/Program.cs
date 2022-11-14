namespace Ejercicio49
{
    public class Program
    {
        public static void Main()
        {
            int num1;
            int num2;
            int result;
            string SoR;

            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite s para sumar o digite r para restar");
            SoR = Console.ReadLine();

            switch (SoR)
            {
                case "s":
                    result = num1 + num2;
                    Console.WriteLine($"El resultado es: {result}");
                    break;

                case "r":
                    result = num1 - num2;
                    Console.WriteLine($"El resultado es: {result}");
                    break;

                default:
                    Console.WriteLine("No selecciono suma o resta");
                    break;
            }
        }
    }
}