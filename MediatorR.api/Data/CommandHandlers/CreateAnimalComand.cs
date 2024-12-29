using MediatorR.api.Models;
using MediatR;

namespace MediatorR.api.Data.CommandHandlers
{
    public class CreateAnimalComand : IRequest<Animal>
    {
        public CreateAnimalComand(string category, string name, string color, int age)
        {
            Category = category;
            Name = name;
            Color = color;
            Age = age;
        }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
    }
}
