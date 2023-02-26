namespace localdbHW3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LocaldbTable")]
    public partial class LocaldbTable
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Num { get; set; }

        [Required]
        [StringLength(50)]
        public string Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Pdtype { get; set; }
    }
}
