using Foodibles.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Foodibles.Services
{
    public class JsonGroceryService
    {


        public JsonGroceryService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;

        }
        public IWebHostEnvironment WebHostEnvironment { get; }
        public string JsonFilePath { get

        {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "Grocery.json");

            }

        }
        public IEnumerable<Grocery> getGroceryRecords()
        {
            using (var file_stream = File.OpenText( JsonFilePath))
            {
                return JsonSerializer.Deserialize<Grocery[]>(file_stream.ReadToEnd());
            }
        }

    }
}
