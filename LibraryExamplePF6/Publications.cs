using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExamplePF6
{
    public abstract class  Publications 
    {
        public string author { get; set; }
        public string tittle { get; set; }
        public string publisher { get; set; }
        public static List<Publications> allPublications { get; set; }

        public static List<Publications> getPublications()
        {
            return allPublications;
        }
    }
}
