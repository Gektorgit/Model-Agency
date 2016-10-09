namespace WebAppActor.DataLayer.DatabaseLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActorInfo")]
    public partial class ActorInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActorInfo()
        {
            PhotoActor = new HashSet<PhotoActor>();
        }

        [Key]
        public int ActorId { get; set; }

        public int EyesId { get; set; }

        [Required]
        [StringLength(64)]
        public string ActorFirstName { get; set; }

        [Required]
        [StringLength(64)]
        public string ActorLastName { get; set; }

        public DateTime ActorBirthday { get; set; }

        public int Heigth { get; set; }

        public bool Male { get; set; }

        public bool IsActor { get; set; }

        public bool IsModel { get; set; }

        public bool IsSportman { get; set; }

        public bool IsExperience { get; set; }

        public bool IsCrowdScene { get; set; }

        [StringLength(224)]
        public string Agency { get; set; }

        [StringLength(224)]
        public string WorkingPlace { get; set; }

        [StringLength(224)]
        public string Telephon { get; set; }

        [StringLength(224)]
        public string SpecifyExpirience { get; set; }

        [StringLength(224)]
        public string ExtendedInfo { get; set; }

        public virtual Eyes Eyes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhotoActor> PhotoActor { get; set; }
    }
}
