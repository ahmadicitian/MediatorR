using MediatR;

namespace MediatorR.api.Data.CommandHandlers
{
    public class DeleteAnimalCommand : IRequest<int>
    {
        public int id { get; set; }
    }
}
