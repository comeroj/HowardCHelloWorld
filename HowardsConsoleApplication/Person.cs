﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowardsConsoleApplication
{
    public class Person: IPerson
    {
        private string _firstname;
        private string _fullname;

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

        public virtual string FullName
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

        public string LastName { get; set; }
    }
}
