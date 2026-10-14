using System;
using System.Collections.Generic;
using System.Text;

namespace EFSmarBisnessPro
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}
