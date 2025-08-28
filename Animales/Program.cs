// See https://aka.ms/new-console-template for more information

var animal = new Animales();
animal.Id = 1;
animal.Nombre = "Lupe";
animal.Tipo = "Elefante";
animal.Cuidadores = new List<Cuidadores>();

var Habitat = new Habitats();
Habitat.Id = 2;
Habitat.Nombre = "Selva";
Habitat.Espacio = 50.0m;
Habitat.Animales = new List<Animales>();
Habitat.Animales.Add(new Animales() { Id = 7, Nombre = "Max", Tipo = "Lobo", Cuidadores = new List<Cuidadores>() });

var Jaula = new Jaulas();
Jaula.Id = 3;
Jaula.Tamaño = 30.0m;
Jaula.Animales = new List<Animales>();

var Cuidador = new Cuidadores();
Cuidador.Id = 4;
Cuidador.Nombre = "Pedro";
Cuidador.Edad = 24;
Cuidador.Especialidad = "Felinos";
Cuidador.Animales = new List<Animales>();
public class Animales
{
    public int Id;
    public string Nombre = "";

    public string Tipo = "";

    public List<Cuidadores>? Cuidadores;
}

public class Habitats
{
    public int Id;
    public string Nombre = "";
    public decimal Espacio = 0m;
    public List<Animales>? Animales;
}

public class Jaulas
{
    public int Id;
    public decimal Tamaño = 0m;
    public List<Animales>? Animales;
}

public class Cuidadores
{
    public int Id;
    public string Nombre = "";
    public int? Edad;
    public string Especialidad = "";
    public List<Animales>? Animales;
}