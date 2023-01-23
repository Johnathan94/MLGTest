using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace MLGTest.Entities
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [JsonIgnore]
        public virtual ICollection<Employee>? Employees { get; set; }
    }
}