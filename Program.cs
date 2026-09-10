Console.WriteLine("Hello, World!");
Console.WriteLine("perra loca");

Libro l1=new Libro(1,"hola","joel","terror",true);
Console.WriteLine (l1.titulo);

Usuario u1=new Usuario(1,"joel","joel@");
Console.WriteLine(u1.nombre);

BibliotecaService biblioteca = new BibliotecaService();

Libro libro1 = new Libro(1, "El Quijote", "Miguel de Cervantes", "Novela", true);

biblioteca.RegistrarLibro(libro1);

biblioteca.ListarLibros();

Usuario usuario1 = new Usuario(1, "Joel", "joel@gmail.com");

biblioteca.RegistrarUsuario(usuario1);
biblioteca.ListarUsuarios();
Usuario? usuarioEncontrado = biblioteca.BuscarUsuario(1);

if (usuarioEncontrado != null)
{
    Console.WriteLine($"Usuario encontrado: {usuarioEncontrado.nombre}");
}
else
{
    Console.WriteLine("Usuario no encontrado.");
}