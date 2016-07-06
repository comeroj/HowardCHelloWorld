using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowardsConsoleApplication
{
    public class Teacher : Person
    {
        public DateTime Birthday;
        public double Age
        {
            get
            {
                double Myage = DateTime.Today.Subtract(Birthday).TotalDays / 365;
                return Myage;
            }

}
