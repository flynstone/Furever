using System;
using System.ComponentModel.DataAnnotations;

namespace Furever.Entities.DataTransferObjects.Animals
{
    public class AnimalCreationDto
    {
        [Required(ErrorMessage = "The field with name {0} is required")]
        [StringLength(50)]
        public string Name { get; set; }

        public int CategoryId { get; set; }
        public int OwnerId { get; set; }
        public bool IsAvailable { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
