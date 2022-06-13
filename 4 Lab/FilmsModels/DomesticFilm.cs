using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsModels
{
    public abstract class DomesticFilm : IFilm
    {
        public string Name { get; set; } = "";
        public string Country { get; set; } = "";
        public double Duration { get; set; }
        public int CountOfWathes { get; set; }

        public void AddScene(int minutes)
        {
            Duration += minutes;
        }

        public virtual void DeleteScene(int minutes)
        {
            Duration -= minutes;
        }

        public void Watch(int count)
        {
            CountOfWathes += count;
        }
    }
}
