using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmModels
{
    public class ComedyFilm : DomesticFilm
    {
        public string Producer { get; set; } = "";
        public double Fees { get; set; } 
        public void UpRating(double count)
        {
            Fees += count * 5;
        }

        public void DoRemake(string producer, string name)
        {
            Producer = producer;
            Name = name;
            CountOfWathes = (int)Fees * 5;
        }

        public override void DeleteScene(double minutes)
        {
            Duration -= minutes * 0.3;
        }

        public override string ToString()
        {
            return $"Фильм: {Name}, режиссер: {Producer}.";
        }
    }
}
