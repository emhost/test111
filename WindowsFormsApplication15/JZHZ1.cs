namespace WindowsFormsApplication15
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YWAPP.JZHZ")]
    public partial class JZHZ1
    {
        [StringLength(36)]
        public string ID { get; set; }

        public long? NPHONE { get; set; }

        [StringLength(10)]
        public string VNAME { get; set; }

        [StringLength(10)]
        public string NSEX { get; set; }

        [StringLength(20)]
        public string VSFZH { get; set; }

        [StringLength(20)]
        public string VCARD { get; set; }

        [StringLength(50)]
        public string VPWD { get; set; }

        [StringLength(10)]
        public string VPYM { get; set; }

        public DateTime? DBIRTHDAY { get; set; }

        public bool? NSTOP { get; set; }

        [StringLength(30)]
        public string VPATIENTID { get; set; }

        public DateTime? DCREATE { get; set; }
    }
}
