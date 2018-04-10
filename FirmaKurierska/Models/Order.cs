using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirmaKurierska.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public bool Paid { get; set; }
        public double Prize { get; set; }
        
        public virtual Courier Courier { get; set; }
        public virtual Client Client { get; set; }




        public virtual ICollection<Package> Packages { get; set; }
    }
}