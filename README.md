````markdown
# Sistema de Gestión de Biblioteca

## Descripción

Este proyecto es un sistema de gestión de biblioteca desarrollado en C# con .NET 10.

El sistema permite registrar y administrar libros, usuarios y préstamos de libros.

## Funcionalidades

- Registrar libros.
- Listar libros.
- Ver libros disponibles.
- Registrar usuarios.
- Listar usuarios.
- Registrar préstamos.
- Devolver libros.
- Ver préstamos activos.
- Buscar libros por autor.
- Buscar libros por categoría.
- Listar libros ordenados por título.
- Buscar libros por código.
- Eliminar libros.

## Tecnologías utilizadas

- C#
- .NET 10
- Visual Studio Code
- Git y GitHub

## Estructura del proyecto

- `Program.cs` → Contiene el menú principal y la interacción con el usuario.
- `Libro.cs` → Clase que representa los libros.
- `Usuario.cs` → Clase que representa los usuarios.
- `Prestamo.cs` → Registro de los préstamos.
- `BibliotecaService.cs` → Contiene las operaciones principales de la biblioteca.
- `IPrestable.cs` → Interfaz para las operaciones de préstamo y devolución.

## Cómo ejecutar el proyecto

1. Tener instalado .NET 10.

2. Abrir una terminal en la carpeta del proyecto.

3. Ejecutar el siguiente comando:

```bash
dotnet run
````

4. Seleccionar una opción del menú.

## Reglas del sistema

* No se pueden registrar dos libros con el mismo código.
* No se pueden registrar dos usuarios con el mismo código.
* No se puede prestar un libro que no exista.
* No se puede prestar un libro que no esté disponible.
* No se puede devolver un préstamo que no exista.
* Las categorías permitidas son Novela, Ciencia, Historia y Tecnología.
* Los errores controlados se muestran al usuario sin cerrar el programa.

```
```
