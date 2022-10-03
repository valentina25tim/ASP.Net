using IlCats_Application.Contracts;
using IlCats_Domain.Entity.Car;
namespace Ilcats_Persistence.Repositories
{
    public class ModelCarRepository : BaseRepository<ModelCar>, IModelCarRepository
    {
        public ModelCarRepository(IlcatsDbContext dbContext) : base(dbContext)
        {
        }

        //TODO here to add some specific queries
    }
}
