using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
   public class ProductoServicio
    {
        private static List<Producto> Lista = new List<Producto>();

        public List<Producto> ObtenerTodos()
        {
            return Lista;
        }

        public void Crear(Producto producto)
        {
            int maxId = 0;
            if (Lista.Count > 0)
            {
                maxId = Lista.Max(o => o.Id);
            }

            producto.Id = maxId + 1;

            producto.UniqueID = Guid.NewGuid();

            Lista.Add(producto);
        }

        public void EliminarConFor(int id)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                Producto producto = Lista[i];
                if (producto.Id == id)
                {
                    Lista.RemoveAt(i);
                    return;
                }
            }
        }

        public void Eliminar(int id)
        {
            Lista.RemoveAll(o => o.Id == id);
        }

        public Producto ObtenerPorId(int id)
        {
            //Lista.Where(o => o.Apellido == "argento").FirstOrDefault();
            return Lista.Find(o => o.Id == id);
        }

        public void Modificar(Producto producto)
        {
            Producto productoActual = ObtenerPorId(producto.Id);
            productoActual.Descripcion = producto.Descripcion;
            productoActual.Precio = producto.Precio;
        }
    }
}
