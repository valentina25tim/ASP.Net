using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABP_Entity.Entities.Car;
using Microsoft.Extensions.Configuration;
using Dapper;
using Microsoft.Data.SqlClient;
using ABP_Dal.DataBase;
using ABP_Dal.Parsing;

namespace ABP_Dal.Repositories
{
    public class CarRepository : ICarRepository<Car>
    {
        DataBaseRepository dataBase = new DataBaseRepository();
        Parser parser = new Parser();

        public Task<Car> Add(Car entity, CancellationToken ct)
        {
            dataBase.OpenConnection();

            for( var i = 0; i < parser.DivNames.Count; i++ )
            {
                var addCommand =
                $"INSERT INTO Cars (Name) VALUES ('{parser.DivNames.ElementAt(i)}')";

                var command = new SqlCommand(addCommand, dataBase.GetConnection());
                command.ExecuteNonQuery();
            }
            throw new NotImplementedException();
        }

        public Task<Car> Delete(int Id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetById(int Id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<List<Car>> GetFull(CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<List<Car>> Parse()
        {
            throw new NotImplementedException();
        }

        public Task<List<Car>> Print()
        {
            throw new NotImplementedException();
        }

        public Task<Car> Update(Car entity, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
