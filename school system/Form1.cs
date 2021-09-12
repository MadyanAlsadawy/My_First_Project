using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using schoollib;

namespace school_system
{

    public partial class Form1 : Form
    {
        public List<IEmployee> employee = new List<IEmployee>();
        public EmployeeType Employee_Type;
        private readonly object l;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {   
            int id = int.Parse(textBoxID.Text);
            string name = textBoxName.Text;
            double sal = double.Parse(textBoxSalary.Text);
            employee.Add(EmployeeFactory.GetEmployeeInstane(Employee_Type, id, name, sal));
             labelsumesal.Text = employee.Sum(q => q.Sal).ToString();
            labelcountemp.Text = employee.Count.ToString();
        }

        private void typeemployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee_Type = (EmployeeType)typeEmployee.SelectedIndex;  //BIND comboBox from Enum
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            typeEmployee.DataSource = Enum.GetValues(typeof(EmployeeType));
        }


       public double sumsal(List<IEmployee> L)
        {
            return L.Sum(e => e.Sal);
        }

        private void labelcountemp_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxSalary.Clear();
        }
    }
}
