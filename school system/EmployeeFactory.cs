using schoollib;

namespace school_system
{
    public enum EmployeeType
    { HeadMaster,
        Teacher,
        HeadOfDepartment,
    }
    public  class EmployeeFactory
    {
        public static IEmployee GetEmployeeInstane(EmployeeType employtype,int id,string name,double sal)
        {
            IEmployee employee = null;
            switch(employtype)
            {
                case EmployeeType.HeadMaster:

                    employee = new HeadMaster { Id = id, fullName = name, Sal = sal };
                    break;

                case EmployeeType.Teacher:
                    
                        employee = new Teacher { Id = id, fullName = name, Sal = sal };
                    break;


                case EmployeeType.HeadOfDepartment:
                    employee = new HeadOfDepartment { Id = id, fullName = name, Sal = sal };
                    break;


                default:
                    break;
            }

            return employee;

        }
    }
}
