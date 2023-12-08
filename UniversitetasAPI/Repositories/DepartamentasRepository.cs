using Dapper;
using System.Data;
using System.Data.Common;
using UniversitetasAPI.Interfaces;
using UniversitetasAPI.Models;

namespace UniversitetasAPI.Repositories
{
    public class DepartamentasRepository : IDepartamentasRepository
    {
        private readonly IDbConnection _connection;
        public DepartamentasRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<DepartamentasClass> GetDepartamentai()
        {
            return _connection.Query<DepartamentasClass>("SELECT departamentas_id, departamentas_name FROM departamentas");
        }
        public int CreateDepartamentas(int id, string name)
        {
            string sql = $"INSERT INTO departamentas VALUES (@id, @name)";
            var queryArguments = new
            {
                name = name,
                id = id,
            };

            return _connection.Execute(sql, queryArguments);
        }
        
    }
}
