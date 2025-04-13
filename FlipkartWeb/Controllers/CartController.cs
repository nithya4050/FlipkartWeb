using FlipkartWeb.Helper;
using FlipkartWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace FlipkartWeb.Controllers
{
    public class CartController : Controller
    {
        private readonly IStringLocalizer<CartController> _localizer;
        private static List<AuthendModel> _users = new List<AuthendModel>(); // Simulates a database
        private readonly AppDBContext appDBContextobj;

        public CartController(IStringLocalizer<CartController> localizer, AppDBContext appDBContext)
        {
            _localizer = localizer;
            appDBContextobj = appDBContext;
        }
        public IActionResult Index()
        {
            ViewData["CartTitle"] = _localizer["CartTitle"];

            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            ViewData["ShopName"] = "MSDEVBUILD Shop";
            return View(cart);
        }

        public IActionResult AddToCart(int id, string name, decimal price)
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            var item = cart.FirstOrDefault(c => c.ProductId == id);

            if (item == null)
            {
                cart.Add(new CartItem { ProductId = id, ProductName = name, Price = price, Quantity = 1 });
            }
            else
            {
                item.Quantity++;
            }

            HttpContext.Session.SetObjectAsJson("Cart", cart);

            // Store the cart count in the session
            HttpContext.Session.SetInt32("CartCount", cart.Sum(c => c.Quantity));

            return RedirectToAction("Index");
        }

        //[HttpPost]
        //  public IActionResult PlaceOrder(Orderplaced data, CartItem item) 
        //  {
        // var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Cart") ?? new List<CartItem>();







        // var Auth = appDBContextobj.orderPlaced.ToList();
        // var single = Auth.Where(x => x.Oid == data.Oid).FirstOrDefault();
        // if (single == null)
        // {
        //    appDBContextobj.orderPlaced.Add(data);
        //    appDBContextobj.SaveChanges();
        //    return RedirectToAction("Login");
        // }
        // else
        // {
        //     ViewBag.Message = "Order Data is registered";
        //     return View("Registration");
        // }

        // // cart is zero

        //// var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Cart") ?? new List<CartItem>();
        // HttpContext.Session.SetObjectAsJson("Cart", cart);
        // HttpContext.Session.SetInt32("CartCount", 0);

        public IActionResult PlaceOrder()
        { 
            HttpContext.Session.Remove("Cart");
            ViewData["ShopName"] = "MSDEVBUILD Shop";
            return View("OrderSuccess");
        }
    }
}
