namespace ejemplo36
//ejemplo3.6
{
    class langosta
    {
        static void Main()
        {
            double costoplato, numeropersonas, presupuesto;
            Console.Write("Ingresa el valor de numero de personas: ");
            numeropersonas = double.Parse(Console.ReadLine());
            costoplato = 95000;
            if (numeropersonas > 200 && numeropersonas <= 300)
                costoplato = 85000;
            if (numeropersonas > 300)
                costoplato = 75000;
            presupuesto = costoplato * numeropersonas;
            Console.WriteLine("Valor de costo del platillo: " + costoplato);
            Console.WriteLine("Valor de presupuesto: " + presupuesto);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}

