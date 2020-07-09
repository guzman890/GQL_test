using System.Threading.Tasks;
using System.Collections.Generic;
using GQLTest.Data.models;
using Microsoft.EntityFrameworkCore;
using System;

namespace GQLTest.Repository.repository
{
    public class PedidoQueryRepository : IPedidoQueryRepository
    {
        private readonly DBYoinTestContext _db;

        public PedidoQueryRepository(DBYoinTestContext db)
        {
            _db = db;
        }

        public async Task<List<PedidoQuery>> All()
        {
            //return await _db.PedidoQuerys;
            try
            {
                var x = await _db.PedidoQuery.ToListAsync();
                return x;
            }
            catch(Exception ex){
                throw ex;
            }
        }
    }
}
