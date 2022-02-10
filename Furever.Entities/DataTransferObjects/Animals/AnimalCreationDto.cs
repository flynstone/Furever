using System.ComponentModel.DataAnnotations;

namespace Furever.Entities.DataTransferObjects.Animals
{
    public class AnimalCreationDto
    {
        [Required(ErrorMessage = "The field with name {0} is required")]
        [StringLength(50)]
        public string Species { get; set; }
    }
}
