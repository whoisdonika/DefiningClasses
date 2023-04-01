using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistic
{
    internal class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name { get; set; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 1 || value > 99)
                {
                    Console.WriteLine("Invalid value for age!");
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"I am {this.Name} and I am {this.Age} years old.");
        }
    }
}
