using MediatorR.api.Models;
using MediatR;

namespace MediatorR.api.Data.CommandHandlers
{
    public class UpdateAnimalCommand : IRequest<int>
    {
        public UpdateAnimalCommand(int id, string name, string category, string color, int age) 
        { 
            Id = id;
            Name = name;
            Category = category;
            Color = color;
            Age = age;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }
        public int Age { get; set; }
    }
}
