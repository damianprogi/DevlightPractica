
using Clase3Proyect.Class;

ClassEj1 claseEj1 = new ClassEj1();

//claseEj1.Ejercicio1();
//claseEj1.Ejercicio2();
//claseEj1.Ejercicio3();
//claseEj1.Ejercicio4();
//claseEj1.Ejercicio5();
//claseEj1.Ejercicio6();
//claseEj1.Ejercicio7();
//claseEj1.Ejercicio8();
//claseEj1.Ejercicio9();
//claseEj1.Ejercicio1();
//claseEj1.Ejercicio11();
//claseEj1.Ejercicio12();
//claseEj1.Ejercicio13();
//claseEj1.Ejercicio14();
//claseEj1.Ejercicio15();

// Ejercicio 2
Cuadrado cuadrado = new Cuadrado();
Console.WriteLine(cuadrado.Area(5));

// Ejercicio 3
Persona persona = new Persona("Juan", "Bartolo");
Console.WriteLine(persona.NombreCompleto());

// Ejercicio 4
Persona persona2 = new Persona("Dionicio", "Latencia", new DateTime(1978, 5, 13));
Console.WriteLine(persona2.Edad());

// Ejercicio 5
Auto autito = new Auto("coupe", "renault", "rojo", 4);
Console.WriteLine(autito.Encender());
Console.WriteLine(autito.Apagar());

// Ejercicio 6
//Mascota mascota = new Mascota("Mamune", Mascota.TipoMascota.perro) ;


Mascota mascota2 = new Mascota("Pitulli", new TipoMascota("perro", 5));
mascota2.Alimentar();
Console.WriteLine(mascota2);


// Ejercicio 7
//Agregar a la Mascota un método para correr. Cada vez que la mascota corre,
//gasta un 10% de su energía. Solamente puede correr si su nivel de energía
//es superior al 20%.

if (mascota2 != null)
{
    mascota2.Correr();
    mascota2.Correr();
    mascota2.Correr();
    mascota2.Correr();
    mascota2.Correr();
    mascota2.Correr();
    mascota2.Correr();
    mascota2.Correr();
    mascota2.Correr();
    mascota2.Correr();
}


// Ejercicio 8
//Crear una clase Smartphone con los siguientes métodos:
//a.para encender y apagar el mismo,
//b. subir y bajar el volumen,
//c. poner en silencio,
//d. bajar o subir el brillo de la pantalla.
//e. Además de properties para marca y modelo.
Smartphone telefono = new Smartphone("Samsung", "XC4564");
Console.WriteLine(telefono.ToString());
telefono.EncendidoApagado();
Console.WriteLine(telefono.ToString());
telefono.Silenciar();
Console.WriteLine(telefono.ToString()); telefono.Silenciar();
Console.WriteLine(telefono.ToString()); telefono.Silenciar();
Console.WriteLine(telefono.ToString()); telefono.Silenciar();
Console.WriteLine(telefono.ToString()); telefono.Silenciar();
Console.WriteLine(telefono.ToString());

// Ejercicio 9
//Añadir a la clase Auto un método para acelerar y para frenar. Cada vez que el
//auto acelera incrementa su velocidad en un 10%. Y cada vez que frena
//reduce su velocidad en un 20%. Se debe encender el motor del auto para
//poder acelerar. Agregar métodos para conocer la Velocidad y la Aceleración
//en cualquier momento.

autito.Encender();
Console.WriteLine(autito.ToString()); autito.Acelerar();
Console.WriteLine(autito.ToString()); autito.Acelerar();
Console.WriteLine(autito.ToString()); autito.Frenar();
//autito.Apagar();
//autito.Encender();
Console.WriteLine(autito.ToString()); autito.Frenar();
Console.WriteLine(autito.ToString()); autito.Frenar();
Console.WriteLine(autito.ToString()); autito.Frenar();
Console.WriteLine(autito.ToString()); autito.Frenar();

// Ejercicio 10
//Agregar a la clase Persona la posibilidad de tener un Smartphone.
bool tieneTel = persona2.AdquirirSmartPhone(new Smartphone("LG", "x500"));

// Ejercicio 11
//Agregar a la clase Auto, la posibilidad de tener una Persona como conductor.
//Siendo que ahora el auto no puede encender su motor si no hay un conductor
//presente. Además el Conductor debe tener 18 años como mínimo.
autito.SubirConductor(persona2);
Console.WriteLine(autito.Encender());
Console.WriteLine(autito.Apagar());

