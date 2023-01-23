using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MLGTest.Entities
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string Name { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        
        public virtual Department? Department { get; set; }
        [JsonIgnore]
        public int Department_ID { get; set; }

    }
}
