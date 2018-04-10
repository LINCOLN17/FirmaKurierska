using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirmaKurierska.Models
{
    public class WareHouse
    {
        [Key]
        public int ID { get; set; }

        public string Address { get; set; }
        public double Capacity { get; set; }

        public virtual ICollection<Package> Packages { get; set; }
    }
}