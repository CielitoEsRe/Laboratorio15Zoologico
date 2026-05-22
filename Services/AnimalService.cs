using ZoologicoLaboratorio15.Models;

namespace ZoologicoLaboratorio15.Services
{
    public class AnimalService
    {
        public List<Animal> ListaAnimales { get; set; } = new();

        public void AgregarAnimal(Animal animal)
        {
            ListaAnimales.Add(animal);
        }
    }
}
