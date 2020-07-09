using System.Threading.Tasks;
using System.Collections.Generic;
using GQLTest.Data.models;

namespace GQLTest.Repository.repository
{
    public class PedidoQueryRepository : IPedidoQueryRepository
    {
        private readonly StatsContext _db;

        public PedidoQueryRepository(StatsContext db)
        {
            _db = db;
        }

        public async Task<List<PedidoQuery>> All()
        {
            //return await _db.PedidoQuerys;
            return null;
        }
    }
}
