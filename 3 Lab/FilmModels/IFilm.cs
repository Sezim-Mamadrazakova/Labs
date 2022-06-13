using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmModels
{
    public interface IFilm
    {
        public string Name { get; set; }
        public void Watch(int count);
        public void AddScene(double minutes);
    }
}
