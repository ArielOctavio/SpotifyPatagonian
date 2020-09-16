using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServiceProject.Models
{

    [DataContract]
        public class ExternalUrls
        {
            [DataMember]
            public string spotify { get; set; }
        }

        [DataContract]
        public class Artist
        {
            [DataMember]
            public ExternalUrls external_urls { get; set; }

            [DataMember]
            public string href { get; set; }

            [DataMember]
            public string id { get; set; }

            [DataMember]
            public string name { get; set; }

            [DataMember]
            public string type { get; set; }

            [DataMember]
            public string uri { get; set; }
        }

        [DataContract]
        public class ExternalUrls2
        {
            [DataMember]
            public string spotify { get; set; }
        }

        [DataContract]
        public class Image
        {
            [DataMember]
            public int height { get; set; }

            [DataMember]
            public string url { get; set; }

            [DataMember]
            public int width { get; set; }
        }

        [DataContract]
        public class Album
        {
            [DataMember]
            public string album_type { get; set; }

            [DataMember]
            public List<Artist> artists { get; set; }

            [DataMember]
            public List<string> available_markets { get; set; }

            [DataMember]
            public ExternalUrls2 external_urls { get; set; }

            [DataMember]
            public string href { get; set; }

            [DataMember]
            public string id { get; set; }

            [DataMember]
            public List<Image> images { get; set; }

            [DataMember]
            public string name { get; set; }

            [DataMember]
            public string release_date { get; set; }

            [DataMember]
            public string release_date_precision { get; set; }

            [DataMember]
            public int total_tracks { get; set; }

            [DataMember]
            public string type { get; set; }

            [DataMember]
            public string uri { get; set; }
        }

        [DataContract]
        public class ExternalUrls3
        {
            [DataMember]
            public string spotify { get; set; }
        }

        [DataContract]
        public class Artist2
        {
            [DataMember]
            public ExternalUrls3 external_urls { get; set; }

            [DataMember]
            public string href { get; set; }

            [DataMember]
            public string id { get; set; }

            [DataMember]
            public string name { get; set; }

            [DataMember]
            public string type { get; set; }

            [DataMember]
            public string uri { get; set; }
        }

        [DataContract]
        public class ExternalIds
        {
            [DataMember]
            public string isrc { get; set; }
        }

        [DataContract]
        public class ExternalUrls4
        {
            [DataMember]
            public string spotify { get; set; }
        }

        [DataContract]
        public class Item
        {
            [DataMember]
            public Album album { get; set; }

            [DataMember]
            public List<Artist2> artists { get; set; }

            [DataMember]
            public List<string> available_markets { get; set; }

            [DataMember]
            public int disc_number { get; set; }

            [DataMember]
            public int duration_ms { get; set; }

            [DataMember]
            public bool @explicit { get; set; }

            [DataMember]
            public ExternalIds external_ids { get; set; }

            [DataMember]
            public ExternalUrls4 external_urls { get; set; }

            [DataMember]
            public string href { get; set; }

            [DataMember]
            public string id { get; set; }

            [DataMember]
            public bool is_local { get; set; }

            [DataMember]
            public string name { get; set; }

            [DataMember]
            public int popularity { get; set; }

            [DataMember]
            public string preview_url { get; set; }

            [DataMember]
            public int track_number { get; set; }

            [DataMember]
            public string type { get; set; }

            [DataMember]
            public string uri { get; set; }
        }

        [DataContract]
        public class Tracks
        {
            [DataMember]
            public string href { get; set; }

            [DataMember]
            public List<Item> items { get; set; }

            [DataMember]
            public int limit { get; set; }

            [DataMember]
            public string next { get; set; }

            [DataMember]
            public int offset { get; set; }

            [DataMember]
            public object previous { get; set; }

            [DataMember]
            public int total { get; set; }
        }

        [DataContract]
        public class Root
        {
            [DataMember]
            public Tracks tracks { get; set; }
        }
   
}