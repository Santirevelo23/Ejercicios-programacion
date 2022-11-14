namespace Ejemplo34
{
    public class Program
    {
        public static void Main()
        {
            double precio;
            double descuento1;
            double descuento2;

            Console.WriteLine("Digite el precio del traje");
            precio = Convert.ToDouble(Console.ReadLine());

            if (precio > 2500)
            {
                descuento1 = precio - (precio * 15/100);
                Console.WriteLine($"El precio final con descuento del 15% es: {descuento1}");
            }
            else
            {
                descuento2 = precio - (precio * 8/100);
                Console.WriteLine($"El precio final con descuento del 8% es: {descuento2}");
            }
        }
    }
}

