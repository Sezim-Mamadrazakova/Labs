using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsModels
{
    public class DramaticFilm : DomesticFilm
    {
        public string Producer { get; set; } = "";
        public double Raiting { get; set; }
        public void UpRating(int count)
        {
            Raiting += count * 12;
        }

        public double Quallity()
        {
            return Raiting * Duration;
        }

        public override void DeleteScene(int minutes)
        {
            Duration -= minutes * 0.5;
        }

        public override string ToString()
        {
            return $"Драмма: {Name}, режиссер: {Producer}.";
        }
    }
}
