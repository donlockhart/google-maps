using System.Runtime.Serialization;

namespace GoogleMapsApi.Entities.PlacesDetails.Response
{
    [DataContract]
    public class Photo
    {
        [DataMember(Name = "photo_reference")]
        public string PhotoReference { get; set; }

        [DataMember(Name = "height")]
        public int Height { get; set; }

        [DataMember(Name = "width")]
        public int Width { get; set; }

        [DataMember(Name = "html_attributions")]
        public string[] Attributions { get; set; }
    }
}
