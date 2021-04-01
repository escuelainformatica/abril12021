using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace abril12021.Models
{
    // modelo -> entidad.
    //[Table(name:"TablaProducto")]
    public class Producto
    {
    //    [Column(name:"Cod")]
        public string Codigo {set; get;}
        public string Nombre {set; get;}
        public int Precio {set; get;}

        

        public Producto(string codigo, string nombre, int precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
        }

        public Producto()
        {
        }
    }
}