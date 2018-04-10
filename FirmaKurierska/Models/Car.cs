using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FirmaKurierska.Models
{
    public class Car
    {
        [ForeignKey("Courier")]
        public int ID { get; set; }
        public int Capacity { get; set; }
        public virtual Courier Courier { get; set; }
    }
}