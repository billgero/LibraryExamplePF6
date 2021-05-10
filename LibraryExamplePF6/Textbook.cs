using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExamplePF6
{
    class Textbook : Publications, IRentable
    {
        public string editor { get; set; }

    }
}
