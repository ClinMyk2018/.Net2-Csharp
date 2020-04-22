namespace W2.T3.ClinardMykal
{
    internal class Person: Student
    {

        private string Date_of_Birth;
        private string SSN;
        private string Phone_Number_1;
        private string Phone_Number_2;
        private string Address_1;
        private string Address_2;
        private string City;
        private string State;
        private string Zip;

        public string DateofBirth
        {
            get { return Date_of_Birth; }
            set { Date_of_Birth = value; }
        }

        public string sSN
        {
            get { return SSN; }
            set { SSN = value; }
        }

        public string PhoneNumber1
        {
            get { return Phone_Number_1; }
            set { Phone_Number_1 = value; }
        }

        public string PhoneNumber2
        {
            get { return Phone_Number_2; }
            set { Phone_Number_2 = value; }
        }

        public string Address1
        {
            get { return Address_1; }
            set { Address_1 = value; }
        }

        public string Address2
        {
            get { return Address_2; }
            set { Address_2 = value; }
        }

        public string city
        {
            get { return City; }
            set { City = value; }
        }

        public string state
        {
            get { return State; }
            set { State = value; }
        }

        public string zip
        {
            get { return Zip; }
            set { Zip = value; }
        }
    }
}