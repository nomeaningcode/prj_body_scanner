//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjBodyScanner.Data.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class DoctorBD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoctorBD()
        {
            this.BitacoraBD = new HashSet<BitacoraBD>();
            this.ResultadosBD = new HashSet<ResultadosBD>();
        }
    
        public int IDDoctor { get; set; }
        public string Matricula { get; set; }
        public string NombreEBD { get; set; }
        public string APaternoBD { get; set; }
        public string AMarteno { get; set; }
        public string TelefonoEBD { get; set; }
        public string CorreoEBD { get; set; }
        public string ContraseniaBD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BitacoraBD> BitacoraBD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResultadosBD> ResultadosBD { get; set; }
    }
}