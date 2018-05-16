using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirmaKurierska.Models
{
    public class Package
    {
        [Key]
        public int ID { get; set; }

        public PackageStatus PackageStatus { get; set; }

        public double Prize { get; set; }   

        public string Code { get; set; }

        public byte[] Image { get; set; }

        public DateTime DispatchDate { get; set; }
        public DateTime DeliveryDate { get; set; }
    }

    public enum PackageStatus
    {
        TakenFromClient,
        InMagazine,
        InDelivery,
        Delivered,
    }
}