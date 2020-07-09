using System.Threading.Tasks;
using System.Collections.Generic;
using GQLTest.Data.models;

namespace GQLTest.Repository.repository
{
    public interface IPedidoQueryRepository
    {
        Task<List<PedidoQuery>> All();
    }
}
