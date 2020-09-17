using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public Guid UniqueID { get; set; }
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }
}
