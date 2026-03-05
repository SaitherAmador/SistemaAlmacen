namespace SistemaAlmacen
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public Producto(string codigo, string nombre, double precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}