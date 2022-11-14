namespace Ejemplo36
{
    public class Program
    {
        public static void Main()
        {
            double costoplato, numeropersonas, presupuesto;

            Console.Write("Ingrese el numero de personas");
            numeropersonas = double.Parse(Console.ReadLine());

            costoplato = 95000;
            if (numeropersonas > 200 && numeropersonas <= 300)
                costoplato = 85000;
            if (numeropersonas > 300)
                costoplato = 75000;

            presupuesto = costoplato * numeropersonas;

            Console.WriteLine($"Valor de costo del platillo: {costoplato}");
            Console.WriteLine($"Presupúesto que se debe tener: {presupuesto}");

        }
    }
}

