using Clase4.POO.Entidades;
using Clase4.POO.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase4.POO.Web.Controllers
{
    public class AnimalesController : Controller
    {
        private readonly IAnimalesLogica _animalesLogica;
        public AnimalesController(IAnimalesLogica animalesLogica) 
        {
            _animalesLogica = animalesLogica;
        }
        public IActionResult Listar()
        {
            var animales = _animalesLogica.ObtenerAnimales();
            return View(animales);
        }
        public IActionResult Agregar()
        {
            return View();
        }
     
        [HttpPost]
        public IActionResult Agregar(string nombre, string tipo)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(tipo))
            {
                ModelState.AddModelError("", "Debe completar todos los campos.");
                return View();
            }

            IAnimal nuevoAnimal = tipo switch
            {
                "Perro" => new Perro { Nombre = nombre },
                "Gato" => new Gato { Nombre = nombre },
                "Leon" => new Leon { Nombre = nombre },
                "Gallina" => new Gallina { Nombre = nombre },
                "Vaca" => new Vaca { Nombre = nombre },
                _ => null
            };

            if(nuevoAnimal == null)
            {
                ModelState.AddModelError("", "Tipo de animal no válido.");
                return View();
            }

            _animalesLogica.AgregarAnimal(nuevoAnimal);
            return RedirectToAction("Listar");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
