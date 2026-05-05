string Ejercicio1(int n) {
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
    else {
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

string Ejercicio3 (string correcta)
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


Console.WriteLine("");
Console.WriteLine("Ingrese un número para identificar si es par o impar");

string ejercicio4(int a)
{
    string resultado4;
    if (a % 2 == 0)
    {
        resultado4 = ("El numero es par");
        return resultado4;
    }
    else
    {
        resultado4 = ("El numero es impar");
        return resultado4;
    }
}
int a = Convert.ToInt32(Console.ReadLine());
string resultado4 = ejercicio4(a);
Console.WriteLine(resultado4);




Console.WriteLine("");
Console.WriteLine("Saludos caballero, hoy ofrecemos entradas gratis para el cine");
Console.WriteLine("Por favor, ingrese su edad");

string ejercicio5(int edad2, string respuesta)
{
    string resultado5;
    if (edad2 >= 65 && respuesta == "si")
    {
        resultado5 = ("Cumple con los requisitos, tenga su entrada gratuita");
        return resultado5;
    }
    else
    {
        resultado5 = ("Usted no cumple con los requisitos para la entrada gratuita");
        return resultado5;
    }
}
int edad2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("¿Usted compró palomitas?");
string respuesta = Convert.ToString(Console.ReadLine());
string resultado5 = ejercicio5(edad2, respuesta);
Console.WriteLine(resultado5);
