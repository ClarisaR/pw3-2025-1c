namespace Clase4.POO.Entidades;

public class Gato : IAnimal
{
    public string Nombre { get; set; }
    public string HacerSonido() => "Miau";
}
