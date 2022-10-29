using arthubwebapp.model;
using arthubwebapp.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace arthubwebapp.controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArtsController : ControllerBase
    {
        jsonartfile Artservice { get; }
        public ArtsController(jsonartfile artservice)
        {
            this.Artservice = artservice;
        }
        [HttpGet]
         public IEnumerable<Arthub> Get()
        {
            return Artservice.getArtData();

        }


    }
}
