namespace ejemplo31
    //ejemolo3.1
{
    public class ejemplo31
    {
        public static void Main()
        {
            int Num1;
            int Num2;
            

            Console.WriteLine("Digite dos numeros y le diremos cual de los dos numero es el mayor");

            Console.WriteLine("Digite el primer numero");
            Num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite el segundo numero");
            Num2 = Convert.ToInt32(Console.ReadLine());


            if (Num1 > Num2)
            {
                Console.WriteLine($"El numero mayor es* :{Num1}");
            }
            else if (Num2 > Num1)
            {
                Console.WriteLine($"El numero mayor es:{Num2}");
            }



        }
    }
}



