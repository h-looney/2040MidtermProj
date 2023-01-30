using System;

namespace MidtermProject
{
    public enum Category
    {
        student,
        faculty,
        staff
    }
    class Person
    {
        private string firstName, lastName, id;
        private Category cat;
        
        public Person(string firstName, string lastName, string id, Category category)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.cat = category;
        }
        public void getPersonInfo()
        {
            Console.WriteLine("Name: {0} {1}",firstName, lastName);
            Console.WriteLine("ID: {0}; Type: {1}",id, cat);
        }
        public string getFirstName()
        {
            return firstName;
        }
        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public Category getCategory()
        {
            return this.cat;
        }
        public void setCategory(Category category)
        {
            this.cat = category;
        }
        public string getID()
        {
            return id;
        }
    }
}