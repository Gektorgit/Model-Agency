namespace WebAppActor.DataLayer.DatabaseLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhotoActor")]
    public partial class PhotoActor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhotoActor()
        {
            PrjDetail = new HashSet<PrjDetail>();
        }

        [Key]
        public int PhotoId { get; set; }

        public int ActorId { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] PhotoTrue { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] PhotoSmall { get; set; }

        public virtual ActorInfo ActorInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrjDetail> PrjDetail { get; set; }
    }
}
