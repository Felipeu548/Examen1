//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public int Id { get; set; }
        public Nullable<int> Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Tipo { get; set; }
    
        public virtual Pedido Pedido { get; set; }
        public virtual TipoDeCliente TipoDeCliente { get; set; }
    }
}