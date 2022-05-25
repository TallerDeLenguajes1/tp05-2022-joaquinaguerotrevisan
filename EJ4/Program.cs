Console.WriteLine(" === TEXTO TAREAS === \n");

string Cadena1 = "", Cadena2 = "", Cadena3 = "", Cadena4 = "";
char Letra1;

do
{
    Console.WriteLine(" [1] Escriba una cadena de texto: ");
    Cadena1 = Console.ReadLine();

} while (Cadena1.Length <= 0 || Cadena1.Length >= 30);

// OBTENER ALGUNAS LETRAS QUE FORMAN PARTE DE UNA CADENA =========================
Random GeneradorNumeros = new Random();
Console.WriteLine("\nCaracteres aleatoreos:");

for (int i = Cadena1.Length; i > 0; i--)
{
    Console.WriteLine(" ["+Cadena1[GeneradorNumeros.Next(Cadena1.Length)]+"]");
}

// OBTENER LONGITUD DE CADENA ====================================================
Console.WriteLine("\nLongitud de cadena: "+Cadena1.Length);

// UNIR DOS CADEANAS =============================================================
do
{
    Console.WriteLine(" [2] Escriba una cadena de texto: ");
    Cadena2 = Console.ReadLine();

} while (Cadena2.Length <= 0 || Cadena2.Length >= 30);

Console.WriteLine("\nCadenas Unidas: "+(string.Join(Cadena1,Cadena2)));

// EXTRAER SUBCADENA =============================================================
string[] Subcadenas = Cadena1.Split('.');

foreach (var Subcadena in Subcadenas)
{
    Console.WriteLine("\n Subcadena: "+Subcadena);
}

// OPERACIONES ===================================================================
float Solicitud = 0, Numero1 = 0, Numero2 = 0;

Console.WriteLine("\n === CALCULADORA === \n");

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

// MOSTRAR ELEMENTOS CON FOREACH =================================================
string[] SubcadenasA = Cadena1.Split(' ');

foreach (var SubcadenaA in SubcadenasA)
{
    Console.WriteLine("\n Subcadena: "+SubcadenaA);
}

// MOSTRAR OCURRENCIA DE UNA LETRA ===============================================
Console.WriteLine(" [3] Escriba una Letra: ");
Letra1 = Convert.ToChar(Console.ReadLine());

int Contador = 0;

foreach (var PalabraGeneral in Cadena1)
{
    if (Letra1 == PalabraGeneral) Contador++;
}

// CONVERTIR A MAYUSCULAS Y A MINUSCULAS =========================================
Console.WriteLine("Mayuscula: "+Cadena1.ToUpper());
Console.WriteLine("Minuscula: "+Cadena1.ToLower());

// CADENA DE CARACTERES SEPARADA POR UN CHAR ELEGIDO =============================
do
{
    Console.WriteLine(" [4] Escriba una cadena de texto: ");
    Cadena3 = Console.ReadLine();

} while (Cadena3.Length <= 0 || Cadena3.Length >= 30);

Console.WriteLine(" [5] Escriba la Letra utilizada para separar el texto: ");
Letra1 = Convert.ToChar(Console.ReadLine());

string[] SubcadenasLetra = Cadena3.Split(Letra1);

foreach (var Subcadena in SubcadenasLetra)
{
    Console.WriteLine("\n Subcadena: "+Subcadena);
}

// INGRESA UNA ECUACION SIMPLE ===================================================
do
{
    Console.WriteLine(" [6] Escriba una ecuacion simple: ");
    Cadena4 = Console.ReadLine();

} while (Cadena4.Length <= 0 || Cadena4.Length >= 30);

if(Cadena4.Contains('+')){
    double resultado = Convert.ToDouble(Cadena4.Split('+')[0]) + Convert.ToDouble(Cadena4.Split('+')[1]);
    Console.WriteLine("El resultado de la operación es " + resultado);
}

if(Cadena4.Contains('-')){
    double resultado = Convert.ToDouble(Cadena4.Split('-')[0]) - Convert.ToDouble(Cadena4.Split('-')[1]);
    Console.WriteLine("El resultado de la operación es " + resultado);
}

if(Cadena4.Contains('*')){
    double resultado = Convert.ToDouble(Cadena4.Split('*')[0]) * Convert.ToDouble(Cadena4.Split('*')[1]);
    Console.WriteLine("El resultado de la operación es " + resultado);
}

if(Cadena4.Contains('/')){
    if(Convert.ToDouble(Cadena4.Split('/')[0]) == 0){
        Console.WriteLine("No está definida la división en cero");
    } else {
        double resultado = Convert.ToDouble(Cadena4.Split('/')[0]) / Convert.ToDouble(Cadena4.Split('/')[1]);
        Console.WriteLine("El resultado de la operación es " + resultado);
    }
}