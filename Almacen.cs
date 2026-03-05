namespace SistemaAlmacen
{
  public class Almacen
 {
  private List<Producto> _productos;

    public Almacen()
    {
     _productos = new List<Producto>();
    }

    public bool AgregarProducto(Producto producto)
      {
        if (_productos.Exists(p => p.Codigo == producto.Codigo))
        {
         Console.WriteLine("Ya existe un producto con ese código.");
           return false;
        }
      _productos.Add(producto);
         Console.WriteLine("Producto registrado exitosamente.");
            return true;
      }

    public Producto BuscarPorCodigo(string codigo)
    {
     return _productos.Find(p => p.Codigo == codigo);
      }
    public bool EliminarProducto(string codigo)
    {
        int removidos = _productos.RemoveAll(p => p.Codigo == codigo);
        return removidos > 0;
    }

    public List<Producto> ObtenerTodos()
    {
        return _productos;
    }

    public int TotalProductos()
        {
            return _productos.Count;
        }

    }
}