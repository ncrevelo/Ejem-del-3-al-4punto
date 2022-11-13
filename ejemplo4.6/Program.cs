namespace Ejemplo46
    //ejemplo4.6
{
    internal class program
    {
        static void Main()
        {
            double cantidad;
            double cantiAño = 0;
            double ahorromes;

            for (int i = 1; i < 13; i++)
            {

                Console.WriteLine("Proceso " + i);
                Console.WriteLine("Digite el valor a depositar");

                cantidad = double.Parse(Console.ReadLine());
                cantiAño = cantiAño + cantidad;
                ahorromes = cantiAño;

                Console.WriteLine("El valor de la cantidad del mes es de " + ahorromes);
            }
            Console.WriteLine("El ahorro de un año es de" + cantiAño);
        }
    }
}
