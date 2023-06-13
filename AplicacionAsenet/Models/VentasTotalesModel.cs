using System;

namespace AplicacionAsenet.Models
{
    public class VentasTotalesModel
    {
        public string Nombre_Producto { get; set; }
        public string Tipo_Venta { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha_venta { get; set; }
        public decimal Valor_Venta { get; set; }
    }
}
