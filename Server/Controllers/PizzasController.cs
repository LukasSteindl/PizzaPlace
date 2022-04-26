using Microsoft.AspNetCore.Mvc;
using PizzaPlace.Shared;
using System.Collections.Generic;
using System.Linq; 

namespace PizzaPlace.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private static readonly List<Pizza> pizzas = new List<Pizza>
        {
            new Pizza (1, "Pepperoni", 10.99m, Spiciness.Hot),
            new Pizza (2, "Hawaiian",  12.99m, Spiciness.Hot),
            new Pizza (3, "Veggie", 11.99m, Spiciness.Hot),
            new Pizza (4, "Meat Lovers",  13.99m, Spiciness.Hot),
            new Pizza (5, "Supreme", 14.99m, Spiciness.Hot)
        };

        [HttpGet("/pizzas")]
        public IQueryable<Pizza> GetPizzas()
        {
            return pizzas.AsQueryable();
        }
    }
}