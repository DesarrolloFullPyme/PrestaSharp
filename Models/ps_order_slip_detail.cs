//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrestaSharp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ps_order_slip_detail
    {
        public long id_order_slip { get; set; }
        public long id_order_detail { get; set; }
        public long product_quantity { get; set; }
        public Nullable<decimal> amount_tax_excl { get; set; }
        public Nullable<decimal> amount_tax_incl { get; set; }
    }
}