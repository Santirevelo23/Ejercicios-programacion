namespace Ejemplo37
{
    public class Program
    {
        public static void Main()
        {
            double precioBase;
            int tamaño;
            double precioInicial;


            Console.WriteLine("Ingrese el precio base por kilo de uva");
            precioBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo (A o B) ");
            var tipo = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese el tamaño (1 o 2) ");
            tamaño = Convert.ToInt32(Console.ReadLine());



            if (tipo == "a" && tamaño == 1 || tipo == "A" && tamaño == 1)
            {
                precioInicial = (precioBase + 0.20);
                Console.WriteLine($"El precio inicial por kilo de uva es de: {precioInicial}");

            }
            else if (tipo == "a" && tamaño == 2 || tipo == "A" && tamaño == 2)
            {
                precioInicial = (precioBase + 0.30);
                Console.WriteLine($"El precio inicial por kilo de uva es de: {precioInicial}");
            }
            if (tipo == "b" && tamaño == 1 || tipo == "B" && tamaño == 1)
            {
                precioInicial = (precioBase - 0.30);
                Console.WriteLine($"El precio inicial por kilo de uva es de: {precioInicial}");
            }
            else if (tipo == "b" && tamaño == 2 || tipo == "B" && tamaño == 2)
            {
                precioInicial = (precioBase - 0.50);
                Console.WriteLine($"El precio inicial por kilo de uva es de: {precioInicial}");
            }
        }
    }
}

