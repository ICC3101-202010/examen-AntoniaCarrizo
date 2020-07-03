using System;
namespace AntoniaCarrizoExamen
{
    public class CourtPlayer:Player
    {
        public CourtPlayer(int attackPoints, int defensePints, int shirtNumber, string name, int age, string nationality, int salary)
        {
            this.AttackPoints = attackPoints;
            this.DefensePints = defensePints;
            this.ShirtNumber = shirtNumber;
            this.Name = name;
            this.Age = age;
            this.Nationality = nationality;
            this.Salary = salary;
        }


    }
}
