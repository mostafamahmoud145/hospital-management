using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class employee:super
    {
        string salary, to,from,department;

        public void setsalary(string salary)
        {
            this.salary = salary;
        }
        public string getsalary()
        {
            return salary;
        }
        

        public void setto(string to)
        {
            this.to = to;
        }
        public string getto()
        {
            return to;
        }

        public void setfrom(string from)
        {
            this.from = from;
        }
        public string getfrom()
        {
            return from;
        }


        public void setdeprtment(string department)
        {
            this.department = department;
        }
        public string getdepartment()
        {
            return department;
        }
    }
}
