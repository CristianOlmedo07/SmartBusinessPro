using System;
using System.Collections.Generic;
using System.Text;

namespace EFSmarBisnessPro
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaIngreso { get; set; }
        //CREACION DE SUS CLASES FORANEAS
        public int CategoriaId { get; set; }
        public int ProveedorId { get; set; }
        //CREACION DE LAS PROPIEDADES DE NAVEGACION
        public Categoria Categoria { get; set; }
       public proveedor Proveedor { get; set; }
    }
}
