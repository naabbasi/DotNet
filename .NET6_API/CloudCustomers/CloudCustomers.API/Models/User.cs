using System.ComponentModel.DataAnnotations;

namespace CloudCustomers.API.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
}
