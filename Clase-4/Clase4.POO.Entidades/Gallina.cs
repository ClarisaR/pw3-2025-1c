namespace Clase4.POO.Entidades;

public class Gallina : IAnimal
{
    public string Nombre { get; set; }
    public string HacerSonido() => "Cloc Cloc";
}
