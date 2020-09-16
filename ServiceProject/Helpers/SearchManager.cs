using ServiceProject.Models;
using System.Collections.Generic;

namespace ServiceProject.Helpers
{
    public class SearchManager
    {

        public List<Item> SearchTrackSpotifyItems(string cadena)
        {
            var result = SearchHelper.SearchTrack(cadena);
            return (result?.tracks?.items == null) ? new List<Item>() : result.tracks.items;
        }

    }
}