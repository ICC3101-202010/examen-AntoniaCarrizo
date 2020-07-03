using System;
namespace AntoniaCarrizoExamen
{
    public abstract class Person
    {
        /*Clase padre de las cuales heredan Coach,Doctor y Player, la definimos así
         * ya que estas clases tienen en comun los atributos name, age, nationality y salary
        */
        private string name;
        private int age;
        private string nationality;
        private int salary;
        /*Para los atributos podria ocupar protected para que sus clases
         * hijas puedan acceder a ellos, pero como ya tengo los metodos get y set
         * de estos, por el motivo dicho anteriormente, los dejo como private.
         */
        public Person()
        {

        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public int Salary { get => salary; set => salary = value; }

    }
}
