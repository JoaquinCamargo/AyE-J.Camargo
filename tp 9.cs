// ejercicio 1
using System.Timers;


try
{
    Console.WriteLine("Ingrese un numero");
    int numer = Convert.ToInt16(Console.ReadLine());

    if (numer > 0)
    {
        Console.WriteLine("El numero es positivo");
    }
    else
    {
        Console.WriteLine("El numero es negativo");
    }
}
catch (FormatException)
{
    Console.WriteLine("No escriba palabras");

}
catch (OverflowException)
{
    Console.WriteLine("Superas el limite de numeros");
}

//ejercicio 2
try
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese su edad para ver si puede o no entrar");
    int edad2 = Convert.ToInt16(Console.ReadLine());

    if (edad2 > 18)
    {
        Console.WriteLine("Bienvenido a la fiesta perroooooooooo");
    }
    else
    {
        Console.WriteLine("Usted es menor de edad");
    }
}

catch (FormatException)
{
    Console.WriteLine("No escriba palabras");

}

catch (OverflowException)
{
    Console.WriteLine("Superas el limite de numeros");
}

//ejercicio 3

Console.WriteLine("");
Console.WriteLine("Ingrese la contraseña:");
string contraseñas = Console.ReadLine();

while (contraseñas != "ABCD")
{
    if (contraseñas != "ABCD")
    {
        Console.WriteLine("Contraseña incorrecta, ingrese de vuelta la contraseña");
        contraseñas = Console.ReadLine();
    }

    if (contraseñas == "ABCD")
    {
        Console.WriteLine("Contraseña correcta");
    }
}

//ejercicio 4


try
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese un número para ver si es par o impar");
    int numer2 = Convert.ToInt16(Console.ReadLine());

    if (numer2 / 2 == 0)
    {
        Console.WriteLine("El numero es par");
    }
    else
    {
        Console.WriteLine("El numero es impar");
    }
}

catch (FormatException)
{
    Console.WriteLine("No escriba palabras");
}

catch (OverflowException)
{
    Console.WriteLine("Superas el limite de numeros");
}

//ejercicio 5

try
{
    Console.WriteLine("");
    Console.WriteLine("Si cumple con los requisitos, podra obtener una entrada gratis al cine");
    Console.WriteLine("Ingrese su edad:");
    int edad2 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("¿Usted compro pochoclos?");
    string respuestas = Console.ReadLine();

    if (respuestas != "si")
    {
        Console.WriteLine("Afuera por chistoso");
    }
    else
    {
        Console.WriteLine("Usted no cumple con los requisitos para la entrada gratuita");
    }
}
catch (FormatException)
{
    Console.WriteLine("No escriba palabras");
}

catch (OverflowException)
{
    Console.WriteLine("Superas el limite de numeros");
}