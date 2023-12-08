using System.ComponentModel.DataAnnotations;

namespace UniversitetasAPI.DTO
{
    public class CreatePaskaitosDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int departamentasId { get; set; }
    }
}
