using System.ComponentModel.DataAnnotations;

namespace smartwallet1.web.Data.Entities
{
    public class Customer: BaseEntity <Guid>
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public string MiddleName { get; set; }
        
       [Required]
        public DateTime BirthDate { get; set; }

        public MaritalStatus   Status { get; set; } 
        public Gender Gender { get; set; }

        [Required]
        public string Country { get; set; }


        [Required]
        public string State { get; set; }


        [Required]
        public string City { get; set; }


    }
}
