using MediatorR.api.Data;
using MediatorR.api.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatorR.api.Services
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly MedaitorRDbContext _context;
        public AnimalRepository(MedaitorRDbContext db)
        {
            _context = db;
        }
        public async Task<Animal> AddAnimalAsync(Animal animal)
        {
            var addedAnimal = await _context.AddAsync(animal);
            await _context.SaveChangesAsync();
            return addedAnimal.Entity;
        }

        public async Task<int> DeleteAnimalAsync(int id)
        {
            var getAnimal = await _context.Animals.FirstOrDefaultAsync(a=>a.id == id);
            _context.Animals.Remove(getAnimal);
            return await _context.SaveChangesAsync();
        }

        public async Task<Animal> GetAnimalByIdAsync(int id)
        {
            var getAnimal = await _context.Animals.FirstOrDefaultAsync(a => a.id == id);
            return getAnimal;
        }

        public async Task<List<Animal>> GetAnimalListAsync()
        {
            var animalList = await _context.Animals.ToListAsync();
            return animalList;
        }

        public async Task<int> UpdateAnimalAsync(Animal animal)
        {
            _context.Animals.Update(animal);
            return await _context.SaveChangesAsync();
        }
    }
}
