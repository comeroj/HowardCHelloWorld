using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowardsConsoleApplication
{
    class Student:Person
    {


        public Student()
        {
            LastName = "Johnson";
        }
        public Student(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }

        
        private string _firstname = "Howard";
        public bool hadadog = false;
        public int age = 3;
        public DateTime Birthday { get; set; }
        public long secondsalive = 168465189;
        public double moneyinthebank = 15.21;
        decimal pie = 3.1405168161M;
        public string[] nicknames = { "abe", "jones" };
        public DateTime _today = DateTime.Now;
        public Guid? myguid = Guid.NewGuid();
        private string _fullname;
        public double Age {
            get{
                double Myage = DateTime.Today.Subtract(Birthday).TotalDays / 365;
                return Myage;

            }
        }
        public override string FullName
        {
            get
            {
                if (_fullname == null)
                {
                    _fullname = FirstName + " " + LastName;
                }

                return _fullname;
            }
        }
        
                           
     
    }
}
