using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class patient:super
    {
        string blood ,room;

        public void setroom(string room)
        {
            this.room = room;
        }
        public string getroom()
        {
            return room;
        }



        public void setblood(string blood)
        {
            this.blood = blood;
        }
        public string getblood()
        {
            return blood;
        }

    }
}
