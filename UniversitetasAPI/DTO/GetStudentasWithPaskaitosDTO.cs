namespace UniversitetasAPI.DTO
{
    public class GetStudentasWithPaskaitosDTO
    {
        public int studentas_id { get; set; }
        public string studentas_name { get; set; }
        public string studentas_lastname { get; set; }
        public int departamentas_id { get; set; }
        public string departamentas_name { get; set; }
        public int paskaita_id { get; set; }
        public string paskaita_name { get; set; }
    }
}
