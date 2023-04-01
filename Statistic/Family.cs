using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistic
{
    internal class Family
    {
        public List<Person> Members = new List<Person>();
        public void AddMembers(Person person)
        {
            if (person.Age >= 30)
            {
                Members.Add(person);
            }
        }
        public void Print()
        {
            Members.Sort((person1, person2) => string.Compare(person1.Name, person2.Name));
            foreach (Person Familymember in Members)
            {
                Console.WriteLine($"{Familymember.Name} {Familymember.Age}");
            }
        }
    }
}
