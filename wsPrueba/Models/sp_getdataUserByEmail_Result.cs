//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wsPrueba.Models
{
    using System;
    
    public partial class sp_getdataUserByEmail_Result
    {
        public int idUser { get; set; }
        public string nameUser { get; set; }
        public string emailUser { get; set; }
        public string passwordUser { get; set; }
        public Nullable<int> idCity { get; set; }
        public string nameCity { get; set; }
        public string idCountry { get; set; }
        public Nullable<bool> notifyMail { get; set; }
        public string numberPhone { get; set; }
    }
}