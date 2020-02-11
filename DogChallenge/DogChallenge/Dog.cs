using System;
using System.Collections.Generic;
using System.Text;

namespace DogChallenge
{
    class Dog
    {
        public string name { get; set; }
        public string owner { get; set; }
        public int age { get; set; }
        public Gender gender { get; set; }

        public Dog(string name, string owner, int age, Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }

        public void Bark(int barks)
        {
            for(int i = 0; i < barks; i++)
            {
                Console.Write("Woof!");
            }
            Console.WriteLine("\n");
        }

        public string GetTag()
        {
            var message = $"If lost, call {owner}. " +
                $"{(gender == Gender.Male ? "His" : "Her")} name is {name} and " +
                $"{(gender == Gender.Male ? "he" : "she")} is {age} {(age > 1 ? "years" : "year")} old.\n";


            return message;
        }
    }

    enum Gender
    {
        Male,
        Female
    }
}
