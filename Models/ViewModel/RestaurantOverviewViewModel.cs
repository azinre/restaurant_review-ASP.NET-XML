using System.ComponentModel.DataAnnotations;

namespace lab3.Models.ViewModel
{
    public class RestaurantOverviewViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Rataurant")]
        public string Name { get; set; }
        [Display(Name = "Food Type")]
        public string FoodType { get; set; }
        [Display(Name = "Rating (best=5)")]
        public decimal Rating { get; set; }
        [Display(Name = "Cost (most expensive=5)")]
        public decimal Cost { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "Province")]
        public string? ProvinceState { get; set; }
    }
}
