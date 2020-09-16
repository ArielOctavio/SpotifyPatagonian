using ServiceProject.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SpotifyMVC.Controllers
{
    public class HomeController : Controller
    {
              

        public ActionResult SearchTrackSpotify()
        {
           return View();
        }

       
        public ActionResult SearchTrackSpotifyItems(string cadena)
        {

            var service = new ServiceReferenceProject.TestServiceClient();
            var result = service.SearchTracks(cadena);

            if (result == null)
                return View(new List<Item>());
            return PartialView(result);
        }

        public ActionResult SearchTrackSpotifyItems2(string cadena)
        {

            var service = new ServiceReferenceProject.TestServiceClient();
            var result = service.SearchTracks(cadena);

            if (result == null)
                return View(new List<Item>());
            return PartialView(result);
        }
    }
}