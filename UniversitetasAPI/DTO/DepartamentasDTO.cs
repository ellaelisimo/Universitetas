
namespace UniversitetasAPI.DTO
{
    public class DepartamentasDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public StudentasDTO[] studentai {get ; set;}
        public PaskaitaDTO[] paskaitos { get ; set;}
    }
}
