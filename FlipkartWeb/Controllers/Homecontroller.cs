using FlipkartWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlipkartWeb.Controllers
{
    public class Homecontroller : Controller
    {
        List<LaptopModel> olist;

        public Homecontroller()
        {
            olist = new List<LaptopModel>
            {
           // new LaptopModel { Modelname = "N2N3", DeviceName = "DELL", Processor = "IntelR", InstalledRAM = "8GB", DeviceID = 40001, ProductID = "0098-3040-12-43", SystemType = "64-bit operating System", Price = "40,000",Profilepicture="Lap12Dell.jpg"},
            new LaptopModel { Modelname = "SS33", DeviceName = "SAMSUNG", Processor = "IntelR", InstalledRAM = "8GB", DeviceID = 40002, ProductID = "0098-3040-12-43", SystemType = "64-bit operating System", Price = "40,000", Profilepicture="Lap1.jpg"},
            new LaptopModel { Modelname = "305E", DeviceName = "HP", Processor = "IntelR", InstalledRAM = "8GB", DeviceID = 40003, ProductID = "0098-3040-12-43", SystemType = "64-bit operating System", Price = "40,000",Profilepicture="Lap10HP.jpg"},
           // new LaptopModel { Modelname = "IK33", DeviceName = "Lenovo", Processor = "IntelR", InstalledRAM = "8GB", DeviceID = 40004, ProductID = "0098-3040-12-43", SystemType = "64-bit operating System", Price = "40,000",Profilepicture="Lap2.jpg"},
           // new LaptopModel { Modelname = "N2N6", DeviceName = "ASUS", Processor = "IntelR", InstalledRAM = "8GB", DeviceID = 40005, ProductID = "0098-3040-12-43", SystemType = "64-bit operating System", Price = "40,000",Profilepicture="Lap3.jpg"},
            new LaptopModel { Modelname = "SS43", DeviceName = "ACER", Processor = "IntelR", InstalledRAM = "8GB", DeviceID = 40006, ProductID = "0098-3040-12-43", SystemType = "64-bit operating System", Price = "40,000",Profilepicture="Lap11Acer.jpg"},
           // new LaptopModel { Modelname = "309E", DeviceName = "APPLE", Processor = "IntelR", InstalledRAM = "8GB", DeviceID = 40007, ProductID = "0098-3040-12-43", SystemType = "64-bit operating System", Price = "40,000",Profilepicture="Lap4.jpg"},
            new LaptopModel { Modelname = "IK35", DeviceName = "ASUS00x", Processor = "IntelR", InstalledRAM = "8GB", DeviceID = 40008, ProductID = "0098-3040-12-43", SystemType = "64-bit operating System", Price = "40,000",Profilepicture="Lap5.jpg"}

            };
        }


        public IActionResult AllLaptop()
        {
            return View(olist);
        }

       

        public IActionResult Index()
        {
            return View(olist);
        }

        //[HttpGet("Home/Laptop")]
        //[HttpGet("Home/Laptop/DeviceID")]
        public IActionResult Laptop(int DeviceID)
        {
            LaptopModel filterDevice = olist.Where(x => x.DeviceID == DeviceID).FirstOrDefault();
            return View(filterDevice);
        }
    }
}

