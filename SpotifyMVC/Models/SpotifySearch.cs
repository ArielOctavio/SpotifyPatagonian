using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SpotifyMVC.Models
{

    public class ExternalUrls
    {
        public string spotify { get; set; }
    }

    public class Artist
    {
        public ExternalUrls external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class ExternalUrls2
    {
        public string spotify { get; set; }
    }

    public class Image
    {
        public int height { get; set; }
        public string url { get; set; }
        public int width { get; set; }
    }

    public class Album
    {
        public string album_type { get; set; }
        public List<Artist> artists { get; set; }
        public List<string> available_markets { get; set; }
        public ExternalUrls2 external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public List<Image> images { get; set; }
        public string name { get; set; }
        public string release_date { get; set; }
        public string release_date_precision { get; set; }
        public int total_tracks { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class ExternalUrls3
    {
        public string spotify { get; set; }
    }

    public class Artist2
    {
        public ExternalUrls3 external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class ExternalIds
    {
        public string isrc { get; set; }
    }

    public class ExternalUrls4
    {
        public string spotify { get; set; }
    }

    public class Item
    {
        public Album album { get; set; }
        [Display(Name = "Artista")]
        public List<Artist2> artists { get; set; }
        public List<string> available_markets { get; set; }

        [Display(Name = "#")]
        public int disc_number { get; set; }
        [Display(Name = "Duración ms")]
        public int duration_ms { get; set; }
        public bool @explicit { get; set; }
        public ExternalIds external_ids { get; set; }
        public ExternalUrls4 external_urls { get; set; }
        [Display(Name = "URL link")]
        public string href { get; set; }
        public string id { get; set; }
        public bool is_local { get; set; }
        [Display(Name = "Nombre")]
        public string name { get; set; }
        [Display(Name = "Popularidad")]
        public int popularity { get; set; }
        [Display(Name = "Preview")]
        public string preview_url { get; set; }
        public int track_number { get; set; }
        public string type { get; set; }
        [Display(Name = "Abrir en Spotify")]
        public string uri { get; set; }
    }

    public class Tracks
    {
        public string href { get; set; }
        public List<Item> items { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public object previous { get; set; }
        public int total { get; set; }
    }

    public class Root
    {
        public Tracks tracks { get; set; }
    }


}
