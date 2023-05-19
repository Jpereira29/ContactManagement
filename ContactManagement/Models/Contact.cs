using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ContactManagement.Models
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Name")]
        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        [Display(Name = "Number")]
        [Required]
        [StringLength(9, MinimumLength = 9)]
        public string ContactNumber { get; set; }

        [Display(Name = "Email")]
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [JsonIgnore]
        public bool IsDeleted { get; set; }
    }
}
