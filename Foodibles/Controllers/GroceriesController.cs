using Foodibles.Models;
using Foodibles.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodibles.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GroceriesController : ControllerBase
    
        
        {
            JsonGroceryService JsonGroceryService;
            public GroceriesController(JsonGroceryService jsonGroceryService)
            {
            this.JsonGroceryService = jsonGroceryService;
            }

            [HttpGet]
            public IEnumerable<Grocery> Get()
            {
                return JsonGroceryService.getGroceryRecords();
            }
        }
    }


