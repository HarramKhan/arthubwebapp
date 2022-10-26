using arthubwebapp.model;
using arthubwebapp.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arthubwebapp.Pages
{
    public class IndexModel : PageModel
    {
       public IEnumerable<Arthub> arthubs { get; private set; }
        public jsonartfile Artservice;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(
            ILogger<IndexModel> logger,
            jsonartfile artservice)
        {
            _logger = logger;
            Artservice = artservice;

        }

        public void OnGet()
        {
            arthubs = Artservice.getArtData(); 


        }
    }
}
