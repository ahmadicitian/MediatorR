using MediatorR.api.Data.CommandHandlers;
using MediatorR.api.Models;
using MediatorR.api.Services;
using MediatR;

namespace MediatorR.api.Data.Handlers
{
    public class CreateAnimalHandler : IRequestHandler<CreateAnimalComand, Animal>
    {
        private readonly IAnimalRepository _animalRepository;
        public CreateAnimalHandler(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }
        public async Task<Animal> Handle(CreateAnimalComand request, CancellationToken cancellationToken)
        {
            Animal animal = new Animal
            {
               age = request.Age,
               category = request.Category,
               color = request.Color,
               name = request.Name
            };
            return await _animalRepository.AddAnimalAsync(animal);
        }
    }
}
