using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExamplePF6
{
    class Journal : Publications
    {
        public int IssueNo { get; set; }
        public DateTime PublicationDate { get; set; }

    }
}
