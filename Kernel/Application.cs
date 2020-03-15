using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel
{
    public class Application
    {

        string name = "";
        string version = "";
        string author = "";

        public string Name { get => name; }
        public string Version { get => version; }
        public string Author { get => author; }

        public Application(string name, string version, string author)
        {
            this.name = name;
            this.version = version;
            this.author = author;
        }
    }
}
