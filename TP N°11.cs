using System.Diagnostics.CodeAnalysis;
// Bloque TP N°4


// Ejercicio 1
bool recursiva(int N)
{
    if (N == 0)
    {
        return false;
    }
    else
    {
        recursiva(N - 1);
        Console.WriteLine(N);
        return true;
    }
}
Console.WriteLine("Numeros del 1 al 10:");
recursiva(10);


//Ejercicio 2
bool recursiva2(int n2)
{
    if (n2 == 0)
    {
        return false;
    }
    else
    {
        recursiva2(n2 - 1);
        Console.WriteLine("¡Hola mundo!");
        return true;
    }
}
Console.WriteLine("");
Console.WriteLine("Hola mundo 5 veces");
recursiva2(5);


//Ejercicio 3
bool recursiva3(int n3)
{
    if (n3 == 0)
    {
        return false;
    }
    else
    {
        recursiva3(n3 - 2);
        Console.WriteLine(n3);
        return true;
    }
}
Console.WriteLine("");
Console.WriteLine("Numeros del 2 al 20");
recursiva3(20);


//Ejercicio 4
bool recursiva4(int n4)
{
    if (n4 == 0)
    {
        return false;
    }
    else
    {
        recursiva4(n4 - 7);
        Console.WriteLine(n4);
        return true;
    }
}
Console.WriteLine("");
Console.WriteLine("Tabla del 7");
recursiva4(70);


//Ejercicio 5
int recursiva5(int n5)
{
    if (n5 == 1)
    {
        return 1;
    }
    else
    {
        return n5 + recursiva5(n5 - 1);
    }
}
int resultado = recursiva5(5);
Console.WriteLine("");
Console.WriteLine("La suma de los números del 1 al 5 es: " + resultado);




//Ejercicio 1
void Contraseña()
{
    Console.WriteLine("Ingrese la contraseña");
    string contraseña = Console.ReadLine();
   
    if (contraseña == "veggeta777")
    {
        Console.WriteLine("Entrando al sistema");
    }
    else
    {
        Console.WriteLine("Incorrecto, intentelo de vuelta");
        Contraseña();
    }
}
Contraseña();


//Ejercicio 2
bool recursiva(int N)
{
    if (N == 6)
    {
        return false;
    }
    else
    {
        recursiva(N + 1);
        Console.WriteLine(N);
        return true;
    }
}
Console.WriteLine("");
Console.WriteLine("Cuenta regresiva");
recursiva(1);
Console.WriteLine("Despegueeeee");


//Ejercicio 3
void NumSecreto()
{
    try
    { 
        Console.WriteLine("");
        Console.WriteLine("tiene que adivinar el número secreto");
        Console.WriteLine("Ingrese el número");

        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 19)
        {
            Console.WriteLine("¡Adivinaste! :D");
        }
        else
        {
            Console.WriteLine("Incorrecto, intentelo de vuelta");
            NumSecreto();
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Lo que ingresó no es valido en este ejercicio");
    }
    catch (OverflowException)
    {
        Console.WriteLine("El número supera el limite chistoso");
    }
}
NumSecreto();


//Ejercicio 4
void Sumas()
{
    try
    {
        Console.WriteLine("");
        Console.WriteLine("Ingrese varios números, luego los sumaremos entre sí");

        int num = Convert.ToInt32(Console.ReadLine());
        int contador = num;

        while (num > 0)
        {
            num = Convert.ToInt32(Console.ReadLine());
            contador = contador + num;
        }
        Console.WriteLine("");
        Console.WriteLine("La suma de todos los números es: " + contador);
    }
    catch (FormatException)
    {
        Console.WriteLine("El caracter es invalido en este ejercicio");
    }
    catch (OverflowException)
    {
        Console.WriteLine("El número supera el limite chistoso");
    }
}
Sumas();
