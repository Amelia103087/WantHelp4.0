//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P.V.WantHelp_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class sesiones
    {
        public sesiones()
        {
            this.archivos = new HashSet<archivos>();
            this.mensajes = new HashSet<mensajes>();
            this.Respuestas_Chat = new HashSet<Respuestas_Chat>();
        }
    
        public int id { get; set; }
        public string titulo { get; set; }
        public string descriocion { get; set; }
        public int idCu { get; set; }
    
        public virtual ICollection<archivos> archivos { get; set; }
        public virtual Cursos Cursos { get; set; }
        public virtual ICollection<mensajes> mensajes { get; set; }
        public virtual ICollection<Respuestas_Chat> Respuestas_Chat { get; set; }
    }
}
