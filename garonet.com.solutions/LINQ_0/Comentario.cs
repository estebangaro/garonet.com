//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQ_0
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comentario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comentario()
        {
            this.ComentariosHijo = new HashSet<Comentario>();
        }
    
        public int Id { get; set; }
        public string ContenidoComentario { get; set; }
        public Nullable<System.DateTime> Fecha_Creacion { get; set; }
        public Nullable<System.DateTime> Fecha_Modificacion { get; set; }
        public string Usuario_Creacion { get; set; }
        public string Usuario_Modificacion { get; set; }
        public Nullable<int> IdComentarioP { get; set; }
        public string URI { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comentario> ComentariosHijo { get; set; }
        public virtual Comentario ComentarioPadre { get; set; }
    }
}
