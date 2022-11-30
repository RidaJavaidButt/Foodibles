using Foodibles.Models;
using Foodibles.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodibles.Pages
{
    public class IndexModel : PageModel
        
    {
        public IEnumerable<Grocery> Groceries { get; private set; }
        public JsonGroceryService JsonGroceryService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,
            JsonGroceryService jsonGroceryService)
        {
            _logger = logger;
            JsonGroceryService = jsonGroceryService;
        }

        public void OnGet()
        {

        }
    }
}
