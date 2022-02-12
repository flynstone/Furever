
using System;

namespace Furever.Entities.DataTransferObjects.Animals
{
    public class AnimalDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Category { get; set; }
        public string User { get; set; }
        public bool IsAvailable { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
