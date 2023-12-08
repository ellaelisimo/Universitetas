using Dapper;
using System.Data;
using UniversitetasAPI.Interfaces;
using UniversitetasAPI.Models;

namespace UniversitetasAPI.Repositories
{
    public class PaskaitaRepository : IPaskaitaRepository
    {
        private readonly IDbConnection _connection;
        public PaskaitaRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<PaskaitaClass> GetPaskaitos()
        {
            return _connection.Query<PaskaitaClass>("SELECT paskaita_id, paskaita_name FROM paskaita");
        }
        public IEnumerable<PaskaitaClass> GetPaskaitos(int departamentas_id)
        {
            return _connection.Query<PaskaitaClass>("SELECT paskaita_id, paskaita_name, departamentas_id FROM paskaita" +
                " WHERE departamentas_id = @id", new { id = departamentas_id });
        }
        public int CreatePaskaita(int id, int departamentas_id, string name)
        {
            string sql = $"INSERT INTO paskaita VALUES (@id, @name)";

            var queryArguments = new
            {
                name = name,
                id = id,
            };

            if (_connection.Execute(sql, queryArguments) == 0)
            {
                return 0;
            };

            string sqlOne = $"INSERT INTO departamentai_paskaitos VALUES (@departamentas_id, @paskaita_id)";

            var queryArgumentsOne = new
            {
                departamentas_id = departamentas_id,
                paskaita_id = id,
            };

            var insertOne = _connection.Execute(sqlOne, queryArgumentsOne);
            return insertOne;
        }
        public int UpdateDepartamentasWithPaskaitos(int id, int paskaita_id)
        {
            string sql = $"UPDATE paskaita SET departamentas_id = @id WHERE paskaita_id = @paskaita_id";
            var queryArguments = new
            {
                id = id,
                studentas_id = paskaita_id
            };
            return _connection.Execute(sql, queryArguments);
        }

    }
}
