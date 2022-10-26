using System.Text.Json;
using System.Text.Json.Serialization;

namespace arthubwebapp.model
{
    public class Arthub
    {
        [JsonPropertyName("id")]
        // for example if we want to use art_id instead of id so JaonPropertyName is used
        public int Art_id
        {
            get; set;
        }
        [JsonPropertyName("code")]
        public string code
        {
            get; set;
        }
        [JsonPropertyName("image")]
        public string image
        {
            get; set;
        }


        public override string ToString()
        {
            return JsonSerializer.Serialize<Arthub>(this);

        }



    }
}
