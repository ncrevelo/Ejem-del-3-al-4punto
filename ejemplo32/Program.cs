namespace ejemplo32
{
    //ejemplo3.2
    class program
    {

        static void Main(String[] args)
        {

            //determinar si el valor de un numero es positivo o negativo 
            Console.WriteLine("ingrese un numero");
            int numero = int.Parse(Console.ReadLine());
            if (numero == 0)
            {

                Console.WriteLine("el numero" + numero + "es un numero neutro");


            }
            else if (numero > 0)
            {
                Console.WriteLine("el numero" + numero + "es un numero positivo");
            }
            else
            {
                Console.WriteLine("el numero" + numero + "es un numero negativo");
            }
            Console.ReadKey();
        }


    }
}

