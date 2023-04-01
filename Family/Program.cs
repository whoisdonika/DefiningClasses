using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many people does the family consist of? - ");
            int n = int.Parse(Console.ReadLine());

            Person member = new Person();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the member's name : ");
                member.Name = Console.ReadLine();
                Console.Write("Enter the member's age : ");
                member.Age = int.Parse(Console.ReadLine());
                member.IntroduceYourself();
            }
        }
    }
}
