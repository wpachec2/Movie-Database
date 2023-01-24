using System;
using System.Linq;
using System.Xml.Linq;

namespace Movie_Database
{
	public class Movie
	{
		//Properties
		public string Title { get; set; }
		public string Category { get; set; }


		//Constructor
		public Movie(string _title, string _catagory)
		{
			Title = _title;
			Category = _catagory;
		}


        //Methods
        public string GetDetails()
        {
            return $"{Title}";
        }
    }
}

