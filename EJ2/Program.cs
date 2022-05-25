Console.WriteLine(" === CALCULADORA === \n");

int Solicitud = 0, Numero1 = 0, Numero2 = 0;

do
{
    do
    {
        Console.WriteLine("  [1] Suma\n  [2] Resta\n  [3] Multiplicacion\n  [4]Dividir\n  [5] Salir\n");
        Console.WriteLine("\nEscriba que operacion desea realizar: ");
        Solicitud = Convert.ToInt32(Console.ReadLine());

    } while (Solicitud<=0 || Solicitud>5);

     if (Solicitud != 5)
    {
        do
        {
            Console.WriteLine("\nEscriba Numero 1: ");
            Numero1 = Convert.ToInt32(Console.ReadLine());

        } while (Numero1<-100 || Numero1>100); 

        do
        {
            Console.WriteLine("\nEscriba Numero 2: ");
            Numero2 = Convert.ToInt32(Console.ReadLine());

        } while (Numero2<-100 || Numero2>100); 
    }

    switch (Solicitud)
    {
        case 1:
            int Suma = Numero1 + Numero2;
            Console.WriteLine("\nSuma: "+Suma);
            break;

        case 2:
            int Resta = Numero1 - Numero2;
            Console.WriteLine("\nResta: "+Resta);
            break;

        case 3:
            int Multiplicacion = Numero1 * Numero2;
            Console.WriteLine("\nMultiplicacion: "+Multiplicacion);
            break;

        case 4:
            if (Numero2!=0)
            {
                int Division = Numero1/Numero2;
                Console.WriteLine("\nDivision: "+Division);

            } else 
            {
                Console.WriteLine("\nError, no se puede dividir en 0...");
            }
            break;

    }


} while (Solicitud!=5);