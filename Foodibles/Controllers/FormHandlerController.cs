using Foodibles.Models;
using Foodibles.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Foodibles.Controllers
{
    [Route("[controller]")]
    public class FormHandlerController : Controller
    {

        JsonGroceryService JsonGroceryService;
        public FormHandlerController(JsonGroceryService jsonGroceryService)
        {
            this.JsonGroceryService = jsonGroceryService;
        }
        [HttpGet]
        public string Get(int id, string name, string image)
        {
            Grocery obj = new Grocery();
            obj.id = id;
            obj.name = name;
            obj.image = image;


            IEnumerable<Grocery> groceryData=  JsonGroceryService.getGroceryRecords();
            List<Grocery>ListOfGrocery = groceryData.ToList();
            ListOfGrocery.Add(obj);
            return JsonSerializer.Serialize<List<Grocery>>(ListOfGrocery);
        }
    }
}
