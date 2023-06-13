using System;

namespace AplicacionAsenet.Models
{
    public class VentaModel
    {
        public int Id_Venta { get; set; }
        public int Id_Producto { get; set; }
        public int Id_cliente { get; set; }
        public int Id_TipoVenta { get; set; }
        public decimal Valor_Venta { get; set; }
        public DateTime Fecha_venta { get; set; }
        public int Cantidad { get; set; }
        public string Mensaje { get; set; }


    }
}
