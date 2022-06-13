using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTxt
{
    public class TxtFile : File
    {
        public string Data { get; set; } = "";
        public string Creator { get; set; }
        public bool IsExists { get; set; }

        public void Create(string name, string creator, Directory directory)
        {
            IsExists = true;
            Name = name;
            Creator = creator;
            DirectoryInfo = directory;
        }

        public void Rename(string name)
        {
            Name = name;
        }

        public void Delete()
        {
            IsExists = false;
        }

        public string Print()
        {
            return Data;
        }

        public void AddContent(string content)
        {
            Data += content;
        }

    }
}
