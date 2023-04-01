using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            Person secondPerson = new Person();
            Person thirdPerson = new Person();

            firstPerson.Name = "Gosho";
            firstPerson.Age = 15;
            firstPerson.IntroduceYourself();

            secondPerson.Name = "Ivan";
            secondPerson.Age = 13;
            secondPerson.IntroduceYourself();

            thirdPerson.Name = "Petur";
            thirdPerson.Age = 20;
            thirdPerson.IntroduceYourself();
        }
    }
}
