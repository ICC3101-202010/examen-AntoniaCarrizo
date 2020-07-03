using System;

namespace AntoniaCarrizoExamen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CourtPlayer p1 = new CourtPlayer(200,100,28,"anto",22,"chile",2000000);
            CourtPlayer p2 = new CourtPlayer(200, 100, 33, "juan", 22, "argentina", 2000000);
            CourtPlayer p3 = new CourtPlayer(200, 100, 55, "diego", 22, "españa", 2000000);
            Goalkeeper p4 = new Goalkeeper(200, 100, 10, "jorge", 22, "chile", 2000000);
            Coach c1 = new Coach(100,"coach 1",50,"chile",1000000);
            Doctor d1 = new Doctor(300,"doctor1",60,"peru",250000);
            Team team1 = new Team(c1,d1,"EquipoChile",true,"chile");
            Team team2 = new Team(c1, d1, "Equipoliga",false, "league");

            /*Si el equipo es nacional debe ingresar true, si es de liga debe ingresar false
             *Si un equipo es nacional y se le intenta agrega un jugador que no pertenece a la misma
             *nacion del equipo, el programa no lo dejara.
             *Si un equipo es de liga se le puede agregar un jugador de cualquier nacionalidad
            */

            //Agregar jugadores
          
            team1.AddPlayer(p4);
            team1.AddPlayer(p1);
            team1.AddPlayer(p3);
            team2.AddPlayer(p2);
            team2.ReturnInfo();
            //ver info  -- Tambien podemos obtener la informacion a traves  de sus metodos get y set,
            //por ejemplo: Console.Writeline(team1.NameTeam);
            team1.ReturnInfo();

            //Corroborar nacionalidades
            if (team1.CorroborateNationality()==true)
            {
                Console.WriteLine("Todos los jugadores pertenecen a la nacion");
            }
            else
            {
                Console.WriteLine("Existen jugadores que no pertenecen a la nacion");
            }


            //Eliminar jugador "no se pide en enunciado, pero por en el chat salia como opcion"
            team1.DeletePlayer(p4);

            //ver info Para ver si se borro el jugador 
            team1.ReturnInfo();

        }
    }
}
