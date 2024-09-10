using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp_y_mvc.Models
{
    public class Repository
    {
        //Centralizar operaciones: CRUD

        public Demo getDemo()
        {
            return new Demo { Message = "Hello", MessageHTML = "<h1>Buenas</h1>" };
        }

        //Conectarse a la base de datos.
        //Ejecutar la operacion.
        //Debolver un resultado de la operación al usuario.
    }
}