using GQLTest.Helpers;
using GQLTest.models;
using GraphQL.Types;

namespace GQLTest.Models
{
    public class StatsQuery : ObjectGraphType
    {
        public StatsQuery(ContextServiceLocator contextServiceLocator)
        {

            Field<ListGraphType<PedidoQueryType>>(
                "pedidoquerys",
                resolve: context => contextServiceLocator.PedidoQueryRepository.All());
        }
    }
}
