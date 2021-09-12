using schoollib;

namespace school_system
{
    public  class Teacher :employeebase
    {
        public override double Sal
        {
            get
            {
                return base.Sal+(0.03);
            }

           
        }
    }
}
