using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class EmpleadoServicio
    {
        private static List<Empleado> Lista = new List<Empleado>();

        public List<Empleado> ObtenerTodos()
        {
            return Lista;
        }

        public void Crear(Empleado emp)
        {
            int maxId = 0;
            if (Lista.Count > 0)
            {
                maxId = Lista.Max(o => o.Id);
            }

            emp.Id = maxId + 1;

            emp.UniqueID = Guid.NewGuid();

            Lista.Add(emp);
        }

        public void EliminarConFor(int id)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                Empleado emp = Lista[i];
                if (emp.Id == id)
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

        public Empleado ObtenerPorId(int id)
        {
            //Lista.Where(o => o.Apellido == "argento").FirstOrDefault();
            return Lista.Find(o => o.Id == id);
        }

        public void Modificar(Empleado emp)
        {
            Empleado empActual = ObtenerPorId(emp.Id);
            empActual.Nombre = emp.Nombre;
            empActual.Apellido = emp.Apellido;
        }
    }
}
