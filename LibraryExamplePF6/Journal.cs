using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExamplePF6
{
    class Journal : Publications, IRentable
    {
        public int issueNo { get; set; }
        public DateTime publicationDate { get; set; }

    }
}
