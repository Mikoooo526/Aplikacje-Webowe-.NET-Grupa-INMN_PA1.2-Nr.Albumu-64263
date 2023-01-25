using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppRestaurantMM.Models
{
    public class MenuTypeViewModel
    {
        public List<Menu>? Dish { get; set; }
        public SelectList? Type { get; set; }
        public string? DishType { get; set; }
        public string? SearchString { get; set; }
    }
}
