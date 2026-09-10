class BibliotecaService
{
    private List<Libro> libros = new();
    private List<Usuario> usuarios = new();
    private List<Prestamo> prestamos = new();
    
public void RegistrarLibro(Libro libro)
{
    if (libros.Any(l => l.codigo == libro.codigo))
    {
        throw new Exception("El código del libro ya existe.");
    }

    libros.Add(libro);
}
public void ListarLibros()
{
    foreach (var libro in libros)
    {
        Console.WriteLine($"Código: {libro.codigo}");
        Console.WriteLine($"Título: {libro.titulo}");
        Console.WriteLine($"Autor: {libro.autor}");
        Console.WriteLine($"Categoría: {libro.categoría}");
        Console.WriteLine($"Disponible: {libro.disponibilidad}");
        Console.WriteLine();
    }
}
public Libro? BuscarLibro(int codigo)
{
    return libros.FirstOrDefault(l => l.codigo == codigo);
}
public void EliminarLibro(int codigo)
{
    Libro? libro = BuscarLibro(codigo);

    if (libro == null)
    {
        throw new Exception("El libro no existe.");
    }

    libros.Remove(libro);
}
public void RegistrarPrestamo(int codigoLibro, int codigoUsuario)
{
    Libro? libro = BuscarLibro(codigoLibro);

    if (libro == null)
    {
        throw new Exception("El libro no existe.");
    }

    Usuario? usuario = BuscarUsuario(codigoUsuario);

    if (usuario == null)
    {
        throw new Exception("El usuario no existe.");
    }

    if (!libro.disponibilidad)
    {
        throw new Exception("El libro no está disponible.");
    }

    Prestamo prestamo = new Prestamo(
        codigoLibro,
        codigoUsuario,
        DateTime.Now,
        null
    );

    prestamos.Add(prestamo);
    libro.disponibilidad = false;
}
public Usuario? BuscarUsuario(int codigo)
{
    return usuarios.FirstOrDefault(u => u.codigo == codigo);
}
public void DevolverLibro(int codigoLibro, int codigoUsuario)
{
    Prestamo? prestamo = prestamos.FirstOrDefault(p =>
        p.codigoLibro == codigoLibro &&
        p.codigoUsuario == codigoUsuario &&
        p.fechaDevolucion == null);

    if (prestamo == null)
    {
        throw new Exception("El préstamo no existe.");
    }

    Libro? libro = BuscarLibro(codigoLibro);

    if (libro == null)
    {
        throw new Exception("El libro no existe.");
    }

    prestamos.Remove(prestamo);

    libro.disponibilidad = true;
}
public void ListarPrestamosActivos()
{
    var prestamosActivos = prestamos
        .Where(p => p.fechaDevolucion == null)
        .Select(p => new
        {
            p.codigoLibro,
            p.codigoUsuario,
            p.fechaPrestamo
        });

    foreach (var prestamo in prestamosActivos)
    {
        Console.WriteLine($"Libro: {prestamo.codigoLibro}");
        Console.WriteLine($"Usuario: {prestamo.codigoUsuario}");
        Console.WriteLine($"Fecha: {prestamo.fechaPrestamo}");
        Console.WriteLine();
    }
}
}