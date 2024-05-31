using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace J104895_CO5227_ver3.Models
{
    public class Dish
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }

        public List<DishIngredient>? DishIngredients { get; set; }
    }
}
