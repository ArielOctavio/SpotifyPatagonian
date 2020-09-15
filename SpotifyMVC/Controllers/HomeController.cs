
using SpotifyMVC.Helpers;
using SpotifyMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SpotifyMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       

        public ActionResult SearchTrackSpotify()
        {
           return View();
        }

        private static async Task GetTocken()
        {
            var token = SearchHelper.token;
            if (token == null)
                await SearchHelper.GetTokenAsync();
        }

        public async Task<ActionResult> SearchTrackSpotifyItems(string cadena)
        {
            await GetTocken();
            Root result = SearchHelper.SearchTrack(cadena);
            if (result?.tracks?.items == null)
                return View(new List<Item>());
            return PartialView(result.tracks.items);
           
        }
    }
}