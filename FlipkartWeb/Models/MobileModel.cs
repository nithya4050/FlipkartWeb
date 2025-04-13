using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace FlipkartWeb.Models
{
    public class MobileModel
    {
        [ValidateNever]
        [Key]
        public int MobileID { get; set; }
        public string MobileName { get; set; }

        public string Mobilemodel { get; set; }

        public string Price { get; set; }

        public string RAM { get; set; }

        public string Processor { get; set; }

    }
}
