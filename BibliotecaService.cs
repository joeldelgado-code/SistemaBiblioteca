class BibliotecaService
{
    private List<Libro> libros = new();
    private List<Usuario> usuarios = new();
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
}