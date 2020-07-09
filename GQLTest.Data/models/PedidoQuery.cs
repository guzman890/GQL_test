using System;
using System.Collections.Generic;

namespace GQLTest.Data.models
{
    public partial class PedidoQuery
    {
        public int IdPedidoQuery { get; set; }
        public int IdEmpresaApp { get; set; }
        public int IdPedido { get; set; }
        public int IdEmpresa { get; set; }
        public string DocumentoEmpresa { get; set; }
        public string DenominacionEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string DenominacionSucursal { get; set; }
        public int? IdRepartidor { get; set; }
        public string DocumentoRepartidor { get; set; }
        public string DenominacionRepartidor { get; set; }
        public int IdCliente { get; set; }
        public string DocumentoCliente { get; set; }
        public string DenominacionCliente { get; set; }
        public int IdMoneda { get; set; }
        public string Moneda { get; set; }
        public int IdMetodoPago { get; set; }
        public string MetodoPago { get; set; }
        public int IdTipoDelivery { get; set; }
        public string TipoDelivery { get; set; }
        public int NumeroPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string TelefonoRetiro { get; set; }
        public string UbicacionRetiro { get; set; }
        public string ReferenciaRetiro { get; set; }
        public decimal LatitudRetiro { get; set; }
        public decimal LongitudRetiro { get; set; }
        public string TelefonoEntrega { get; set; }
        public string UbicacionEntrega { get; set; }
        public string ReferenciaEntrega { get; set; }
        public decimal LatitudEntrega { get; set; }
        public decimal LongitudEntrega { get; set; }
        public decimal MontoDelivery { get; set; }
        public decimal MontoDescuento { get; set; }
        public decimal MontoSubtotal { get; set; }
        public decimal MontoTotal { get; set; }
        public short IdEstadoPedido { get; set; }
        public string EstadoPedido { get; set; }
        public string LogUsuariocrea { get; set; }
        public string LogUsuariomodif { get; set; }
        public DateTime LogFechacrea { get; set; }
        public DateTime LogFechamodif { get; set; }
        public short LogEstado { get; set; }
    }
}
