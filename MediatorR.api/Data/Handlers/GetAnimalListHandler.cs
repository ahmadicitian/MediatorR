using MediatorR.api.Data.QueryHandlers;
using MediatorR.api.Models;
using MediatorR.api.Services;
using MediatR;

namespace MediatorR.api.Data.Handlers
{
    public class GetAnimalListHandler : IRequestHandler<GetAnimalListQuery, List<Animal>>
    {
        private readonly IAnimalRepository _animalRepo;
        public GetAnimalListHandler(IAnimalRepository animalRepo)
        {
            _animalRepo = animalRepo;
        }
        public async Task<List<Animal>> Handle(GetAnimalListQuery request, CancellationToken cancellationToken)
        {
            return await _animalRepo.GetAnimalListAsync();
        }
    }
}
