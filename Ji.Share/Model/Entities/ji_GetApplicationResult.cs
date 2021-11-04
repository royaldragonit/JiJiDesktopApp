using Ji.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.Entities
{
    public class ji_GetApplicationResult
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("dll")]
        public string Dll { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("categoryNonUnicode")]
        public string CategoryNonUnicode { get; set; }

        [JsonProperty("nameNonUnicode")]
        public string NameNonUnicode { get; set; }

        [JsonProperty("defaultDLL")]
        public bool DefaultDLL { get; set; }

        [JsonProperty("permissionBasic")]
        public bool PermissionBasic { get; set; }
    }
}
