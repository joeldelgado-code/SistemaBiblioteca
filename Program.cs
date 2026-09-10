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