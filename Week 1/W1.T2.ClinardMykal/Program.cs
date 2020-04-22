using System;

namespace W1.T2.ClinardMykal
{
    class Program
    {
        internal class Metals
        {
            private string _metalType;

            public Metals(String type)
            {
                _metalType = type;
                Console.WriteLine("Metal\t\t:" + _metalType);
            }
        }

        internal class SteelCompany : Metals    //New class - What goes here?
        {
            private string _grade;

            public SteelCompany(string grade) : base("Steel")  //Reference - What goes here?
            {
                _grade = grade;
                Console.WriteLine("Grade\t\t:" + _grade);
            }
        }

        internal class Automobiles : SteelCompany      //New class - What goes here?
        {
            private string _part;

            public Automobiles(string part) : base("Cast Iron")  //Reference - What goes here?
            {
                _part = part;
                Console.WriteLine("Part\t\t:" + _part);
            }
        }

        public static void Main()
        {
            Automobiles auto = new Automobiles("Mercedes");
            Console.ReadKey();
        }
    }
}