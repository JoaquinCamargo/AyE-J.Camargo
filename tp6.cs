int papa = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(" toca un numero depende del ejercicio 1-Ejercicio1, 2-Ejercicio2, 3-Ejercicio3");

string Ejercicio1(int n)
{
    string resultado;
    if (n > 0)
    {
        resultado = "Positivo";
        return resultado;
    }
    else if (n == 0)
    {
        resultado = "Es 0";
        return resultado;

    }
    else
    {
        resultado = "negativo";
        return resultado;

    }
}

Console.WriteLine(Ejercicio1(Convert.ToInt32(Console.ReadLine())));

string Ejercicio2(int edad)
{

    string fiesta;
    if (edad >= 18)
    {
        fiesta = "¡Bienvenido a la fiesta!";
        return fiesta;
    }
    else
    {
        fiesta = "Lo siento, eres muy joven";
        return fiesta;
    }
}

Console.WriteLine(Ejercicio2(Convert.ToInt32(Console.ReadLine())));

string Ejercicio3(string correcta)
{
    string contraseña;

    if (correcta == "python123")
    {
        contraseña = "contraseña correcta";
        return contraseña;
    }
    else
    {
        contraseña = "contraseña incorrecta";
        return contraseña;

    }

}
Console.WriteLine(Ejercicio3(Console.ReadLine()));

switch (papa)
{

    case 1:
        Console.WriteLine("Dime un numero y te digo si es posito o negativo");
        int ano = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(Ejercicio1(ano));
        break;
    case 2:
        Console.WriteLine("Dime tu edad y te digo si podes entrar a la fiesta");
        int lolas = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(Ejercicio2(lolas));
        break;
    case 3:
        Console.WriteLine("Dime un numero y te digo si es posito o negativo");
        string pelo = Console.ReadLine();
        Console.WriteLine(Ejercicio3(pelo));
        break;

    default:

        Console.WriteLine("chauchis");
        break;

}




