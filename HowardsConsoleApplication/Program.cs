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

            Student  myperson = new Student();
            Teacher  myperson2 = new Teacher();
            myperson2.FirstName = "Yashoewa";
            myperson2.LastName = "Combs";
            myperson.Birthday = new DateTime(1974, 06,27);
            Teacher myteach3 = new Teacher { LastName = "Quack", FirstName = "Qwack" };
            double myage = myperson.Age;
            double mywholeage = Math.Round(myage, 2);
            Console.WriteLine(mywholeage);
            int myintage = int.Parse(myage.ToString().Split('.')[0]);
            Console.WriteLine(myintage);


            IPerson [] mypeeps = { myperson, myperson2, myteach3 };
            foreach (IPerson  peep in mypeeps)
            {
                Console.WriteLine("Hello " + peep.FullName + ",");
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
