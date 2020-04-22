namespace W2.T2.ClinardMykal
{
    internal class Person
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