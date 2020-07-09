using GQLTest.Data.models;
using GQLTest.Helpers;
using GraphQL.Types;


namespace GQLTest.models
{
    public class PedidoQueryType : ObjectGraphType<PedidoQuery>
    {
        public PedidoQueryType(ContextServiceLocator contextServiceLocator)
        {
            Field(x => x.IdPedidoQuery);
            Field(x => x.IdEmpresaApp);
            Field(x => x.IdPedido);
            Field(x => x.IdEmpresa);
            Field(x => x.DocumentoEmpresa);
            Field(x => x.DenominacionEmpresa);
            Field(x => x.IdSucursal);
            Field(x => x.DenominacionSucursal);
            Field(x => x.IdRepartidor);
            Field(x => x.DocumentoRepartidor);
            Field(x => x.DenominacionRepartidor);
            Field(x => x.IdCliente);
            Field(x => x.DocumentoCliente);
            Field(x => x.DenominacionCliente);
            Field(x => x.IdMoneda);
            Field(x => x.Moneda);
            Field(x => x.IdMetodoPago);
            Field(x => x.MetodoPago);
            Field(x => x.IdTipoDelivery);
            Field(x => x.TipoDelivery);
            Field(x => x.NumeroPedido);
            Field(x => x.FechaPedido);
            Field(x => x.FechaEntrega);
            Field(x => x.TelefonoRetiro);
            Field(x => x.UbicacionRetiro);
            Field(x => x.ReferenciaRetiro);
            Field(x => x.LatitudRetiro);
            Field(x => x.LongitudRetiro);
            Field(x => x.TelefonoEntrega);
            Field(x => x.UbicacionEntrega);
            Field(x => x.ReferenciaEntrega);
            Field(x => x.LatitudEntrega);
            Field(x => x.LongitudEntrega);
            Field(x => x.MontoDelivery);
            Field(x => x.MontoDescuento);
            Field(x => x.MontoSubtotal);
            Field(x => x.MontoTotal);
            Field<IntGraphType>("IdEstadoPedido", resolve: context => context.Source.IdEstadoPedido);
            // Field(x => x.IdEstadoPedido);
            Field(x => x.EstadoPedido);
            Field(x => x.LogUsuariocrea);
            Field(x => x.LogUsuariomodif);
            Field(x => x.LogFechacrea);
            Field(x => x.LogFechamodif);
            // Field(x => x.LogEstado);
            Field<IntGraphType>("LogEstado", resolve: context => context.Source.LogEstado);
        }
    }
}