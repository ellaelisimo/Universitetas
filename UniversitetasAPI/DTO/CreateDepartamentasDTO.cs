using System.ComponentModel.DataAnnotations;

namespace UniversitetasAPI.DTO
{
    public class CreateDepartamentasDTO
    {
        [Required]
        public int Id {  get; set; }
        [Required]
        public string Name { get; set; }

    }
}
