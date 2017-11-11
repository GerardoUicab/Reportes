using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reportes.Models
{
    public class listaProducto
    {
        public List<Productos> finall()
        {
            List<Productos> lista = new List<Productos>();
            lista.Add(new Productos { id = 1, nombre = "product 1", precio = 100 });
            lista.Add(new Productos { id = 2, nombre = "product 2", precio = 100 });
            lista.Add(new Productos { id = 3, nombre = "product 3", precio = 1000 });
            return lista;
        }
    }
}