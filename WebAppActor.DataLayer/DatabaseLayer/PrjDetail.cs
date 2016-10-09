namespace WebAppActor.DataLayer.DatabaseLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrjDetail")]
    public partial class PrjDetail
    {
        public int PrjDetailId { get; set; }

        public int PrjMainId { get; set; }

        public int PhotoId { get; set; }

        public virtual PhotoActor PhotoActor { get; set; }

        public virtual PrjMain PrjMain { get; set; }
    }
}
