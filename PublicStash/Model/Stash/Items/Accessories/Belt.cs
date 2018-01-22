﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using static Newtonsoft.Json.NullValueHandling;

namespace PathOfExile.Model
{
    public class Belt : Item
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            "Stygian Vise",
            "Rustic Sash",
            "Chain Belt",
            "Heavy Belt",
            "Leather Belt",
            "Golden Obi",
            "Cloth Belt",
            "Studded Belt",
            "Vanguard Belt",
            "Crystal Belt"
        };

        public class Category
        {
            public IEnumerable<string> accessories { get; set; }
        }

        public bool verified { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int ilvl { get; set; }
        public string icon { get; set; }
        public string league { get; set; }
        public string id { get; set; }
        public bool identified { get; set; }
        public IEnumerable<Requirement> requirements { get; set; }
        public IEnumerable<string> implicitMods { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public int frameType { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string inventoryId { get; set; }
        public Category category { get; set; }


        [JsonProperty(NullValueHandling = Ignore), JsonConverter(typeof(SockatableConverter))]
        public IEnumerable<SocketableItem> socketedItems { get; set; }
    }
}