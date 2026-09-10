BibliotecaService biblioteca = new BibliotecaService();
string[] categorias = { "Novela", "Ciencia", "Historia", "Tecnología" };

while (true)
{
    Console.WriteLine();
    Console.WriteLine("==========================================");
    Console.WriteLine("       SISTEMA DE GESTIÓN DE BIBLIOTECA");
    Console.WriteLine("==========================================");
    Console.WriteLine("1. Registrar libro");
    Console.WriteLine("2. Listar libros");
    Console.WriteLine("3. Ver libros disponibles");
    Console.WriteLine("4. Registrar usuario");
    Console.WriteLine("5. Listar usuarios");
    Console.WriteLine("6. Registrar préstamo");
    Console.WriteLine("7. Devolver libro");
    Console.WriteLine("8. Ver préstamos activos");
    Console.WriteLine("9. Buscar libros por autor");
    Console.WriteLine("10. Buscar libros por categoría");
    Console.WriteLine("11. Listar libros ordenados por título");
    Console.WriteLine("12. Buscar libro por código");
    Console.WriteLine("13. Eliminar libro");
    Console.WriteLine("0. Salir");
    Console.WriteLine("==========================================");
    Console.Write("Seleccione una opción: ");

    string? opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            try
            {
                Console.Write("Código: ");
                int codigo = int.Parse(Console.ReadLine()!);

                Console.Write("Título: ");
                string titulo = Console.ReadLine()!;

                Console.Write("Autor: ");
                string autor = Console.ReadLine()!;

                Console.Write("Categoría: ");
                string categoria = Console.ReadLine()!;

                bool categoriaValida = categorias.Contains(categoria);

                if (!categoriaValida)
                {
                    throw new Exception("La categoría no es válida.");
                }

                Console.Write("¿Está disponible? (true/false): ");
                bool disponibilidad = bool.Parse(Console.ReadLine()!);

                Libro libro = new Libro(
                    codigo,
                    titulo,
                    autor,
                    categoria,
                    disponibilidad
                );

                biblioteca.RegistrarLibro(libro);

                Console.WriteLine("Libro registrado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            break;

        case "2":
            biblioteca.ListarLibros();
            break;

        case "3":
            biblioteca.ListarLibrosDisponibles();
            break;

        case "4":
            try
            {
                Console.Write("Código: ");
                int codigo = int.Parse(Console.ReadLine()!);

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine()!;

                Console.Write("Correo: ");
                string correo = Console.ReadLine()!;

                Usuario usuario = new Usuario(
                    codigo,
                    nombre,
                    correo
                );

                biblioteca.RegistrarUsuario(usuario);

                Console.WriteLine("Usuario registrado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            break;

        case "5":
            biblioteca.ListarUsuarios();
            break;

        case "6":
            try
            {
                Console.Write("Código del libro: ");
                int codigoLibro = int.Parse(Console.ReadLine()!);

                Console.Write("Código del usuario: ");
                int codigoUsuario = int.Parse(Console.ReadLine()!);

                biblioteca.RegistrarPrestamo(
                    codigoLibro,
                    codigoUsuario
                );

                Console.WriteLine("Préstamo registrado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            break;

        case "7":
            try
            {
                Console.Write("Código del libro: ");
                int codigoLibro = int.Parse(Console.ReadLine()!);

                Console.Write("Código del usuario: ");
                int codigoUsuario = int.Parse(Console.ReadLine()!);

                biblioteca.DevolverLibro(
                    codigoLibro,
                    codigoUsuario
                );

                Console.WriteLine("Libro devuelto correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            break;

        case "8":
            biblioteca.ListarPrestamosActivos();
            break;

        case "9":
            Console.Write("Ingrese el autor: ");
            string autorBuscado = Console.ReadLine()!;

            biblioteca.BuscarLibrosPorAutor(autorBuscado);
            break;

        case "10":
            Console.Write("Ingrese la categoría: ");
            string categoriaBuscada = Console.ReadLine()!;

            biblioteca.BuscarLibrosPorCategoria(categoriaBuscada);
            break;

        case "11":
            biblioteca.ListarLibrosOrdenados();
            break;

        case "12":
            Console.Write("Ingrese el código del libro: ");
            int codigoBuscado = int.Parse(Console.ReadLine()!);

            Libro? libroEncontrado = biblioteca.BuscarLibro(codigoBuscado);

            if (libroEncontrado != null)
            {
                Console.WriteLine($"Código: {libroEncontrado.codigo}");
                Console.WriteLine($"Título: {libroEncontrado.titulo}");
                Console.WriteLine($"Autor: {libroEncontrado.autor}");
                Console.WriteLine($"Categoría: {libroEncontrado.categoría}");
                Console.WriteLine($"Disponible: {libroEncontrado.disponibilidad}");
            }
            else
            {
                Console.WriteLine("No se encontró ningún libro con ese código.");
            }

            break;

        case "13":
            try
            {
                Console.Write("Ingrese el código del libro a eliminar: ");
                int codigoEliminar = int.Parse(Console.ReadLine()!);

                biblioteca.EliminarLibro(codigoEliminar);

                Console.WriteLine("Libro eliminado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            break;

        case "0":
            Console.WriteLine("Programa finalizado.");
            return;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}