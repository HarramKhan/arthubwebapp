using arthubwebapp.model;
using arthubwebapp.services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace arthubwebapp.controllers
{
    [Route("[controller]")]
    public class formhandlerController : Controller
    {
        jsonartfile Artservice;
        public  formhandlerController(jsonartfile artservice)
        {
            this.Artservice = artservice;
        }


        [HttpGet]
      public  string Get(int id,string name,string image,int price)
        {
            Arthub obj = new Arthub();
            obj.Art_id = id;
            obj.code = name;
            obj.image = image;
            obj.price = price;

            IEnumerable<Arthub> ArtData = Artservice.getArtData();
          List<Arthub> listArt = ArtData.ToList();
            listArt.Add(obj);

            return JsonSerializer.Serialize<List<Arthub>>(listArt);

       
        }
    }
}
