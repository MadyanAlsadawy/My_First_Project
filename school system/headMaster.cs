using schoollib;
namespace school_system
{
    class HeadMaster:employeebase
    {
        public override double Sal
        {
            get
            {
                return base.Sal + (0.20);
            }


        }
    }
}
