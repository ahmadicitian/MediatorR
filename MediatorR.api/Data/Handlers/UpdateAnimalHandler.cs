using MediatorR.api.Data.CommandHandlers;
using MediatorR.api.Services;
using MediatR;

namespace MediatorR.api.Data.Handlers
{
    public class UpdateAnimalHandler : IRequestHandler<UpdateAnimalCommand, int>
    {
        private readonly IAnimalRepository _animalRepository;
        public UpdateAnimalHandler(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }
        public async Task<int> Handle(UpdateAnimalCommand request, CancellationToken cancellationToken)
        {
            var existAnimal = await _animalRepository.GetAnimalByIdAsync(request.Id);
            if (existAnimal == null) return default;
            existAnimal.name = request.Name;
            existAnimal.color = request.Color;
            existAnimal.category = request.Category;
            existAnimal.age = request.Age;
            return await _animalRepository.UpdateAnimalAsync(existAnimal);
        }
    }
}
