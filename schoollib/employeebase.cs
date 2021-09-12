namespace schoollib
{
    public class employeebase :IEmployee
    {
        public int Id { get; set; }
        public string fullName { get; set; }
        //public double sal { get; set; }
        public virtual double Sal { get; set; }


    }
}
