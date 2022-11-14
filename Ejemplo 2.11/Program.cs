namespace Ejemplo211
{
    public class Program
    {
        public static void Main()
        {
            double Pago, Metrosp, Ladoa, Ladob, Ladoc, preciomc, preciototal;

            Console.WriteLine("Digite el ancho de la alberca");
            Ladoa = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el largo de la alberca");
            Ladob= double.Parse(Console.ReadLine());

            Console.WriteLine("Digite la altura de la alberca");
            Ladoc= double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el precio del agua que se necesita para llenar la alberca ( metro cuadrado )");
            preciomc = double.Parse(Console.ReadLine());

            Metrosp = Ladoa * Ladob * Ladoc;
            preciototal = Metrosp * preciomc;

            Console.WriteLine($"La cantidad de agua necesaria es: {Metrosp} m3");
            Console.WriteLine($"El precio total a pagar es de: {preciototal}");
        }
    }
}
