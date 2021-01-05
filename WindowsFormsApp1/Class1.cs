using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class super
    {
        string name , phone , address , gender ,age;

        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return name;
        }


        public void setage(string age)
        {
            this.age = age;
        }
        public string getage()
        {
            return age;
        }


        public void setphone(string phone)
        {
            this.phone = phone;
        }
        public string getphone()
        {
            return phone;
        }


        public void setaddress(string address)
        {
            this.address = address;
        }
        public string getaddress()
        {
            return address;
        }

        public void setgender(string gender)
        {
            this.gender = gender;
        }
        public string getgender()
        {
            return gender;
        }
    }
}
