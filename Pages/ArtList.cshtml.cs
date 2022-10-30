using arthubwebapp.model;
using arthubwebapp.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace arthubwebapp.Pages
{
    public class ArtListModel : PageModel
    {
        public IEnumerable<Arthub> arthubs;
         jsonartfile Artservice;

        public ArtListModel(jsonartfile artservice)
        {
            this.Artservice = artservice;
        }




        public void OnGet()
        {
            arthubs = Artservice.getArtData();
        }
    }
}
