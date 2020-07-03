using System;
namespace AntoniaCarrizoExamen
{
    public class Goalkeeper:Player //Tambien implementa la interfaz IPlayBow
    //pero como no la usamos para este ejemplo no la ponemos.
    //Con la clase abstracta y la interfaz mostramos que existe polimorfismo, ya que un jugador
    //puede ser arquero o jugador 
    {

        public Goalkeeper(int attackPoints, int defensePints, int shirtNumber, string name, int age, string nationality, int salary)
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
