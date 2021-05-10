using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExamplePF6
{
    class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool active { get; set; }
        public List<IRentable> rentedObjects { get; set; }

        public void toggleActive()
        {
            active = !active;
        }

        public List<IRentable> getRentedObjects()
        {
            return rentedObjects;
        }

    }
}
