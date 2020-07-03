using System;

namespace AntoniaCarrizoExamen
{
    public class Coach:Person
    {
        private int tacticPoints;

        public Coach(int tacticPoints, string name, int age, string nationality, int salary)
        {
            this.TacticPoints = tacticPoints;
            this.Name = name;
            this.Age = age;
            this.Nationality = nationality;
            this.Salary = salary;
        }

        public int TacticPoints { get => tacticPoints; set => tacticPoints = value; }
    }
}
