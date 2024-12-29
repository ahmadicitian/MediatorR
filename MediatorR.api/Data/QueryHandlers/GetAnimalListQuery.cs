using MediatorR.api.Models;
using MediatR;

namespace MediatorR.api.Data.QueryHandlers
{
    public class GetAnimalListQuery : IRequest<List<Animal>>
    {
    }
}
