using Clase4.POO.Entidades;

namespace Clase4.POO.Logica;

public interface IAnimalesLogica
{
    void AgregarAnimal(IAnimal animal);
    List<IAnimal> ObtenerAnimales();
}

public class AnimalesLogica : IAnimalesLogica
{
    private List<IAnimal> Animales { get; set; }
    public AnimalesLogica()
    {
        Animales = new List<IAnimal>();
        Animales.Add(new Perro { Nombre = "Manchis" });
        Animales.Add(new Gato { Nombre = "Chimi" });
        Animales.Add(new Gato { Nombre = "Ceniza" });
        Animales.Add(new Perro { Nombre = "Tomi" });
        Animales.Add(new Perro { Nombre = "Chiqui" });
        Animales.Add(new Gallina { Nombre = "Pipi" });

    }
    public void AgregarAnimal(IAnimal animal)
    {
        Animales.Add(animal);
    }
    public List<IAnimal> ObtenerAnimales()
    {
        return Animales;
    }
}
    