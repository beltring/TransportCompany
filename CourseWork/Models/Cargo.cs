namespace CourseWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cargos")]
    public partial class Cargo
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        public double Cost { get; set; }

        public double Weight { get; set; }

        public double Volume { get; set; }

        [StringLength(10)]
        public string TrailerType { get; set; }

        [Column(TypeName = "date")]
        public DateTime UploadDate { get; set; }

        [StringLength(12)]
        public string Status { get; set; }

        [StringLength(20)]
        public string DownloadLocation { get; set; }

        [StringLength(20)]
        public string PlaceOfDischarge { get; set; }

        public int Distance { get; set; }
    }
}
