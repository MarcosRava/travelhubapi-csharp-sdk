﻿using System;
using Newtonsoft.Json;

namespace TravelHubApi.Sdk.Hotel.Models
{
    [Serializable]
    public class Country
    {
        [JsonProperty(Order = 0)]
        public virtual string Id { get; set; }

        [JsonProperty(Order = 1)]
        public virtual string PrefixCode { get; set; }

        [JsonProperty(Order = 2)]
        public virtual string Name { get; set; }
    }
}
