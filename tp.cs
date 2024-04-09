using System;


class Program
{

    private static string alfabeto = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";

    public static void Main()
    {

        Console.WriteLine("Ingrese la frase a cifrar");

        string msj1 = Console.ReadLine();

        while (string.IsNullOrEmpty(msj1))
        {
            Console.WriteLine("Ingrese un mensaje no vacio");
            msj1 = Console.ReadLine();
        }

        Console.WriteLine("Ingrese la frase a descrifrar");

        string msj2 = Console.ReadLine();

        while (string.IsNullOrEmpty(msj2))
        {
            Console.WriteLine("Ingrese un mensaje no vacio");
            msj2 = Console.ReadLine();
        }

        Program program = new Program();
        Console.WriteLine("Mensaje cifrado: ");
        Console.WriteLine(program.Cifrar(msj1));
        Console.WriteLine("Mensaje descrifrado: ");
        Console.WriteLine(program.Descifrar(msj2));

    }

    private string Cifrar(string msj)
    {

        string aux = "";

        for (int i = 0; i < msj.Length; i++)
        {

            char c = msj[i];

            int position = -1;

            for (int y = 0; (y < alfabeto.Length) && (position == -1); y++)
            {

                if (alfabeto[y] == c)
                {

                    position = y;

                }

            }

            position = (position + 7) % alfabeto.Length;

            aux += alfabeto[position];

        }

        return aux;

    }

    private string Descifrar(string msj)
    {

        string aux = "";

        for (int i = 0; i < msj.Length; i++)
        {

            char c = msj[i];

            int position = -1;

            for (int y = 0; (y < alfabeto.Length) && (position == -1); y++)
            {

                if (alfabeto[y] == c)
                {

                    position = y;

                }

            }

            position = (position - 7) + alfabeto.Length * BoolToInt(position - 7 < 0);

            aux += alfabeto[position];

        }

        return aux;

    }

    private static int BoolToInt(Boolean x)
    {

        if (x)
        {

            return 1;

        }
        else
        {

            return 0;

        }

    }

}
