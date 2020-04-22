using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2.T3.ClinardMykal
{
    class Student
    {

        private string First_Name;
        private string Last_Name;
        private string Age;

        public string FirstName
        {
            get { return First_Name; }
            set { First_Name = value; }
        }

        public string LastName
        {
            get { return Last_Name; }
            set { Last_Name = value; }
        }

        public string age
        {
            get { return Age; }
            set { Age = value; }
        }

    }
}
