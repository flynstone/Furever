using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Furever.Entities.Models
{
    public class Animal
    {
        // Primary Key
        public int Id { get; set; }
        public string Name { get; set; }
<<<<<<< HEAD

        public string Description { get; set; }

=======
        
>>>>>>> fa6bcd799197a3599aa9164527a85f707aa1a0ea
        /// <summary>
        /// Link tables
        /// </summary>
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        /// <summary>
        /// Link tables
        /// </summary>
        [ForeignKey(nameof(Refuge))]
        public int RefugeId { get; set; }
        public Refuge Refuge { get; set; }
        

        // True or False
        public bool IsAvailable { get; set; }

        // Nullable DoB
        public DateTime? DateOfBirth { get; set; }

        
        public DateTime CreatedDate { get; set; }

        // Collection of user's that liked the animal
        public ICollection<Favorite> Favorites { get; set; }
    }
}
