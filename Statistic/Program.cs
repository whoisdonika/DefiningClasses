using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of members : ");
            int n = int.Parse(Console.ReadLine());
            
            Family people = new Family();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the member's name and age : ");
                string[] s1 = Console.ReadLine().Split();
                string name = s1[0];
                int age = int.Parse(s1[1]);
                Person person = new Person(name, age);
                people.AddMembers(person);
            }
            
            people.Print();
           
        }
    }
}
