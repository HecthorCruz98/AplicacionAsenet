namespace AplicacionAsenet.Models
{
    public class ProductoModel
    {
        public int Id_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public int Stock { get; set; }
        public int Pedido_Stock { get; set; }
        public decimal Precio { get; set; }
    }
}
