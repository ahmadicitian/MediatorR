using MediatorR.api.Data.CommandHandlers;
using MediatorR.api.Data.QueryHandlers;
using MediatorR.api.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatorR.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AnimalController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //GET: api/animal
        [HttpGet]
        public async Task<List<Animal>> AnimalList()
        {
            var animals = await _mediator.Send(new GetAnimalListQuery());
            return animals;
        }

        //GET: api/animal/{id}
        [HttpGet("{id}")]
        public async Task<Animal> Animal(int id)
        {
            var animal = await _mediator.Send(new GetAnimalByIdQuery() { id = id });
            return animal;
        }

        //POST: api/animal
        [HttpPost]
        public async Task<Animal> AddAnimal(Animal animal)
        {
            var addedEmployee = await _mediator.Send(new CreateAnimalComand(
                        animal.category, animal.name, animal.color, animal.age));
            return addedEmployee;
        }

        //PUT: api/animal/{id}
        [HttpPut]
        public async Task<int> UpdateAnimal(Animal animal)
        {
            var updatedEmployee = await _mediator.Send(new UpdateAnimalCommand(
                        animal.id, animal.category, animal.name, animal.color, animal.age));
            return updatedEmployee;
        }

        //DELETE: api/animal/{id}
        [HttpDelete("{id}")]
        public async Task<int> DeleteAnimal(int id)
        {
            return await _mediator.Send(new DeleteAnimalCommand() { id=id});
        }

    }
}
