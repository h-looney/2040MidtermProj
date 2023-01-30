using System;

namespace MidtermProject
{
    public enum StudentClass
    {
        freshman,
        sophomore,
        junior,
        senior
    }
    class Student : Person
    {
        private string major;
        private int creditHours;
        
        public Student(string firstName, string lastName, string id, string major, int creditHours) : base(firstName, lastName, id, Category.student)
        {
            this.major = major;
            this.creditHours = creditHours;
        }
        public int getCreditHours()
        {
            return creditHours;
        }
        public void updateCreditHours(int addCreditHours)
        {
            this.creditHours += addCreditHours;
        }
        public StudentClass getStudentClass()
        {
            if(0 < this.creditHours && this.creditHours < 29)
            {
                return StudentClass.freshman;
            }
            if(30 < this.creditHours && this.creditHours < 59)
            {
                return StudentClass.sophomore;
            }
            if(60 < this.creditHours && this.creditHours < 89)
            {
                return StudentClass.junior;
            }
            return StudentClass.senior;
        }
    }
}