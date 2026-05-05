//EJERCICIO 1
Console.WriteLine("ejercicio 1");
Console.WriteLine("ingrese una palabra");
String palabra = Console.ReadLine();
String vocales = "aeiouAEIOU";
int cont = 0;
for (int i = 0; i < palabra.Length; i++)
{
    for (int v = 0; v < vocales.Length; v++)
    {
        if (palabra[i] == vocales[v])
        {
            cont++;
            break;
        }
    }
}
Console.WriteLine("las vocales que hay en la oracion es de: " + cont);


//EJERCICIO 2
Console.WriteLine("ejercicio 2");
Console.WriteLine("ingrese su palabra");
String pedro = Console.ReadLine();
String invert = "";
foreach (char letra in pedro)
{
    invert = letra + invert;
}
Console.WriteLine("su texto invertido es: " + invert);


//EJERCICIO 3
Console.WriteLine("ingrese un numero entero");
string texto = Console.ReadLine();
int aux = 0;
int aux2 = 0;
foreach (char n in texto)
{
    aux = Convert.ToInt16(n);
    aux2 = aux + aux2;
}
Console.WriteLine(aux2);

//ejercicio 4
Console.WriteLine("");
Console.WriteLine("Ingrese un texto largo:");
string frase3 = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Ingrese una frase prohibida");
string fraseprohibida = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Ingrese una frase para reemplazarla");
string frasereemplazo = Console.ReadLine();
string nuevafrase = "";
if (frase3.Contains(fraseprohibida) == true)
{
    nuevafrase = frase3.Replace(fraseprohibida, frasereemplazo);
}
Console.WriteLine("");
Console.WriteLine("Esta es la frase: " + nuevafrase);



//ejercicio 5
Console.WriteLine("");
Console.WriteLine("Ingrese su nombre");
string nombre = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Ingrese su apellido");
string apellido = Console.ReadLine();
string iniciales = "";
iniciales = nombre[0] + "." + apellido[0];
Console.WriteLine("");
Console.WriteLine("Su nombre es: " + nombre);
Console.WriteLine("");
Console.WriteLine("Su apellido es: " + apellido);
Console.WriteLine("");
Console.WriteLine("Sus iniciales son: " + iniciales);


//ejercicio 6
Console.WriteLine("");
Console.WriteLine("Ingrese una palabra para identificar si es un palindromo:");
String palindromo = Console.ReadLine();
palindromo = palindromo.ToLower();
String invertido2 = "";
foreach (char j in palindromo)
{
    invertido2 = j + invertido2;
}
if (palindromo == invertido2) 
{
    Console.WriteLine("");
    Console.WriteLine("La palabra '" + palindromo + "' es un palindromo");
}
else
{
    Console.WriteLine("");
    Console.WriteLine("La palabra '" + palindromo + "' NO es un palindromo");
}
