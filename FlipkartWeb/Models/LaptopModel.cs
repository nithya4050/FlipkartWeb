using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace FlipkartWeb.Models
{
    public class LaptopModel
    {
        //public string DELL { get; set; }

        //public string  HP { get; set; }
        //public string Apple { get; set; }
        //public string ASUS { get; set; }
        //public string ACER { get; set; }
        //public string Lenovo { get; set; }
        //public string HP15S{ get; set; }
        //public string DELL3530 { get; set; }
        //public string Lenovo32n { get; set; }
        //public string ASUS00x { get; set; }

        [ValidateNever]
        [Key]
        public int ModelID { get; set; }

        public string Modelname { get; set; }
        public string DeviceName { get; set; }

        public string Processor { get; set; }

        public string InstalledRAM { get; set; }

        public int DeviceID { get; set; }

        public string ProductID { get; set; }

        public string SystemType { get; set; }

        public string Price { get; set; }

        public string Profilepicture { get; set; }
    }
}
