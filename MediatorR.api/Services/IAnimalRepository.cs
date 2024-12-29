using MediatorR.api.Models;

namespace MediatorR.api.Services
{
    public interface IAnimalRepository
    {
        public Task<List<Animal>> GetAnimalListAsync();
        public Task<Animal> GetAnimalByIdAsync(int id);
        public Task<Animal> AddAnimalAsync(Animal animal);
        public Task<int> UpdateAnimalAsync(Animal animal);
        public Task<int> DeleteAnimalAsync(int id);
    }
}
