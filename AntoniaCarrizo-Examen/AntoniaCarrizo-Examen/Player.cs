using System;
namespace AntoniaCarrizoExamen
{
    public abstract class Player: Person 
    {
        private int attackPoints;
        private int defensePints;
        private int shirtNumber;


        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public int DefensePints { get => defensePints; set => defensePints = value; }
        public int ShirtNumber { get => shirtNumber; set => shirtNumber = value; }
        
    }
}
