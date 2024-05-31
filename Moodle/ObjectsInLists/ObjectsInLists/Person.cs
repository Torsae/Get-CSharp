using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsInLists
{
    internal class Person(string name, int age)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;

        public static List<Person> people = new List<Person>
        {
            new Person("Alice", 25),
            new Person("Bob", 30),
            new Person("Charlie", 28),
        };

        public static void AddPeople(Person input)
        {
            people.Add(input);
        }

        public static void PrintList()
        {
            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }

            Console.WriteLine("");
        }

        //public List<Person> People = new List<Person>
        //{
        //    new Person("Alice", 25),
        //    new Person("Bob", 30),
        //    new Person("Charlie", 28)
        //};
        
    }
}
