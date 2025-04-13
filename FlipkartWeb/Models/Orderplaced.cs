using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace FlipkartWeb.Models
{
    public class Orderplaced
    {
        [ValidateNever]
        [Key]
        public int Oid { get; set; }
        public string Productname { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string Total { get; set; }
        
    }
}
