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
    
    public partial class ps_stock_available
    {
        public long id_stock_available { get; set; }
        public long id_product { get; set; }
        public long id_product_attribute { get; set; }
        public long id_shop { get; set; }
        public long id_shop_group { get; set; }
        public int quantity { get; set; }
        public bool depends_on_stock { get; set; }
        public bool out_of_stock { get; set; }
    }
}