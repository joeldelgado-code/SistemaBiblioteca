class Libro
{
    //Registrar libros: título, autor, categoría, código y disponibilidad.

    public string titulo {get;set;}
    public string autor {get;set;}
    public string categoría {get;set;}
    public int codigo {get;set;}
    public bool disponibilidad {get;set;}
    public Libro(int codigo, string titulo,string autor,string categoría,bool disponibilidad)
    {
        this.codigo = codigo;
        this.titulo = titulo;
        this.autor = autor;
        this.categoría=categoría;
        this.disponibilidad=disponibilidad;
    }
}