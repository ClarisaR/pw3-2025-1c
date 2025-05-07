namespace Clase4.POO.Entidades;

public class Vaca : IAnimal
{
    public string Nombre { get; set; }
    public string HacerSonido() => "Muuu";
}
