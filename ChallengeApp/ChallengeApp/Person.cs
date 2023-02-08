using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
    }
}
