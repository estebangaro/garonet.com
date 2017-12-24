using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea instancia de DbContext, para realizar consultas mediante EF 6 y LINQ to Entities.
            GaroNetComDBContext DbContext = new GaroNetComDBContext();
            // Se obtienen todos los registros de comentarios del contexto de datos
            // y se "cachan" en memoria en una referencia de interfaz IEnumerable<>.
            IEnumerable<Comentario> Comentarios = DbContext.Comentarios.AsEnumerable();
            // Se realiza consulta LINQ to Objects para recuperar los últimos 5 comentarios
            IEnumerable<Comentario> UltimosComentarios = (from comentario in Comentarios
                                                         orderby comentario.Fecha_Creacion descending
                                                         select comentario).Take(5);
            Console.WriteLine("Últimos 5 comentarios realizados...");
            foreach (var Comentario in UltimosComentarios)
            {
                Console.WriteLine($"Comentario [{Comentario.Id}]: {Comentario.ContenidoComentario}" +
                    $"{Environment.NewLine}Realizado por: {Comentario.Email}" +
                    $"{Environment.NewLine}El día: {Comentario.Fecha_Creacion}");
            }
        }
    }
}
