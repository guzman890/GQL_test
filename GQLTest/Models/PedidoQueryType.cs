using GQLTest.Data.models;
using GQLTest.Helpers;
using GraphQL.Types;


namespace GQLTest.models
{
    public class PedidoQueryType : ObjectGraphType<PedidoQuery>
    {
        public PedidoQueryType(ContextServiceLocator contextServiceLocator)
        {
            Field(x => x.IdPedido);
            Field(x => x.IdPedidoQuery);
            Field(x => x.IdSucursal);
            Field(x => x.IdTipoDelivery);
            Field(x => x.IdMoneda);
        }
    }
}
