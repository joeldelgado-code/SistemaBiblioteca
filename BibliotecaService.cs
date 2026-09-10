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
public void RegistrarUsuario(Usuario usuario)
{
    if (usuarios.Any(u => u.codigo == usuario.codigo))
    {
        throw new Exception("El código del usuario ya existe.");
    }

    usuarios.Add(usuario);
}
public void ListarUsuarios()
{
    foreach (var usuario in usuarios)
    {
        Console.WriteLine($"Código: {usuario.codigo}");
        Console.WriteLine($"Nombre: {usuario.nombre}");
        Console.WriteLine($"Correo: {usuario.correo}");
        Console.WriteLine();
    }
}
public Usuario? BuscarUsuario(int codigo)
{
    return usuarios.FirstOrDefault(u => u.codigo == codigo);
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