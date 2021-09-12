using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using schoollib;

namespace school_system
{
   public class HeadOfDepartment :employeebase
    {
           
        public override double Sal
        {
            get
            {
                return base.Sal+(0.10);
            }

           
        }
    }
}
