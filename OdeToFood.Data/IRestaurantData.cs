using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza", Location = "Lund", Cuisine = CuisineType.Mexican},
                new Restaurant { Id = 2, Name = "Mustis Pizza", Location = "Malmö", Cuisine = CuisineType.None },
                new Restaurant { Id = 3, Name = "Natalie's Pizza", Location = "Åstorp", Cuisine = CuisineType.Italian },

            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}

