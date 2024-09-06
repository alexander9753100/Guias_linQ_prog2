// See https://aka.ms/new-console-template for more information
using linqGuias;

Console.WriteLine("Hello, World!");

#region ListaModelos
// Lista que almacena objetos de tipo Casa.
List<Casa> ListaCasas = new List<Casa>();
// Lista que almacena objetos de tipo Habitante.
List<Habitante> ListaHabitantes = new List<Habitante>();
#endregion

#region listaCasa
// Agregar una nueva casa con ID 1 a la lista.
ListaCasas.Add(new Casa
{
    Id = 1,
    Direccion = "3 av Norte ArcanCity",
    Ciudad = "Gothan City",
    numeroHabitaciones = 20,
});

// Agregar una nueva casa con ID 2 a la lista.
ListaCasas.Add(new Casa
{
    Id = 2,
    Direccion = "6 av Sur SmollVille",
    Ciudad = "Metropolis",
    numeroHabitaciones = 5,
});

// Agregar una nueva casa con ID 3 a la lista (sin número de habitaciones).
ListaCasas.Add(new Casa
{
    Id = 3,
    Direccion = "Forest Hills, Queens, NY 11375",
    Ciudad = "New York"
});
#endregion

#region ListaHabitante
// Agregar un habitante con ID 1 (Bruno Diaz) a la lista.
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Bruno Diaz",
    Edad = 36,
    IdCasa = 1
});

// Agregar un habitante con ID 2 (Clark Kent) a la lista.
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 2,
    Nombre = "Clark Kent.",
    Edad = 40,
    IdCasa = 2
});

// Agregar un habitante con ID 3 (Peter Parker) a la lista.
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 3,
    Nombre = "Peter Parker",
    Edad = 25,
    IdCasa = 3
});

// Agregar un habitante con ID 3 (Tía May) a la lista.
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 3,
    Nombre = "Tia Mey",
    Edad = 85,
    IdCasa = 3
});

// Agregar un habitante con ID 2 (Lois Lane) a la lista.
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 2,
    Nombre = "Luise Lain",
    Edad = 40,
    IdCasa = 2
});

// Agregar un habitante con ID 1 (Selina Kyle) a la lista.
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Selina Kyle",
    Edad = 30,
    IdCasa = 1
});

// Agregar un habitante con ID 1 (Alfred) a la lista.
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Alfred",
    Edad = 65,
    IdCasa = 1
});

// Agregar un habitante con ID 1 (Nathan Drake) a la lista.
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Nathan Drake",
    Edad = 37,
    IdCasa = 1
});
#endregion

#region SentenciasLinQ
// Filtrar habitantes con edad mayor a 40.
IEnumerable<Habitante> ListaEdad = from ObjetoProvicional
                                   in ListaHabitantes
                                   where ObjetoProvicional.Edad > 40
                                   select ObjetoProvicional;

// Imprimir los datos de los habitantes filtrados.
foreach (Habitante objetoProcicional2 in ListaEdad)
{
    Console.WriteLine(objetoProcicional2.datosHabitante());
}

// Realizar un join entre habitantes y casas en la ciudad de Gothan City.
IEnumerable<Habitante> listaCasaGothan = from objetoTemporalHabitante in ListaHabitantes
                                         join objetoTemporalCasa in ListaCasas
                                         on objetoTemporalHabitante.IdHabitante equals objetoTemporalCasa.Id
                                         where objetoTemporalCasa.Ciudad == "Gothan City"
                                         select objetoTemporalHabitante;

Console.WriteLine("----------------------------------------------------------------------------------------------");

// Imprimir los datos de los habitantes en Gothan City.
foreach (Habitante h in listaCasaGothan)
{
    Console.WriteLine(h.datosHabitante());
}
#endregion