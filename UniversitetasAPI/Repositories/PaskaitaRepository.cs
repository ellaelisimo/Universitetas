using System.Data;
using UniversitetasAPI.Models;
using Dapper;
using UniversitetasAPI.Interfaces;

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
    }
}
