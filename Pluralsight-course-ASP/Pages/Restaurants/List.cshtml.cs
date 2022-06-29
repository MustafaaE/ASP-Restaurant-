using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

public class ListModel : PageModel
{
    private readonly IConfiguration config;
    private readonly IRestaurantData restaurantData;

    //Bind property with supportsGet true, post is default true 
    [BindProperty(SupportsGet = true)]
    public string SearchTerm { get; set; }

    public String Message { get; set; }
    public IEnumerable<Restaurant> Restaurants { get; set; }

    public ListModel(IConfiguration config, IRestaurantData restaurantData)
    {
        this.config = config;
        this.restaurantData = restaurantData;
    }
    public void OnGet(string searchTerm)
    {

        Message = config["Message"];
        Restaurants = restaurantData.GetRestaurantsByName(searchTerm);
    }
}

