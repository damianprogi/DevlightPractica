// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
#region Arreglos
Console.WriteLine("Arreglos");

//1era forma de declaración
//
int[] arreglo0 = new int[5];
int[] arreglo1 = new int[] { 3,1,2};
int[] arreglo2 = {5, 6, 8, 9, 10 };

for (int i = 0; i < arreglo0.Length; i++)
{
    arreglo0[i] = i + arreglo2[i];
}

Console.WriteLine("Longitud: " + arreglo0.Length);
Console.WriteLine("Primer elemento: " + arreglo0[0]);
Console.WriteLine("Primer elemento: " + arreglo0[arreglo0.Length-1]);
Console.WriteLine("Rank: " + arreglo0.Rank);

Console.WriteLine("Longitud: " + arreglo1.Length);
Console.WriteLine("Primer elemento: " + arreglo1[0]);
Console.WriteLine("Primer elemento: " + arreglo1[arreglo1.Length - 1]);
Console.WriteLine("Rank: " + arreglo1.Rank);

Console.WriteLine("Longitud: " + arreglo2.Length);
Console.WriteLine("Primer elemento: " + arreglo2[0]);
Console.WriteLine("Primer elemento: " + arreglo2[arreglo2.Length - 1]);
Console.WriteLine("Rank: " + arreglo0.Rank);


// arreglo multidimensional
Console.WriteLine("**********multidimensional**********");
int[,] arreglo2dim = new int[2, 3];

for (int i = 0; i < 2; i++)
{
	for (int j = 0; j < 3; j++)
	{
		arreglo2dim[i, j] = i + j;
		Console.Write("(" + arreglo2dim[i, j] + ") ");
	}
	Console.WriteLine("");
}

foreach (var item in arreglo2dim)
	Console.Write(item);

//Console.WriteLine("Y ESTO" + arreglo2dim[0,])
Console.WriteLine("Rank: " + arreglo2dim.Rank);

// arreglo jagged
Console.WriteLine("**********JAGGED**********");
int[][] arregloJagged = new int[3][];

arregloJagged[0] = new int[3] { 1, 2, 3 };
arregloJagged[1] = new int[4] { 1, 2, 3, 4 };
arregloJagged[2] = new int[5] { 1, 2, 3, 4, 5 };

Console.WriteLine(arregloJagged[0][0]);
Console.WriteLine(arregloJagged[1][1]);
Console.WriteLine(arregloJagged[2][2]);

Console.WriteLine(arregloJagged.Rank);
Console.WriteLine(arregloJagged.Rank);
Console.WriteLine(arregloJagged.Rank);

foreach (var item in arregloJagged)
{
	foreach (var item2 in item)
	{
		Console.Write(item2);
	}
	Console.WriteLine();
}
#endregion

#region List
Console.WriteLine("**********LISTAS**********");

// 1era forma
List<int> lista1 = new List<int>();
Console.WriteLine("count: " + lista1.Count);
Console.WriteLine("capacity: " + lista1.Capacity);
// 2da forma
List<int> lista2 = new List<int>(arreglo1);
Console.WriteLine("count: " + lista2.Count);
Console.WriteLine("capacity: " + lista2.Capacity);
// 3era forma
List<int> lista3 = new List<int>(3);
Console.WriteLine("count: " + lista3.Count);
Console.WriteLine("capacity: " + lista3.Capacity);
// 4ta forma
List<int> lista4 = new List<int>() { 1, 2, 3, 4, 5};
Console.WriteLine("count: " + lista4.Count);
Console.WriteLine("capacity: " + lista4.Capacity);

for (int i = 0; i < lista4.Count; i++)
	Console.Write(lista4[i]);

lista4.Add(1);
lista4.Add(2);

Console.WriteLine();
foreach (int item in lista4)
    Console.Write(item);

lista4.Remove(3);
lista4.RemoveAt(0);

Console.WriteLine();
foreach (int item in lista4)
    Console.Write(item);
#endregion

#region ArrayMethod
//Array - Methods

Console.WriteLine("-------------------------ARRAY METHODS");
PrintArray(arreglo2);

Array.Clear(arreglo2);
PrintArray(arreglo2);

//Array.Copy(arreglo1, arreglo2, 10);
//arreglo1.CopyTo(arreglo2, 10);

// devuelve un boolean type if match the conditions.
var flag = Array.Exists(arreglo1, item=> item == 2); ;
// devuelve la primera coincidencia
var primerValor = Array.Find(arreglo1, item => item > 0);
// retorna el último elemento
var ultimoValor = Array.FindLast(arreglo1, item => item > 1);
// devuelve todas las coincidencias
var todosLosValores = Array.FindAll(arreglo1, item => item > 0);
// retorna el índice del elemento que cumpla la condición
var indice = Array.FindIndex(arreglo1, item => item > 1);
// retorna el ultimo indice del elemento que cumpla la condición
var ultimoIndice = Array.FindLastIndex(arreglo1, item => item > 1);

Array.ForEach(arreglo1, item =>
{

	item += (item > 7) ? -1 : 1;
	//if (item > 7)
	//	item -= 1;
	//else
	//	item += 1;

	Console.Write(item);
});


var longitud = arreglo1.GetLength(1);
var item = arreglo1.GetValue(2);

arreglo1.SetValue(4, 2);

// cuidado que reverse cambia el tipo de dato a collection generic
var arregloRevert = arreglo1.Reverse();

var indice2 = Array.IndexOf(arreglo1, 8);

// copia en nuevo arreglo pero de 10, por eso se pasa por referencia
Array.Resize(ref arreglo1, 15);
Array.Sort(arreglo1,);



void PrintArray(int[] x) {
    for (int i = 0; i < x.Length; i++)
        Console.Write(x[i]);
	Console.WriteLine();
}
#endregion

#region ListMethod

lista1.Add(1);
lista2.Add(5);
lista2.Clear();

var flag2 = lista1.Contains(1);
// CopyTo pide un arreglo a dónde copiar la lista1
lista1.CopyTo(arreglo1);

lista2.Equals(lista4);
lista1.Exists(item => item > 1);
lista1.Find(item => item == 5);

List<string> listaString = new List<string>() {"asda", "asdfasdb", "asdfc", "dasdf", "gfdsgfde"};
listaString.ForEach(item =>
{
	//item = item.ToUpper();
});

var indiceX = lista1.IndexOf(5);
lista2.Insert(2, 5);
lista2.InsertRange(2, lista4);
lista2.Remove(2);
lista2.RemoveAll(item => item < 5);
lista2.RemoveRange(2, 5);
lista2.RemoveAt(2);
lista2.Reverse();
lista2.Sort();

var flag4 = lista2.All(item => item > 5);
var flag5 = lista2.Any(item=> item == 5);
var listaNueva = lista2.Concat(lista3);
var listaUnica = lista2.Distinct();
var element = lista1.ElementAt(2);
var listaExcepto = lista2.Except(lista3);
var elemento = lista2.First(item=> item > 5);
var elementoO_Default = lista2.FirstOrDefault(item => item > 5);

// Last
// LastOrDefault

var valor5 = lista2.Max();
// tener cuidado con lista de objetos o de string, no arroja error
var valor4 = listaString.Max();

// aprender estos tres de abajo
//var nuevaLista2 = lista3.Where(oj => oj.Score>3).Select(item => item.Score).Sum();
//var orderList = lista3.OrderBy(o => o.Score);
//lista2.Join(lista4, x => x);
lista2.Union(lista3);

#endregion