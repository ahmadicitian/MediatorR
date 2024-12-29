using MediatorR.api.Data.QueryHandlers;
using MediatorR.api.Models;
using MediatorR.api.Services;
using MediatR;

namespace MediatorR.api.Data.Handlers
{
    public class GetAnimalHandler : IRequestHandler<GetAnimalByIdQuery, Animal>
    {
        private readonly IAnimalRepository _animalRepository;
        public GetAnimalHandler(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }
        public async Task<Animal> Handle(GetAnimalByIdQuery request, CancellationToken cancellationToken)
        {
            return await _animalRepository.GetAnimalByIdAsync(request.id);
        }
    }
}
