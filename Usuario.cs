class Usuario
{
    //Registrar usuarios: identificador, nombre y correo.


    public string nombre {get;set;}
    public string correo {get;set;}
    public int codigo {get;set;}
    public Usuario(int codigo,string nombre,string correo)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.correo=correo;
    }
}