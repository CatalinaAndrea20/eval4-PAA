using eval4_PAA.Models;

Console.WriteLine("Demostraciones de LinQ");

using (EFContext bd = new EFContext())
{

    //1) Se obtiene ID que este entre 1 y 2 ordenados DESC
    /* var albumesOrdenados = bd.Autores
       .Where(x => x.Id >= 1 && x.Id <= 2)
       .OrderByDescending(x => x.Nombre)
       .ToList();
    Console.WriteLine(albumesOrdenados.Count);*/

    //2) Promedio de las paginas de la tabla libro
    /*double promedioPaginas = bd.Libros.Average(y => y.Paginas);
    Console.WriteLine(promedioPaginas);*/


    //3) Insertar nuevo registro 
    /*Autor nuevoAutor = new Autor();
    nuevoAutor.Id = 0; // Dejar en cero si no existe ID como en una inserción
    nuevoAutor.Nombre = "Isabel Allende";
    nuevoAutor.FechaNacimiento = Convert.ToDateTime("1942-08-02");
    nuevoAutor.EstaVivo = null;

    bd.Autores.Add(nuevoAutor);
    bd.SaveChanges();*/

    // 4) Actualizacion de dos campos de la tabla libro, se edito el campo titulo y pagina
    /*var libroEditar = bd.Libros.FirstOrDefault(x => x.Id == 2);
    libroEditar.Titulo = "Pantaleon y las visitadoras VOL2";
    libroEditar.Paginas = 600;
    bd.Libros.Update(libroEditar);
    bd.SaveChanges();*/

    // 5) Eliminacion de un registro de la tabla libro
    /*var libroEliminar = bd.Libros.FirstOrDefault(x => x.Id == 30);
    bd.Libros.Remove(libroEliminar);
    bd.SaveChanges();*/

    // 6) Mostrar registro desde rango fecha en tabla autor
    /*var autorPrimer = db.Autores.FirstOnDefault( x => x.FechaNacimiento == DateTime.Parse("2022-09-21 00:00:00"));*/
}


