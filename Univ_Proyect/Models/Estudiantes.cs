//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Univ_Proyect.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estudiantes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estudiantes()
        {
            this.ClasesEstudiante = new HashSet<ClasesEstudiante>();
        }
    
        public System.Guid EstudiantesId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public System.Guid CiudadId { get; set; }
        public System.Guid MunicipioId { get; set; }
        public System.Guid CarreraId { get; set; }
        public System.Guid CreadoPorUsuarioId { get; set; }
        public System.Guid ModificadoPorUsuarioId { get; set; }
        public System.DateTime FechadeCreacion { get; set; }
        public System.DateTime FechadeModificacion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public byte EstadoId { get; set; }
        public System.Guid UsuarioId { get; set; }
    
        public virtual Carrera Carrera { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClasesEstudiante> ClasesEstudiante { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual usuarios usuarios { get; set; }
    }
}
