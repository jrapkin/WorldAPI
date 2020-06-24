﻿using System;
using System.Collections.Generic;

namespace WorldAPI.DAL.Models
{
    public partial class Country
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Iso3 { get; set; }
        public string Iso2 { get; set; }
        public string PhoneCode { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public string Native { get; set; }
        public string Emoji { get; set; }
        public string EmojiU { get; set; }
    }
}