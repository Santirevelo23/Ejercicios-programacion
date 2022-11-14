namespace Ejercicio35
{
    public class Program
    {
        public static void Main()
        {
            double precio, unidades;
            double porcentajeIva = 12, porcentajeDescuento = 5;
            double limiteParaDescuento = 50000;
            double valorFactura = 0;
            double precioBruto = 0;
            double subtotal = 0;
            double valorDelDescuento = 0;

            Console.WriteLine("Por favor ingrese el precio");
            precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor ingrese las unidades a facturar");
            unidades = Convert.ToDouble(Console.ReadLine());

            subtotal = (unidades * precio);
            precioBruto = (subtotal * (porcentajeIva / 100)) + subtotal;

            if (precioBruto > limiteParaDescuento)
            {
                valorDelDescuento = precioBruto * (porcentajeDescuento/ 100);
                precioBruto = precioBruto - valorDelDescuento;
            }
            Console.WriteLine($"El total a pagar es: {precioBruto}");
        }
    }
}