using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Shared
{
    public class Menu
    {
        public List<Pizza> Pizzas { get; set; }

        public Menu()
        {
            Pizzas = new List<Pizza>();
        }

        public void Add(Pizza pizza)
        {
            Pizzas.Add(pizza);
        }

        public Pizza? GetPizza(int id) => Pizzas.SingleOrDefault(p => p.Id == id);
    }
}