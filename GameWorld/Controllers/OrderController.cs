using GameWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameWorld.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Checkout() => View(new Order());
    }
}
