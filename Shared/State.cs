
namespace PizzaPlace.Shared 
{
    public class State  
    {
        public Menu Menu {get;} = new Menu();
        public ShoppingBasket ShoppingBasket {get;} = new ShoppingBasket();
        public UI UI {get; set;} = new UI();
    }
}