namespace Ejemplo312
{
    public class Program
    {
        public static void Main()
        {
            int citas;
            double vtratamiento;

            Console.WriteLine("Ingrese el numero de citas");
            citas = Convert.ToInt32(Console.ReadLine());

            if (citas <= 3)
            {
                vtratamiento = (citas * 200000);
                Console.WriteLine("El valor de la cita es de 200.000");
                Console.WriteLine("El gasto del tratamiento es: " + vtratamiento);
            }
            if (citas >= 4 && citas <= 5)
            {
                vtratamiento = (citas * 150000) + 600000;
                Console.WriteLine("El valor de la cita es de 150.000");
                Console.WriteLine("El gasto del tratamiento es: " + vtratamiento);
            }
            if (citas >= 6 && citas <= 8)
            {
                vtratamiento = (citas * 100000) + 900000;
                Console.WriteLine("El valor de la cita es de 100.000");
                Console.WriteLine("El gasto del tratamiento es: " + vtratamiento);
            }
            if (citas > 8)
            {
                vtratamiento = (citas * 50000) + 1200000;
                Console.WriteLine("El valor de la cita es de 50.000");
                Console.WriteLine("El gasto del tratamiento es: " + vtratamiento);
            }

        }
    }
}
