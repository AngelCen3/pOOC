// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var superman = new SuperHeroe();

superman.id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;
superman.SuperPoderes = new []{"Vision de rayos X", "Volar", "Super fuerza", "Ojos rayos lazer"};

 //Las clases se declaran de forma singular para referirnos a UNA clase, amenos que sea una lista
class SuperHeroe
{
    //public Guid id; //investigar
    public int id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public string[] SuperPoderes; 
    public bool PuedeVolar;
}

//Crearemos una clase para separar la lista de SuperPoderes
class SuperPoder
{
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;  //Contiene  una lista de valores ya prederterminados
}

enum NivelPoder 
{
    NiveUno, 
    NivelDos,
    NivelTres
}

