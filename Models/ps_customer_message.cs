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
    
    public partial class ps_customer_message
    {
        public long id_customer_message { get; set; }
        public Nullable<int> id_customer_thread { get; set; }
        public Nullable<long> id_employee { get; set; }
        public string message { get; set; }
        public string file_name { get; set; }
        public Nullable<int> ip_address { get; set; }
        public string user_agent { get; set; }
        public System.DateTime date_add { get; set; }
        public sbyte @private { get; set; }
        public bool read { get; set; }
    }
}