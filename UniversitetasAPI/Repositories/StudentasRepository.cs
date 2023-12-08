using System.Data;
using UniversitetasAPI.Models;
using Dapper;
using UniversitetasAPI.Interfaces;
using UniversitetasAPI.DTO;

namespace UniversitetasAPI.Repositories
{
    public class StudentasRepository : IStudentasRepository
    {
        private readonly IDbConnection _connection;
        public StudentasRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<StudentasClass> GetStudentai()
        {
            return _connection.Query<StudentasClass>("SELECT studentas_id, studentas_name, studentas_lastname, departamentas_id FROM studentas");
        }
        public IEnumerable<StudentasClass> GetStudentai(int departamentas_id)
        {
            return _connection.Query<StudentasClass>("SELECT studentas_id, studentas_name, studentas_lastname, departamentas_id FROM studentas" +
                " WHERE departamentas_id = @id", new { id = departamentas_id });
        }
        public int UpdateDepartamentasWithStudentai(int id, int studentas_id)
        {
            string sql = $"UPDATE studentas SET departamentas_id = @id WHERE studentas_id = @studentas_id";
            var queryArguments = new
            {
                id = id,
                studentas_id = studentas_id
            };
            return _connection.Execute(sql, queryArguments);
        }
        public int GetStudentasWithPaskaitos(int studentas_id)
        {
            string sql = $"SELECT * FROM studentas WHERE studentas_id = @studentas_id";

            var queryArguments = new
            {
                studentas_id = studentas_id,
            };
            return _connection.Execute(sql, queryArguments);
        }
    }
}
