using MediatorR.api.Data.CommandHandlers;
using MediatorR.api.Services;
using MediatR;

namespace MediatorR.api.Data.Handlers
{
    public class DeleteAnimalHandler : IRequestHandler<DeleteAnimalCommand, int>
    {
        private readonly IAnimalRepository _animalRepository;
        public DeleteAnimalHandler(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }
        public async Task<int> Handle(DeleteAnimalCommand request, CancellationToken cancellationToken)
        {
            var existAnimal = await _animalRepository.GetAnimalByIdAsync(request.id);
            if (existAnimal == null) return default;
            return await _animalRepository.DeleteAnimalAsync(request.id);
        }
    }
}
