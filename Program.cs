using SistemaAlmacen;

Almacen almacen = new Almacen();
bool salir = false;

// Menú principal con validación de opciones y manejo del flujo
while (!salir)
{
    Console.Clear();
    Console.WriteLine("=== SISTEMA DE ALMACÉN ===");
    Console.WriteLine("1. Registrar producto");
    Console.WriteLine("2. Buscar producto");
    Console.WriteLine("3. Eliminar producto");
    Console.WriteLine("4. Listar productos");
    Console.WriteLine("5. Salir");
    Console.Write("\nSeleccione una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("-- Registrar producto --\n");
            Console.Write("Código: ");
            string codigo = Console.ReadLine();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Precio: ");
            double precio = double.Parse(Console.ReadLine());
            Console.Write("Cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());
            Producto p = new Producto(codigo, nombre, precio, cantidad);
            almacen.AgregarProducto(p);
            break;

        case "2":
            Console.Clear();
            Console.WriteLine("-- Buscar producto --\n");
            Console.Write("Código: ");
            string codigoBuscar = Console.ReadLine();
            Producto encontrado = almacen.BuscarPorCodigo(codigoBuscar);
            if (encontrado != null)
                Console.WriteLine($"\nEncontrado: {encontrado.Codigo} | {encontrado.Nombre} | ${encontrado.Precio} | Cantidad: {encontrado.Cantidad}");
            else
                Console.WriteLine("No se encontró ningún producto.");
            break;

        case "3":
            Console.Clear();
            Console.WriteLine("-- Eliminar producto --\n");
            Console.Write("Código: ");
            string codigoEliminar = Console.ReadLine();
            bool eliminado = almacen.EliminarProducto(codigoEliminar);
            if (eliminado)
                Console.WriteLine("Producto eliminado correctamente.");
            else
                Console.WriteLine("No se encontró ningún producto.");
            break;

        case "4":
            Console.Clear();
            Console.WriteLine("-- Listar productos --\n");
            Console.WriteLine($"Total: {almacen.TotalProductos()}");
            Console.WriteLine("----------------------------");
            foreach (Producto prod in almacen.ObtenerTodos())
                Console.WriteLine($"{prod.Codigo} | {prod.Nombre} | ${prod.Precio} | Cantidad: {prod.Cantidad}");
            break;

        case "5":
            salir = true;
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

    if (!salir)
    {
        Console.WriteLine("\nPresione ENTER para continuar...");
        Console.ReadLine();
    }
}