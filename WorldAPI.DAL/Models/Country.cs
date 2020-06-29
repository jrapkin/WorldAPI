using System;
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
    //Additional Properties
    public partial class Country
	{
       public ICollection<State> States { get; set; }
	}
    //Get Methods for AutoMapper
    public partial class Country
	{
        public string GetCountryName()
		{
            return Name;
		}
        public string GetCountryCapitalCity()
		{
            return Capital;
		}
	}
}
