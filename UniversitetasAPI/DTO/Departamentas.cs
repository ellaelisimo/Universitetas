
namespace UniversitetasAPI.DTO
{
    public class Departamentas
    {
        public int id { get; set; }
        public string name { get; set; }
        public Studentas[] studentai {get ; set;}
        public Paskaita[] paskaitos { get ; set;}
    }
}
