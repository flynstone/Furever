using System;

namespace Furever.Entities.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Species { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
