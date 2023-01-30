using System;

namespace MidtermProject
{
    class Professor : Person
    {
        private string department, researchArea;
        public Professor(string firstName, string lastName, string id, string department, string researchArea) : base(firstName, lastName, id, Category.faculty)
        {
            this.department = department;
            this.researchArea = researchArea;
        }
        public string getDepartment()
        {
            return department;
        }
        public void setDepartment(string department)
        {
            this.department = department;
        }
        public string getResearchArea()
        {
            return researchArea;
        }
        public void setResearchArea(string researchArea)
        {
            this.researchArea = researchArea;
        }
    }
}