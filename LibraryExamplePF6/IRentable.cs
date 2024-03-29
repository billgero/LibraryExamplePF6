﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExamplePF6
{
    interface IRentable
    {
        public DateTime lastUpdate { get; set; }
        public bool Available {get;set;}
        public void Rent(Member member);
        public void Return(Member member);

    }
}
