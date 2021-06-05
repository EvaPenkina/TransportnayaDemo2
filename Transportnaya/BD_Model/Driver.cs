namespace Transportnaya.BD_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Driver")]
    public partial class Driver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Driver()
        {
            Application = new HashSet<Application>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Driver { get; set; }

        [StringLength(50)]
        public string DriverName { get; set; }

        [StringLength(53)]
        public string FIO_Driver { get; set; }

        [StringLength(30)]
        public string PassportData { get; set; }

        [StringLength(18)]
        public string Car { get; set; }

        [StringLength(18)]
        public string Trailer { get; set; }
        [StringLength(50)]
        public string Driver_Phone { get; set; }

        [StringLength(5)]
        public string Availability { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Application { get; set; }
    }
}
