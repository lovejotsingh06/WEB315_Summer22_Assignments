using System;
using System.ComponentModel.DataAnnotations;

namespace journalism.Models
{
    public class journalism1
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public string Award { get; set; }
        public string Stories { get; set; }

        /*public int Rating { get; set;}
        public string RelatedFilms {get; set;}*/
    }
}



