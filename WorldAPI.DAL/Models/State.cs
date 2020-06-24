using System;
using System.Collections.Generic;

namespace WorldAPI.DAL.Models
{
    public partial class State
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? CountryId { get; set; }
        public string CountryCode { get; set; }
        public string StateCode { get; set; }
    }
}
