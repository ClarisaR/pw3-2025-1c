namespace Clase4.POO.Entidades;

public class Leon : IAnimal
{
    public string Nombre { get; set; }
    public string HacerSonido() => "Grrr";
}
