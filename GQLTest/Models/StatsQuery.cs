using GQLTest.Helpers;
using GQLTest.models;
using GraphQL.Types;
using GQLTest.Repository.repository;

namespace GQLTest.Models
{
    public class StatsQuery : ObjectGraphType
    {
        public StatsQuery(IPedidoQueryRepository pedidoQueryRepository )
        {

            Field<ListGraphType<PedidoQueryType>>(
                "pedidoquerys",
                resolve: context => pedidoQueryRepository.All());
            Field<PedidoQueryType>(
                "pedido",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => pedidoQueryRepository.Get(context.GetArgument<int>("id")));
            
        }
        
    }
}
