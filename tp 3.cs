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