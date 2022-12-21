using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class practicaPersonal1
{
    private static void Main(string[] args)
    {
        char[] letras = new char[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("escriba una letra");
            letras[i] = (char)Console.Read();
        }

        Console.WriteLine(letras.Reverse().ToArray());
    }
}
