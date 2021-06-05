namespace Transportnaya.BD_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Avtorizac")]
    public partial class Avtorizac
    {
        [Key]
        [StringLength(50)]
        public string Login { get; set; }

        public string Password { get; set; }
    }
}
