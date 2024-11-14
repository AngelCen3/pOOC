// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capácidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

var superman = new SuperHeroe();

superman.id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;
List<SuperPoder> poderesSuperman = new List<SuperPoder>();

 //Las clases se declaran de forma singular para referirnos a UNA clase, amenos que sea una lista
class SuperHeroe
{
    //public Guid id; //investigar
    public int id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes; 
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

