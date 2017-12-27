﻿using System;
using System.Collections.Generic;

namespace PublicStash.Model
{
    internal class Prophecy : AbstractItem
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            "A Call into the Void",
            "A Firm Foothold",
            "A Forest of False Idols",
            "A Gracious Master",
            "A Master Seeks Help",
            "A Prodigious Hand",
            "A Regal Death",
            "A Valuable Combination",
            "A Whispered Prayer",
            "Abnormal Effulgence",
            "Against the Tide",
            "An Unseen Peril",
            "Anarchy's End I",
            "Anarchy's End II",
            "Anarchy's End III",
            "Anarchy's End IV",
            "Ancient Doom",
            "Ancient Rivalries I",
            "Ancient Rivalries II",
            "Ancient Rivalries III",
            "Ancient Rivalries IV",
            "Baptism by Death",
            "Beyond Sight I",
            "Beyond Sight II",
            "Beyond Sight III",
            "Beyond Sight IV",
            "Beyond Sight V",
            "Blood in the Eyes",
            "Blood of the Betrayed",
            "Bountiful Traps",
            "Brothers in Arms",
            "Cleanser of Sins",
            "Crash Test",
            "Crushing Squall",
            "Custodians of Silence",
            "Day of Sacrifice I",
            "Day of Sacrifice II",
            "Day of Sacrifice III",
            "Day of Sacrifice IV",
            "Deadly Rivalry I",
            "Deadly Rivalry II",
            "Deadly Rivalry III",
            "Deadly Rivalry IV",
            "Deadly Rivalry V",
            "Deadly Twins",
            "Defiled in the Scepter",
            "Delay Test",
            "Delay and Crash Test",
            "Dying Cry",
            "Echoes of Lost Love",
            "Echoes of Mutation",
            "Echoes of Witchcraft",
            "Ending the Torment",
            "Enter the Maelström",
            "Erased from Memory",
            "Erasmus' Gift",
            "Fallow At Last",
            "Fated Connections",
            "Fear's Wide Reach",
            "Fire and Brimstone",
            "Fire and Ice",
            "Fire from the Sky",
            "Fire, Wood and Stone",
            "Flesh of the Beast",
            "Forceful Exorcism",
            "From Death Springs Life",
            "From The Void",
            "Gilded Within",
            "Golden Touch",
            "Graceful Flames",
            "Heart of the Fire",
            "Heavy Blows",
            "Hidden Reinforcements",
            "Hidden Vaal Pathways",
            "Holding the Bridge",
            "Hunter's Lesson",
            "Ice from Above",
            "In the Grasp of Corruption",
            "Kalandra's Craft",
            "Lasting Impressions",
            "Lightning Falls",
            "Living Fires",
            "Lost in the Pages",
            "Monstrous Treasure",
            "Mouth of Horrors",
            "Mysterious Invaders",
            "Nature's Resilience",
            "Nemesis of Greed",
            "Notched Flesh",
            "Overflowing Riches",
            "Path of Betrayal",
            "Plague of Frogs",
            "Plague of Rats",
            "Pleasure and Pain",
            "Pools of Wealth",
            "Possessed Foe",
            "Power Magnified",
            "Rebirth",
            "Reforged Bonds",
            "Resistant to Change",
            "Risen Blood",
            "Roth's Legacy",
            "SHOULD NOT APPEAR",
            "Sanctum of Stone",
            "Severed Limbs",
            "Smothering Tendrils",
            "Soil, Worms and Blood",
            "Storm on the Horizon",
            "Storm on the Shore",
            "Storm on the Reef",
            "Strong as a Bull",
            "Thaumaturgical History I",
            "Thaumaturgical History II",
            "Thaumaturgical History III",
            "Thaumaturgical History IV",
            "The Aesthete's Spirit",
            "The Alchemist",
            "The Ambitious Bandit I",
            "The Ambitious Bandit II",
            "The Ambitious Bandit III",
            "The Apex Predator",
            "The Beautiful Guide",
            "The Beginning and the End",
            "The Black Stone I",
            "The Black Stone II",
            "The Black Stone III",
            "The Black Stone IV",
            "The Blacksmith",
            "The Blessing",
            "The Bloody Flowers Redux",
            "The Bowstring's Music",
            "The Brothers of Necromancy",
            "The Brutal Enforcer",
            "The Child of Lunaris",
            "The Corrupt",
            "The Cursed Choir",
            "The Dream Trial",
            "The Dreamer's Dream",
            "The Eagle's Cry",
            "The Emperor's Trove",
            "The Feral Lord I",
            "The Feral Lord II",
            "The Feral Lord III",
            "The Feral Lord IV",
            "The Feral Lord V",
            "The Flayed Man",
            "The Flow of Energy",
            "The Forgotten Garrison",
            "The Forgotten Soldiers",
            "The Fortune Teller's Collection",
            "The Four Feral Exiles",
            "The God of Misfortune",
            "The Hardened Armour",
            "The Hollow Pledge",
            "The Hungering Swarm",
            "The Invader",
            "The Jeweller's Touch",
            "The Karui Rebellion",
            "The King and the Brambles",
            "The King's Path",
            "The Lady in Black",
            "The Last Watch",
            "The Lost Maps",
            "The Lost Undying",
            "The Misunderstood Queen",
            "The Mysterious Gift",
            "The Nest",
            "The Pair",
            "The Petrified",
            "The Pirate's Den",
            "The Plaguemaw I",
            "The Plaguemaw II",
            "The Plaguemaw III",
            "The Plaguemaw IV",
            "The Plaguemaw V",
            "The Prison Guard",
            "The Prison Key",
            "The Queen's Vaults",
            "The Scout",
            "The Servant's Heart",
            "The Sharpened Blade",
            "The Silverwood",
            "The Singular Spirit",
            "The Sinner's Stone",
            "The Snuffed Flame",
            "The Soulless Beast",
            "The Spread of Corruption",
            "The Stockkeeper",
            "The Sword King's Passion",
            "The Trembling Earth",
            "The Twins",
            "The Unbreathing Queen I",
            "The Unbreathing Queen II",
            "The Unbreathing Queen III",
            "The Unbreathing Queen IV",
            "The Unbreathing Queen V",
            "The Undead Brutes",
            "The Undead Storm",
            "The Vanguard",
            "The Walking Mountain",
            "The Ward's Ward",
            "The Warmongers I",
            "The Warmongers II",
            "The Warmongers III",
            "The Warmongers IV",
            "The Watcher's Watcher",
            "The Wealthy Exile",
            "Through the Mirage",
            "Touched by Death",
            "Touched by the Wind",
            "Trash to Treasure",
            "Twice Enchanted",
            "Unbearable Whispers I",
            "Unbearable Whispers II",
            "Unbearable Whispers III",
            "Unbearable Whispers IV",
            "Unbearable Whispers V",
            "Undead Uprising",
            "Unnatural Energy",
            "Vaal Invasion",
            "Vaal Winds",
            "Visions of the Drowned",
            "Vital Transformation",
            "Waiting in Ambush",
            "Weeping Death",
            "Wind and Thunder",
            "Winter's Mournful Melodies",
        };

        public bool verified { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int ilvl { get; set; }
        public string icon { get; set; }
        public string league { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string note { get; set; }
        public string typeLine { get; set; }
        public bool identified { get; set; }
        public string descrText { get; set; }
        public IEnumerable<string> flavourText { get; set; }
        public string prophecyText { get; set; }
        public int frameType { get; set; }
        public string category { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string inventoryId { get; set; }
    }
}