using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;
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
                    return;
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
