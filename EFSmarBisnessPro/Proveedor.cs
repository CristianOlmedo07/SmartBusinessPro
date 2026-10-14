using System;
using System.Collections.Generic;
using System.Text;

namespace EFSmarBisnessPro
{
    public class proveedor
    {
        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; } = new Categoria();
    }
}
