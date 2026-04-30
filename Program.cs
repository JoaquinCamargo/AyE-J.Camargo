Console.Write("Bienvenido a cual Bloque quiere ingresar?");
Console.WriteLine("1-Bloque1 2-Bloque2 3-Bloque3");
int menus = Convert.ToInt32(Console.ReadLine());

switch (menus)
{
    case 1:
        Console.Write("Bienvenido a cual ejercicio quiere ingresar?");
        Console.WriteLine("1-EjercicioA 2-EjercicioB 3-EjercicioC 4-EjercicioD 5-EjercicioE 6-EjercicioF 7-EjercicioG 8-EjercicioH 9-EjercicioI");
        Console.WriteLine("10-EjercicioJ 11-EjercicioK 12-EjercicioL 13-EjercicioM 14-EjercicioN 15-EjercicioO 16-EjercicioP 17-EjercicioQ 18-EjercicioR");
        int Bloque1 = Convert.ToInt32(Console.ReadLine());
        switch (Bloque1)
        {

            case 1:

                Console.WriteLine("vamos a contar hasta el 100 de a 3 numeros");

                for (int o = 0; o < 100; o = 3 + o)
                {
                    Console.WriteLine(o);
                }
                break;

            case 2:
                Console.WriteLine("Ingrese su edad y verificaremos si es mayor de edad");
                string Ejercicio2(int edad)
                {

                    string fiesta;
                    if (edad >= 18)
                    {
                        fiesta = "Usted tiene mas de 18 años";
                        return fiesta;
                    }
                    else
                    {
                        fiesta = "Lo siento, Usted es menor de edad";
                        return fiesta;
                    }
                }


                Console.WriteLine(Ejercicio2(Convert.ToInt32(Console.ReadLine())));

                break;

            case 3:

                Console.WriteLine("Ingrese una palabra:");
                string palabra = Console.ReadLine();
                Console.WriteLine("Cantidad de letras: " + palabra.Length);


                break;

            case 4:
                Console.WriteLine("Adivine la contraseña (5 intentos):");
                string password = "1234";

                for (int i = 0; i < 5; i++)
                {
                    string intento = Console.ReadLine();

                    if (intento == password)
                    {
                        Console.WriteLine("Correcto");
                        break;
                    }

                    if (i == 4)
                        Console.WriteLine("Bloqueado");
                }
                break;


            case 5:

                Console.WriteLine("Ingrese 10 numeros:");
                int mayor = int.MinValue;

                for (int i = 0; i < 10; i++)
                {
                    int n = int.Parse(Console.ReadLine());

                    if (n > mayor)
                        mayor = n;
                }

                Console.WriteLine("Mayor: " + mayor);
                break;

            case 6:
                Console.WriteLine("Ingrese su nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine(char.ToUpper(nombre[0]) + nombre.Substring(1));

                break;


            case 7:
                for (int i = 7; i < 77; i = 7 + i)
                {
                    Console.WriteLine(i);
                }

                break;

            case 8:

                for (int f = 10; f > 0; f--)
                {
                    Console.WriteLine(f);
                }
                Console.Write("oaaaa");

                break;

            case 9:
                Console.WriteLine("Ingrese un numero:");
                int num9 = int.Parse(Console.ReadLine());

                if (num9 % 2 == 0)
                    Console.WriteLine("par");
                else
                    Console.WriteLine("impar");
                break;

            case 10:
                Console.WriteLine("Ingrese una frase:");
                string frase10 = Console.ReadLine().ToLower();

                int cont10 = 0;

                foreach (char c in frase10)
                {
                    if ("aeiou".Contains(c))
                        cont10++;
                }

                Console.WriteLine("Vocales: " + cont10);
                break;

            case 11:
                Console.WriteLine("ingresa un numero y te mostrare su tabla del 1 al 12");
                int faso = Convert.ToInt16(Console.ReadLine());

                for ( int r = 0;r < 13 ; r++)
                {
                    Console.WriteLine(faso*r);
                }

                break;

            case 12:

                Console.WriteLine("Ingrese numeros hasta superar 100:");
                int suma = 0;

                while (suma <= 100)
                {
                    suma += int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Supero 100");


         
                break;

            case 13:

                Console.WriteLine("Ingrese una palabra:");
                string palabra13 = Console.ReadLine();

                foreach (char c in palabra13)
                {
                    Console.WriteLine(c);
                }
                break;

            case 14:

                Console.WriteLine("Ingrese edad:");
                int edad14 = int.Parse(Console.ReadLine());

                if (edad14 >= 18)
                    Console.WriteLine("Puede votar y manejar");
                else
                    Console.WriteLine("No puede");
                break;

            case 15:

                for (int r = 50; r > 0; r = r-5)
                {
                    Console.WriteLine(r);
                }

                break;

            case 16:

                Console.WriteLine("Ingrese contraseña y repitala:");
                string a, b;

                do
                {
                    a = Console.ReadLine();
                    b = Console.ReadLine();

                } while (a != b);

                Console.WriteLine("Acceso permitido");
                break;

            case 17:
                Console.WriteLine("Ingrese nombres hasta que uno tenga mas de 10 letras:");
                string nombre17;

                do
                {
                    nombre17 = Console.ReadLine();

                } while (nombre17.Length <= 10);
                break;

            case 18:
                Console.WriteLine("Ingrese una frase:");
                string frase18 = Console.ReadLine().ToLower();

                int cont18 = 0;

                foreach (char c in frase18)
                {
                    if (c == 'a')
                        cont18++;
                }

                Console.WriteLine("Cantidad de 'a': " + cont18);
                break;

            default:

                break;







        }
        break;

    case 2:

        break;

    case 3:

        break;

    default:

        break;




}

