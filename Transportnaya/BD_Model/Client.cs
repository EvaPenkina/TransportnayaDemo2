namespace Transportnaya.BD_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Application = new HashSet<Application>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Client { get; set; }

        [StringLength(50)]
        public string Client_name { get; set; }

        public long? Client_phone { get; set; }

        public long? Client_IMX { get; set; }

        [StringLength(40)]
        public string Client_address { get; set; }

        public long? Client_KPP { get; set; }

        public long? Client_BankAccount { get; set; }

        public long? Client_OGRN { get; set; }

        [StringLength(30)]
        public string Bank_name { get; set; }

        public long? BIK { get; set; }

        [StringLength(30)]
        public string SiteAddress { get; set; }

        [StringLength(40)]
        public string EMail { get; set; }

        [StringLength(50)]
        public string ContactPerson { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Application { get; set; }
    }
}
