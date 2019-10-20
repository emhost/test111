namespace WindowsFormsApplication15
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YWAPP.PAYMENT")]
    public partial class PAYMENT
    {
        [Key]
        [StringLength(50)]
        public string VDDLSH { get; set; }

        [StringLength(10)]
        public string VNAME { get; set; }

        [StringLength(20)]
        public string VCLINICNO { get; set; }

        [StringLength(20)]
        public string VCARD { get; set; }

        [StringLength(20)]
        public string VSFZH { get; set; }

        [StringLength(20)]
        public string VDEPT { get; set; }

        [StringLength(20)]
        public string VDOCTOR { get; set; }

        public decimal? NCOSTS { get; set; }

        [StringLength(200)]
        public string VREMARKS { get; set; }

        public DateTime? DDDRQ { get; set; }

        [StringLength(50)]
        public string VSPMC { get; set; }

        [StringLength(20)]
        public string VPHONE { get; set; }

        public DateTime? DZFRQ { get; set; }

        public bool? NSTATE { get; set; }

        public DateTime? DJZRQ { get; set; }

        public bool? NPAYTYPE { get; set; }

        public bool? NDEL { get; set; }

        [StringLength(8)]
        public string VAPPTIME { get; set; }

        [StringLength(50)]
        public string VHZID { get; set; }

        public byte? NDDLX { get; set; }

        [StringLength(50)]
        public string VHAOBIE { get; set; }

        public decimal? NGHF { get; set; }

        public decimal? NZLF { get; set; }
    }
}