// Ejercicio 12
//Agregar a la clase Auto la posibilidad de llevar Pasajeros. (de 0 a la
//capacidad que tenga el auto). Considere agregar una property Capacidad
Persona persona5 = new Persona("Martina", "Gigabit", new DateTime(1978, 5, 13));
Console.WriteLine("subió pasajero 1: " + autito.SubirPasajeros(persona5));

//Ejercicio 13
//Añadir a la clase Auto, la posibilidad de poder llevar una Mascota, pero sólo
//si hay un conductor presente. La mascota puede o no contar como pasajero
//dependiendo del Tamaño de la mascota. por lo que el número de lugares
//disponibles puede verse reducido. Además, si no hay lugares disponibles en
//el vehículo, la mascota no podrá subir al auto. Si la Mascota es pequeña, irá
//en el regazo de algún pasajero, pero no del conductor. Agregar un método
//que permita saber en el regazo de quién va la Mascota. Además otro método
//para que la Mascota se mueva al regazo de otro pasajero.

Mascota mascota3 = new Mascota("Nina", new TipoMascota("perro", 3));
Mascota mascota4 = new Mascota("Gala", new TipoMascota("gato", 5));
Mascota mascota5 = new Mascota("Umma", new TipoMascota("perro", 20));

Persona persona3 = new Persona("Juan", "Messi", new DateTime(1978, 5, 13));
//Persona persona4 = new Persona("Pepa", "Messi", new DateTime(1978, 5, 13));
//Persona persona5 = new Persona("Juana", "Messi", new DateTime(1978, 5, 13));

Console.WriteLine("subió pasajero 2: " + autito.SubirPasajeros(persona3));
//Console.WriteLine("subió pasajero 3: " + autito.SubirPasajeros(persona4));
//Console.WriteLine("subió pasajero 4: " + autito.SubirPasajeros(persona5));
//Console.WriteLine(mascota3);
//Console.WriteLine(mascota4);
//Console.WriteLine(mascota5);

Console.WriteLine("subio mascota?: " + autito.SubirMascota(mascota5));
Console.WriteLine("subio mascota?: " + autito.SubirMascota(mascota4));
//Console.WriteLine("subio mascota?: " + autito.SubirMascota(mascota3));
//Console.WriteLine("subio mascota?: " + autito.SubirMascota(mascota3));
Console.WriteLine("subio mascota?: " + autito.SubirMascota(mascota5));
//Console.WriteLine(autito.SubirMascota(mascota3));

autito.HayMascotasEnRegazo();
autito.MoverMascotaAOtroRegazo(persona5, persona3);
autito.HayMascotasEnRegazo();

//Ejercicio 14
//Agregar un método a Auto para bajar a todos los pasajeros, donde se debe
//verificar que antes de bajar cualquier pasajero el auto debe estar detenido
//(Velocidad = 0) También que antes que baje el Conductor, debe apagarse el
//vehículo.

autito.BajarTodosDelAuto();
autito.HayMascotasEnRegazo();

// Ejercicio 15
//Crear una clase Libro, que contenga Nombre, Autor, Cantidad de Páginas, y
//una property llamada WasRead, que diga si el libro fue leído o no (boolean).
//Crear una clase Estudiante, que hereda de Persona (la clase de los puntos
//anteriores). El estudiante debe contener una lista de Libros, los cuales puede
//ser que los haya leído o no. (Se pueden crear dos listas diferentes si se
//complica mucho. Una lista con todos los libros, leídos o no, y otra lista sólo
//con los libros leídos) Debe haber un método que muestre la lista de libros
//leídos, y además otro método que permita calcular la suma de la cantidad de
//páginas leídas totales, de todos los libros leídos. Y un método que permita
//saber cuántos libros quedan sin leer. Otro método que permite agregar o
//quitar libros de la lista de libros (dos métodos diferentes).
Libro l1 = new Libro("el señor de los anillos", "tolkien", 1500);
Libro l2 = new Libro("rayuela", "julio cortazar", 600);
Libro l3 = new Libro("el hombre de la rosa", "umberto eco", 700);

//Console.WriteLine($"{l1} fue leido " + l1.getWasread());
Estudiante e1 = new Estudiante("Jazinto", "Perez");
Estudiante e2 = new Estudiante("Anita", "Marmolada");
Estudiante e3 = new Estudiante("Paola", "Paramo");

e1.AddLibro(l1);
e1.AddLibro(l2);

e1.CantLibrosSinLeer();
e1.CantPáginasLeidas();
e1.LibrosLeidos();
e1.RemoveUltimoLibro();
