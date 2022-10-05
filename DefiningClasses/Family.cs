using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            People = new List<Person>();
        }

        public List<Person> People
        {
            get { return this.people; }

            set { this.people = value; }
        }

        public void AddMember(Person member)
        {
            People.Add(member);
        }
        
        public Person GetOldestMember()
        {
            int largestAge = int.MinValue;

            Person oldestPerson = null;

            foreach (Person person in people)
            {
                if (person.Age > largestAge)
                {
                    largestAge = person.Age;
                    oldestPerson = person;
                }
            }

            return oldestPerson;
        }
    }
}
