using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FirmaKurierska.Models
{
    public class Courier
    {
        [ForeignKey("Order")]
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        
        public virtual Car Car { get; set; }
        public virtual Order Order { get; set; }
    }
}