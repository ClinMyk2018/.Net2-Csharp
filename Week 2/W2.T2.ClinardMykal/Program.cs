using System;

namespace W2.T2.ClinardMykal
{
    internal class HighSchoolRosterProgram
    {
        private static void Main(string[] args)
        {
            Student s = new Student();
            s.FirstName = "Mykal";
            Console.WriteLine("Student:\t" + s.FirstName);
        }
    }
}
