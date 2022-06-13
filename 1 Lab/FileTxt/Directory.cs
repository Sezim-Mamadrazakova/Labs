using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTxt
{
    public class Directory
    {
        public Directory()
        {
            Path = "//C/Folder/Project";
            Exists = true;
        }
        public string Path { get; set; }
        public bool Exists { get; set; }
    }
}
