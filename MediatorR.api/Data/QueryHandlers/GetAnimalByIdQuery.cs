using MediatorR.api.Models;
using MediatR;

namespace MediatorR.api.Data.QueryHandlers
{
    public class GetAnimalByIdQuery : IRequest<Animal>
    {
        public int id { get; set; }
    }
}
