using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
    class Person
    {
        private string _name;
        private string _family;
        private string _job;
        private string _sex;
        //--------------------------------------------

        public string Name
        {

            get { return _name; }
            set { _name = value; }


        }

        public string Family
        {

            get { return _family; }
            set { _family = value; }


        }

        public string Job
        {

            get { return _job; }
            set { _job = value; }


        }

        public string Sex
        {

            get { return _sex; }
            set { _sex = value; }


        }



    }
}
