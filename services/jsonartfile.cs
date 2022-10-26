using arthubwebapp.model;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace arthubwebapp.services
{
    public class jsonartfile
    {
        public jsonartfile(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;

        }
        public IWebHostEnvironment WebHostEnvironment { get; }

        public string JsonFilePath { get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "datasource","art.json");
            } 

             }
        public IEnumerable<Arthub> getArtData() 
        {
        using(var json_file = File.OpenText(JsonFilePath)) 
            {
                return JsonSerializer.Deserialize<Arthub[]>(json_file.ReadToEnd());
            }
        
        }
    }
}
