using lab3.Models;
using lab3.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Serialization;

namespace lab3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string xmlFilePath = Path.GetFullPath("Data/restaurant_review.xml");
            restaurants restaurantData;

            XmlSerializer serializer = new XmlSerializer(typeof(restaurants));
            using (FileStream fs = new FileStream(xmlFilePath, FileMode.Open))
            {
                restaurantData = (restaurants)serializer.Deserialize(fs);
            }

            var restaurantList = new List<RestaurantOverviewViewModel>();
            int index = 0;

            foreach (var restaurant in restaurantData.restaurant)
            {
                var restaurantViewModel = new RestaurantOverviewViewModel
                {
                    Id = index,
                    Name = restaurant.basicinfo.nameOfResaurant,
                    FoodType = restaurant.basicinfo.cuisine,
                    Rating = decimal.Parse(restaurant.basicinfo.rating.Value),
                    Cost = decimal.Parse(restaurant.basicinfo.priceRating.Value),
                    City = restaurant.basicinfo.address.city,
                    ProvinceState = restaurant.basicinfo.address.province.ToString(),
                };                
                restaurantList.Add(restaurantViewModel);
                index++;
            }
            return View(restaurantList);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {

            string xmlFilePath = Path.GetFullPath("Data/restaurant_review.xml");
            restaurants restaurantData;

            XmlSerializer serializer = new XmlSerializer(typeof(restaurants));
            using (FileStream fs = new FileStream(xmlFilePath, FileMode.Open))
            {
                restaurantData = (restaurants)serializer.Deserialize(fs);
            }
            var restaurant = restaurantData.restaurant[id];

            var restaurantEditViewModel = new RestaurantEditViewModel
            {
                Id = id,
                Name = restaurant.basicinfo.nameOfResaurant,
                StreetAddress = restaurant.basicinfo.address.street,
                City = restaurant.basicinfo.address.city,
                ProvinceState = restaurant.basicinfo.address.province,
                PostalZipCode = restaurant.basicinfo.address.postalcode,
                Summary = restaurant.review.summary,
                Rating = decimal.Parse(restaurant.basicinfo.rating.Value),
            };

            return View(restaurantEditViewModel);
        }
        [HttpPost]
        public IActionResult Edit(RestaurantEditViewModel rsvm)
        {
            if (ModelState.IsValid)
            {

                string xmlFilePath = Path.GetFullPath("Data/restaurant_review.xml");
                restaurants restaurantData;

                XmlSerializer serializer = new XmlSerializer(typeof(restaurants));
                using (FileStream fs = new FileStream(xmlFilePath, FileMode.Open))
                {
                    restaurantData = (restaurants)serializer.Deserialize(fs);
                }
                var restaurant = restaurantData.restaurant[rsvm.Id];

                restaurant.basicinfo.nameOfResaurant = rsvm.Name;
                restaurant.basicinfo.address.street = rsvm.StreetAddress;
                restaurant.basicinfo.address.city = rsvm.City;
                restaurant.basicinfo.address.province = rsvm.ProvinceState;
                restaurant.basicinfo.address.postalcode = rsvm.PostalZipCode;
                restaurant.review.summary = rsvm.Summary;
                restaurant.basicinfo.rating.Value = rsvm.Rating.ToString();

                using (FileStream fs = new FileStream(xmlFilePath, FileMode.Create))
                {
                    serializer.Serialize(fs, restaurantData);
                }

                return RedirectToAction("Index"); 
            }

            
            return View(rsvm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}