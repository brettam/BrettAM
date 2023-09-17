
using System.ComponentModel.DataAnnotations;

namespace MyApi.Models
{
    public class MyContactInfo
    {
        [Key]
        public Guid UserID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? SecondaryEmail { get; set; }
        public string? Phone { get; set; }
    }

}
