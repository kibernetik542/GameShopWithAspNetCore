using GameWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameWorld.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart cart)
        {
            this.cart = cart;
        }

        public IViewComponentResult Invoke() => View(cart);
    }
}
