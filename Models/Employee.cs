using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(18, 65)]
        public int Age { get; set; }

        [StringLength(200)]
        public string Position { get; set; }
    }
}
