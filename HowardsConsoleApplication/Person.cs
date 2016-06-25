using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowardsConsoleApplication
{
    class Person
    {


        public Person()
        {
            LastName = "Johnson";
        }
        public Person(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }

        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
                _fullname = null;
            }
        }
        private string _firstname = "Howard";
        public string LastName { get; set; }
        public bool hadadog = false;
        public int age = 3;
        public long secondsalive = 168465189;
        public double moneyinthebank = 15.21;
        decimal pie = 3.1405168161M;
        public string[] nicknames = { "abe", "jones" };
        public DateTime _today = DateTime.Now;
        public Guid? myguid = Guid.NewGuid();
        private string _fullname;
        public string Fullname
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
