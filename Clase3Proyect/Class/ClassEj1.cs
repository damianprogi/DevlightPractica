using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3Proyect.Class
{
    public class ClassEj1
    {
        public void Ejercicio1() //Dado un valor, devolver un mensaje que diga “El valor es mayor que 100 sólo cuando se cumpla dicha condición.
        {
            Console.WriteLine("Esribe un número: ");

            string texto = Console.ReadLine()!;
            if (int.TryParse(texto, out int valor))
            {
                if (valor > 100)
                    Console.WriteLine("El valor es mayor que 100");
            }
        }
        public void Ejercicio2() // Pedir un número entero por teclado y calcular si es par o impar.
        {
            Console.WriteLine("Ingrese un número: ");
            string texto = Console.ReadLine()!;
            if (int.TryParse(texto, out int numIngresado))
            {
                string text = ((numIngresado % 2) == 0)
                    ? "El número " + numIngresado + " es par."
                    : "El número " + numIngresado + " es impar.";
                Console.WriteLine(text);
            }
        }
        public void Ejercicio3() // Teniendo un valor entero, verificar si se cumple o no que ese valor es el doble de un impar. Por ejemplo, 14 cumple con esta condición.
        {
            int valor = 16;
            string result = " no tiene mitad entera.";
            if (valor % 2 == 0)
            {
                result = (((valor / 2) % 2) != 0)
                    ? " es el doble de un impar."
                    : " no es el doble de un impar.";
            }
            Console.WriteLine(valor + result);
        }
        public string Ejercicio4() // Dada un número del 1 al 10, devolver su “versión” en números romanos.
        {
            int valorDecimal = 4;
            return valorDecimal switch
            {
                1 => "I",
                2 => "II",
                3 => "III",
                4 => "IV",
                5 => "V",
                6 => "VI",
                7 => "VII",
                8 => "VIII",
                9 => "IX",
                _ => "",
            };
        }
        public void Ejercicio5()
        //      Leer el nombre y las edades de dos personas y devolver el nombre del
        //      menor.En caso de que tengan la misma edad también debe indicarse.
        //      Devolver también la diferencia de edad en caso de corresponder.
        {
            Persona persona1 = new Persona("Damian", 30);
            Persona persona2 = new Persona("Juana", 30);

            int difEdad = persona1.Edad - persona2.Edad;
            string texto;

            if (difEdad > 0)
            {
                texto = $"{persona2.Nombre} es menor por {difEdad} años.";
            }
            else if (difEdad < 0)
            {
                texto = $"{persona1.Nombre} es menor por {Math.Abs(difEdad)} años.";
            }
            else
            {
                texto = $"{persona1.Nombre} y {persona2.Nombre} tienen la misma edad.";
            }
            Console.WriteLine(texto);
        }
        public void Ejercicio6() // Escribir un programa que calcule el tipo de un triángulo conociendo la longitud de sus 3 lados. También que calcule su perímetro y su área.
        {
            // Triángulo equilátero: Tiene sus tres lados iguales, es decir, los tres lados son de la misma longitud.
            // Triángulo isósceles: Tiene dos lados iguales (de igual longitud) y otro no.
            // Triángulo escaleno: Tiene los tres lados diferentes, es decir, de distinta longitud

            double[] lados = new double[3];
            bool isConvert;
            int i = 0;
            double area = 1;
            do
            {
                Console.WriteLine($"Ingrese el lado {i + 1}:");
                isConvert = double.TryParse(Console.ReadLine(), out lados[i]);
                i += (isConvert) ? 1 : 0;
            } while (i < 3);

            Array.Sort(lados);

            if (lados[2] >= lados[0] + lados[1])
            {
                Console.WriteLine("no se puede formar un triángulo");
            }
            else
            {
                if ((lados[0] == lados[1]) && (lados[1] == lados[2]))
                    Console.WriteLine("El triángulo es equilátero");
                else if ((lados[0] != lados[1]) && (lados[1] != lados[2]))
                    Console.WriteLine("El triángulo es escaleno");
                else
                    Console.WriteLine("El triángulo es isósceles");


                double perimetro = lados.Aggregate((sum, acu) => sum + acu);
                Console.WriteLine("El perímetro del triángulo es {0} unidades.", perimetro);

                foreach (double lado in lados)
                    area *= (perimetro / 2 - lado);

                area *= perimetro / 2;
                area = Math.Pow(area, 0.5);
                Console.WriteLine("El área del triángulo es: {0:0.00} unidades cuadradas", area);
            }
        }
        public void Ejercicio7()
        {
            double dinero = 0;
            bool isConvert;
            int[] billetes = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
            int[] cambio = new int[billetes.Length];

            do
            {
                Console.WriteLine($"Ingrese un monto de dinero para calcular:");
                isConvert = double.TryParse(Console.ReadLine(), out dinero);
            } while (!isConvert);

            for (int i = 0; i < billetes.Length; i++)
            {
                cambio[i] = ((int)(dinero / billetes[i]));
                dinero = (dinero % billetes[i]);
            }

            for (int i = 0; i < billetes.Length; i++)
            {
                if (cambio[i] != 0)
                {
                    string tipo = (billetes[i] > 4) ? "billete" : "moneda";
                    Console.WriteLine("se entrega {0} {2} de {1}", cambio[i], billetes[i], tipo);
                }
            }
            //    Desarrolle un programa que calcule el desglose de una cantidad dada, en
            //billetes y monedas tal que se minimice la cantidad de monedas y billetes.
            //Considere las denominaciones $1000, $500, $100, $50, $20, $10, $5, $2, $1,
            //donde los últimos tres son monedas. (Por ejemplo, para $1,723 se debe
            //imprimir: “1 billete de $1000, 1 billete de $500, 1 billete de $200, 1 billete de
            //$20, 1 moneda de $2, 1 moneda de $1). Obviar los signos de billete ($) y
            //tratar todos los valores como números, para los cálculos.
        }
        public void Ejercicio8()
        {
            //Pide un número N, y muestra todos los números del 1 al N.
            bool isConvert = false;
            int numero;
            do
            {
                Console.WriteLine($"Ingrese un número entero:");
                isConvert = int.TryParse(Console.ReadLine(), out numero);
            } while (!isConvert);

            for (int i = 1; i <= numero; i++)
                Console.Write("{0}, ", i);
        }
        public void Ejercicio9()
        {
            //Pedir 15 números y escribir la suma total.
            int numero;
            bool isConvert;
            int i = 0;
            double suma = 0;
            Console.WriteLine("ingrese 15 número enteros: ");
            do
            {
                Console.WriteLine($"Ingrese el num {i + 1}: ");
                isConvert = int.TryParse(Console.ReadLine(), out numero);
                if (isConvert)
                {
                    i += 1;
                    suma += numero;
                }
            } while (i < 15);
            Console.WriteLine("La suma de los {0} números dió como resultado: {1}", i, suma);
        }
        public void Ejercicio10()
        {
            //10.Pide 5 números e indica si alguno es múltiplo de 3.
            int[] numeros = new int[5];
            bool isConvert;
            int i = 0;
            string isPar;
            do
            {
                Console.WriteLine($"Ingrese el lado {i + 1}:");
                isConvert = int.TryParse(Console.ReadLine(), out numeros[i]);
                i += (isConvert) ? 1 : 0;
            } while (i < numeros.Length);

            foreach (int num in numeros)
            {
                isPar = (num % 2 == 0) ? "par" : "impar";
                Console.WriteLine("El número {0} es {1}", num, isPar);
            }

        }
        public void Ejercicio11()
        {
            //    Escriba un programa que solicite una contraseña(el texto de la contraseña
            //no es importante) y la vuelva a solicitar hasta que las dos contraseñas
            //coincidan.
            string[] contrasena = new string[2];
            int i = 0;
            bool coinciden = false;

            do
            {
                if (i == 0) Console.WriteLine("--------Escriba la contraseña--------");

                Console.WriteLine("Ingrese contraseña {0}:", i);
                contrasena[i] = Console.ReadLine();

                if (i == 1)
                {
                    i = 0;
                    coinciden = ((contrasena[0] == contrasena[1]) && (contrasena[0].Length > 0));
                    if (coinciden) contrasena[1] = "";
                }
                else
                    i = 1;
            } while (!coinciden);
            Console.WriteLine("coincidieron!!!");
        }
        public void Ejercicio12()
        {
            //    12.Mismo que el anterior pero con un límite de tres peticiones. Luego de las tres
            //peticiones no debe solicitar más la contraseña y terminar el programa.
            string[] contrasena = new string[2];
            int i = 0;
            bool coinciden = false;
            int contador = 0;

            do
            {
                if (i == 0) Console.WriteLine("--------Escriba la contraseña: intento ({0})--------", contador + 1);

                Console.WriteLine("Ingrese contraseña {0}:", i);
                contrasena[i] = Console.ReadLine();

                if (i == 1)
                {
                    i = 0;
                    coinciden = ((contrasena[0] == contrasena[1]) && (contrasena[0].Length > 0));
                    if (coinciden) contrasena[1] = "";
                    contador += 1;
                }
                else
                    i = 1;
            } while (!coinciden && (contador != 3));
            if (coinciden)
                Console.WriteLine("coincidieron!!!");
            else
                Console.WriteLine("solo 3 intentos permitidos");
        }
        public void Ejercicio13()
        {
            //13.Proponer al usuario que adivine un número a base de intentarlo.

            Random rand = new Random();
            int random = rand.Next(0, 100);
            Console.Write(random);
            int numero;
            int i = 0;
            bool isConvert = false;
            Console.WriteLine("Adivina un número del 1 al 100!!! ");
            do
            {
                i += 1;
                Console.WriteLine("Ingresa tu corazonada n° {0}: ", i);
                isConvert = int.TryParse(Console.ReadLine(), out numero);

            } while ((random != numero));
            Console.WriteLine("adivinaste!!!");
        }
        public void Ejercicio14()
        {
            // 14.Modificar el programa anterior para que vaya dando pistas del tipo «mayor» o«menor».

            Random rand = new Random();
            int random = rand.Next(0, 100);
            Console.WriteLine("numero random para salir: " + random);

            string texto;
            int numero;
            int i = 0;
            bool isConvert = false;
            Console.WriteLine("Adivina un número del 1 al 100!!! ");
            do
            {
                i += 1;
                Console.WriteLine("Ingresa tu corazonada n° {0}: ", i);
                isConvert = int.TryParse(Console.ReadLine(), out numero);
                texto = (isConvert && numero > random) ? "es menor" : "es mayor";
                if (isConvert)
                {
                    texto = (numero > random) ? "es menor" : "es mayor";
                    texto = (numero == random) ? "el correcto!!!! ADIVINASTE!!!" : texto;
                    Console.WriteLine("El número oculto es {0}", texto);
                }
                else
                    Console.WriteLine("INGRESASTE CUALQUIER COSA");
            } while ((random != numero));
        }
        public void Ejercicio15()
        {
            //    15.Crea un programa que permita sumar N números.El usuario decide cuándo
            //termina de introducir números al indicar la palabra ‘fin’.
            string texto = "";
            double numero;
            bool isConvert = false;
            double suma = 0;
            int i = 0;
            Console.WriteLine("Sumador de números, con la palabra fin se sale ");
            do
            {
                i += 1;
                Console.WriteLine("Ingresa tu n° {0}: ", i);
                texto = Console.ReadLine();
                isConvert = double.TryParse(texto, out numero);

                if (isConvert)
                    suma += numero;


            } while (texto != "fin");
            Console.WriteLine("la suma de todos los número dio {0}", suma);
        }
        private class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public Persona(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
            }
        }

    }


}
