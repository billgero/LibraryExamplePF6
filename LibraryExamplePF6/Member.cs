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
        public List<IRentable> RentedObjects { get; set; }

        public Member(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            active = true;
        }

        public void toggleActive()
        {
            try { active = !active; }
            catch ( Exception exception )
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine(this.firstName, this.lastName, this.active);
            }
            
        }

        public List<IRentable> GetRentedObjects()
        {
            return RentedObjects;
        }

    }
}
