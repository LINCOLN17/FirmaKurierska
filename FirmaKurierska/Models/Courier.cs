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
        [Key]
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}