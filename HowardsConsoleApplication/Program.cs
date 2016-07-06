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

            Student  mystudent = new Student();
            mystudent.LastName = "John";
            mystudent.FirstName = "Smith";
            mystudent.Birthday = new DateTime(2011, 06, 15);
            double sage = mystudent.Age;
            int sintage = int.Parse(sage.ToString().Split('.')[0]);

            Student mystudent1 = new Student();
            mystudent1.LastName = "Loretta";
            mystudent1.FirstName = "Blackburn";
            mystudent1.Birthday = new DateTime(2003, 12, 05);
            double sage1 = mystudent1.Age;
            int sintage1 = int.Parse(sage1.ToString().Split('.')[0]);

            Student mystudent2 = new Student();
            mystudent2.LastName = "David";
            mystudent2.FirstName = "Peterson";
            mystudent2.Birthday = new DateTime(2003, 11, 28);
            Student mystudent3 = new Student();
            mystudent3.LastName = "Robert";
            mystudent3.FirstName = "Miller";
            mystudent3.Birthday = new DateTime(2003, 07, 19);
            Student mystudent4 = new Student();
            mystudent4.LastName = "Lucy";
            mystudent4.FirstName = "Thompson";
            mystudent4.Birthday = new DateTime(2004, 01, 03);

            Teacher myteach = new Teacher { LastName = "Denise", FirstName = "Maples" };
            myteach.Birthday = new DateTime(1974, 06,27);
            Teacher myteach1 = new Teacher { LastName = "Micheal", FirstName = "Baker" };
            myteach1.Birthday = new DateTime(1958, 07, 31);
            Teacher myteach2 = new Teacher { LastName = "Ester", FirstName = "Perkins" };
            myteach2.Birthday = new DateTime(1976, 11, 18);
            Teacher myteach3 = new Teacher { LastName = "Marie", FirstName = "Tanner" };
            myteach3.Birthday = new DateTime(1968, 04, 21);
            Teacher myteach4 = new Teacher { LastName = "Donald", FirstName = "Scotts" };
            myteach4.Birthday = new DateTime(1979, 07, 10);

            // double mywholeage = Math.Round(myage, 2);
            //Console.WriteLine(mywholeage);
            //Console.Write(mystudent.FullName);
            //Console.Write(" Age =");
            //Console.WriteLine(sintage);


            IPerson [double sage = peep.;
            int sintage = int.Parse(sage.ToString().Split('.')[0]);]
             mypeeps = { mystudent, mystudent1, mystudent2, mystudent3, mystudent4, myteach,
                myteach1, myteach2, myteach3, myteach4 };
            foreach (IPerson  peep in mypeeps)
            {
                Console.WriteLine("Hello " + peep.FullName + ",");
            }
            Console.WriteLine(sintage);
            int i = 0;
            while (true)
            {
                Console.WriteLine(i);
                i += 1;
                if (i > 10) { break; }
            }
        }
    }
}
