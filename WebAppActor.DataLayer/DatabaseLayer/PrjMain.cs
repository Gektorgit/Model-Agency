namespace WebAppActor.DataLayer.DatabaseLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrjMain")]
    public partial class PrjMain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrjMain()
        {
            PrjDetail = new HashSet<PrjDetail>();
        }

        public int PrjMainId { get; set; }

        [Required]
        [StringLength(128)]
        public string PrjName { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateCreate { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateStart { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateEnd { get; set; }

        public int UserId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrjDetail> PrjDetail { get; set; }

        public virtual Users Users { get; set; }
    }
}
