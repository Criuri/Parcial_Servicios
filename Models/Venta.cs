//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Parcial_Servicios.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        public int id_venta { get; set; }
        public int id_agencia { get; set; }
        public int id_cliente { get; set; }
        public int id_computador { get; set; }
        public Nullable<System.DateTime> fecha_venta { get; set; }
        public Nullable<decimal> precio { get; set; }
    
        public virtual Agencia Agencia { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Computador Computador { get; set; }
    }
}
