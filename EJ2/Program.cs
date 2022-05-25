// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(" === CALCULADORA === \n");


float Solicitud = 0, Numero1 = 0, Numero2 = 0;

do
{
    do
    {
        Console.WriteLine("  [1] Suma\n  [2] Resta\n  [3] Multiplicacion\n  [4]Dividir\n  [5]Valor Absoluto\n  [6]Cuadrado\n  [7]Raiz Cuadrada\n  [8]Seno\n  [9]Coseno\n  [10]Entero de un Float\n  [11]Maximo\n  [12]Minimo\n  [13]Salir");
        Console.WriteLine("\nEscriba que operacion desea realizar: ");
        Solicitud = Convert.ToInt32(Console.ReadLine());

    } while (Solicitud<=0 || Solicitud>13);

    if (Solicitud != 13)
    {
        do
        {
            Console.WriteLine("\nEscriba Numero 1: ");
            Numero1 = Convert.ToInt32(Console.ReadLine());

        } while (Numero1<-100 || Numero1>100); 

        if (Solicitud<5 || Solicitud>10)
        {
            do
            {
                Console.WriteLine("\nEscriba Numero 2: ");
                Numero2 = Convert.ToInt32(Console.ReadLine());

            } while (Numero2<-100 || Numero2>100); 
        }

    }

    switch (Solicitud)
    {
        case 1:
            float Suma = Numero1 + Numero2;
            Console.WriteLine("\nSuma: \n"+Suma);
            break;

        case 2:
            float Resta = Numero1 - Numero2;
            Console.WriteLine("\nResta: \n"+Resta);
            break;

        case 3:
            float Multiplicacion = Numero1 * Numero2;
            Console.WriteLine("\nMultiplicacion: \n"+Multiplicacion);
            break;

        case 4:
            if (Numero2!=0)
            {
                float Division = Numero1/Numero2;
                Console.WriteLine("\nDivision: \n"+Division);

            } else 
            {
                Console.WriteLine("\nError, no se puede dividir en 0...");
            }
            break;

        case 5:
            Console.WriteLine("\nAbsoluto: \n"+Math.Abs(Numero1));
            break;

        case 6:
            Console.WriteLine("\nCuadrado: \n"+Math.Pow(Numero1, 2));
            break;

        case 7:
            Console.WriteLine("\nRaiz Cuadrada: \n"+Math.Sqrt(Numero1));
            break;

        case 8:
            Console.WriteLine("\nSeno: \n"+Math.Sin(Numero1));
            break;

        case 9:
            Console.WriteLine("\nCoseno: \n"+Math.Sin(Numero1));
            break;

        case 10:
            Console.WriteLine("\nEntero: \n"+Math.Truncate(Numero1));
            break;

        case 11:
            Console.WriteLine("\nMaximo: \n"+Math.Max(Numero1, Numero2));
            break;

        case 12:
            Console.WriteLine("\nMinimo: \n"+Math.Min(Numero1, Numero2));
            break;
    }


} while (Solicitud!=13);