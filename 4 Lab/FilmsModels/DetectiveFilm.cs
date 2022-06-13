using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsModels
{
    public class DetectiveFilm : DomesticFilm
    {
        public string Producer { get; set; } = "";
        public int Year { get; set; }
        public string Description { get; set; }
        public void DoSequel(string name, int year, string description)
        {
            Year = year;
            Description = description;
            Name = name;
        }

        public string DescriptionInfo()
        {
            return Description + " " + Producer + " " + Year;
        }

        public override string ToString()
        {
            return $"Детектив: {Name}, год производства: {Year}.";
        }
    }
}
