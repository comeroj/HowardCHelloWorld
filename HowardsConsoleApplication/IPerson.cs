using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowardsConsoleApplication
{
    interface IPerson
    {

        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }
        
    }
}
