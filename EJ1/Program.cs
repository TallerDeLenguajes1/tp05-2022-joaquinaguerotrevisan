Console.WriteLine(" === INVERTIR NUMEROS === \n");

string Numero = "", NumeroInvertido = "";

do
{
    Console.WriteLine("Escriba el numero a invertir (Mayor que 0): ");
    Numero = Console.ReadLine();

} while (Numero.Length<=0);

for (int i = Numero.Length; i < 0; i--)
{
    NumeroInvertido = NumeroInvertido + Numero[i];
}

Console.WriteLine("El numero invertido es: "+NumeroInvertido);