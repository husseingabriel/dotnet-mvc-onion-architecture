//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnionArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonAddress
    {
        public int AddressId { get; set; }
        public int PersonId { get; set; }
        public int AddressTypeId { get; set; }
        public string MainStreet { get; set; }
        public string SecondaryStreet { get; set; }
        public string Reference { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
