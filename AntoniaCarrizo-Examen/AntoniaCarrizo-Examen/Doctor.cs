using System;
namespace AntoniaCarrizoExamen
{
    public class Doctor : Person
    {
        private int experiencePoints;

        public Doctor(int experiencePoints, string name, int age, string nationality, int salary)
        {
            this.ExperiencePoints = experiencePoints;
            this.Name = name;
            this.Age = age;
            this.Nationality = nationality;
            this.Salary = salary;
        }

        public int ExperiencePoints { get => experiencePoints; set => experiencePoints = value; }
    }
}