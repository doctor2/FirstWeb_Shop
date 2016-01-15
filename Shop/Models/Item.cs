using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Shop.Models
{

    //[Table("Compute_Equipment")]
    //public class Compute_Equipment
    //{
    //    Computers comp { get; set; }
    //}

    [Table("Computers")]
    public class Computers
    {
        [Column("Id"), Key]
        [DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Firm"), Required, MaxLength(200)]           //Not null
        public string Firm { get; set; }
        [Column("Сharacteristics"), Required, MaxLength(200)]           //Not null
        public string Сharacteristics { get; set; }

        [Column("Number "), Required]           //Not null
        public int Number { get; set; }
    }


    [Table("Laptop")]
    public class Laptop
    {
        [Column("Id"), Key]
        [DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Firm"), Required, MaxLength(200)]           //Not null
        public string Firm { get; set; }
        [Column("Сharacteristics"), Required, MaxLength(200)]           //Not null
        public string Сharacteristics { get; set; }

        [Column("Number "), Required]           //Not null
        public int Number { get; set; }
    }

    //[Table("Employee")]
    //public class Item
    //{

    //    [Column("Id"), Key]
    //    [DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    //    public int Id { get; set; }
    //    [Column("FIO"), Required, MaxLength(200)]           //Not null
    //    public string FIO { get; set; }
    //    [Column("TypePost"), MaxLength(200)]
    //    public string TypePost { get; set; }
    //    [Column("TypeCor"), MaxLength(200)]
    //    public string TypeCor { get; set; }
    //    [Column("Department"), MaxLength(200)]
    //    public string Department { get; set; }
    //    [Column("Expiration_date", TypeName = "datetime2")]
    //    public System.DateTime Expiration_date { get; set; }

    //}

}