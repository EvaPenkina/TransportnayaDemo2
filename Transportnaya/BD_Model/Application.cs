namespace Transportnaya.BD_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Application")]
    public partial class Application
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Application { get; set; }

        public int? ID_Driver { get; set; }

        public int? ID_Client { get; set; }

        [StringLength(50)]
        public string Charge_address { get; set; }

        public DateTime? Charge_date { get; set; }

        [StringLength(50)]
        public string Discharge_address { get; set; }

        public DateTime? Discharge_date { get; set; }

        [StringLength(50)]
        public string ReqTypeRollingStock { get; set; }

        public long? Cost { get; set; }

        [StringLength(50)]
        public string Cargo_Name { get; set; }

        [StringLength(10)]
        public string Cargo_weight { get; set; }

        public virtual Client Client { get; set; }

        public virtual Driver Driver { get; set; }
    }
}
