using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Furever.Entities.DataTransferObjects.Animals;
using Furever.Entities.Models;
using Furever.LoggerService;
using Furever.Repositories.Interfaces;

namespace Furever.Api.Controllers
{
    [Route("api/animals")]
    [ApiController]
    public class AnimalsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AnimalsController(IUnitOfWork unitOfWork, ILoggerManager logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        // api/animals
        [Authorize] // This is needed to allow authorized users, we could of added [AllowAnonymous] instead to allow anyone to view information (Make it Public)
        [HttpGet]
        public async Task<IActionResult> GetAnimals()
        {
            // Get animals from repository, store the result in animals variable
            var animals = await _unitOfWork.Animal.GetAnimals();

            // Map Data Transfer Object To Entity (see Extensions/MappingProfile.cs), 
            var animalDto = _mapper.Map<IEnumerable<AnimalDto>>(animals);

            // Return Animals 
            return Ok(animalDto);
        }

        // api/animals/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<AnimalDto>> GetAnimal(int id)
        {
            // Get animal by id
            var animal = await _unitOfWork.Animal.GetAnimal(id);

            // Error Handler, if id not found return message to the logger
            if (animal == null)
            {
                _logger.LogError($"Animal with id: {id} doesn't exist in the database");
                return NotFound();
            }
            else
            {
                // Map Animal to Data Transfer Object if id is found in the database
                return _mapper.Map<AnimalDto>(animal);
            }
        }

        // api/animals
        [HttpPost]
        public async Task<ActionResult> CreateAnimal([FromBody] AnimalCreationDto animal)
        {
            // Handle empty object request
            if (animal == null)
            {
                _logger.LogError("AnimalCreationDto object sent from client is null.");
                return BadRequest("AnimalCreationDto object is null.");
            }

            // Map Animal to Data Transfer Object
            var animalEntity = _mapper.Map<Animal>(animal);

            // Create and save data to database
            await _unitOfWork.Animal.CreateAnimal(animalEntity);
            await _unitOfWork.SaveAsync();

            // Map Data Transfer Object to Entity, store the content in variable animalToReturn
            var animalToReturn = _mapper.Map<AnimalDto>(animalEntity);

            return CreatedAtRoute("Id", new {id = animalToReturn.Id }, animalToReturn);
        }

        // api/animals/5
        [HttpPut("{id:int}")]
        public async Task<ActionResult> EditAnimal(int id, [FromBody] AnimalCreationDto animal)
        {
            // Error handler, log error if no animal found with selected id
            if (animal == null)
            {
                _logger.LogError($"Animal with id: {id} doesn't exist in the database");
                return NotFound();
            }

            // If animal id is found store it in variable  
            var animalEntity = HttpContext.Items["animal"] as Animal;

            // Map Entity to Data Transfer Object, save and return
            _mapper.Map(animalEntity, animal);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }

        // api/animals/5
        [HttpDelete]
        public async Task<ActionResult> DeleteAnimal(int id)
        {
            // Error handler if animal not found in db
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Animal with id: {id} doesn't exist in the database");
                return NotFound();
            }

            // Store animal in variable animal
            var animal = HttpContext.Items["animal"] as Animal;

            // Delete animal, save then return
            await _unitOfWork.Animal.DeleteAnimal(animal);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}
