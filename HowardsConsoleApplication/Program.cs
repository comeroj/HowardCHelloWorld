using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowardsConsoleApplication
{
    class Program
    {


        static void Main(string[] args)
        {

            Person myperson = new Person();
            Person myperson2 = new Person("Jim", "Jones");
            Person[] mypeeps = { myperson, myperson2 };
            foreach (Person peep in mypeeps)
            {
                Console.WriteLine("Hello " + peep.Fullname + ",");
            }
            int i = 0;
            while (true)
            {
                Console.WriteLine(i);
                i += 1;
                if (i > 200) { break; }
            }
        }
    }
}
