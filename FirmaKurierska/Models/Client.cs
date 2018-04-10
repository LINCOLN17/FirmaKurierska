﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FirmaKurierska.Models
{
    public class Client
    {
        [ForeignKey("Order")]
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public virtual Order Order { get; set; }

    }
}