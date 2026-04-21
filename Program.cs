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

            case 4:

            case 5:

            case 6:

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

            case 10:

            case 11:

            case 12:

            case 13:

            case 14:

            case 15:

            case 16:

            case 17:

            case 18:

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

