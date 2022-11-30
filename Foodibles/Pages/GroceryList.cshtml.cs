using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foodibles.Models;
using Foodibles.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Foodibles.Pages
{
    public class GroceryListModel : PageModel
    {
        JsonGroceryService JsonGroceryService;
       public  IEnumerable<Grocery> Groceries;
        public GroceryListModel(JsonGroceryService jsonGroceryService)
        {
            this.JsonGroceryService = jsonGroceryService;
        }
        public void OnGet()
        {
            Groceries = JsonGroceryService.getGroceryRecords();

        }
    }
}
