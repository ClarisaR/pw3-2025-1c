namespace Clase4.POO.Entidades;

public class Perro : IAnimal
{
    public string Nombre { get; set; }
    public string HacerSonido() => "Guau";
}
