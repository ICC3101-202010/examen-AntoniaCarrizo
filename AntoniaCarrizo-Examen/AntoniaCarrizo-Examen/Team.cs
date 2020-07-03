using System;
using System.Collections.Generic;

namespace AntoniaCarrizoExamen
{
    public class Team
    {
        private List<Player> players= new List<Player>();
        private Coach coach;
        private Doctor doctor;
        private string nameTeam;
        private bool national;  //si es nacional se pone true, si es de liga false
        private string nameNationOrLeague; //nombre de la nacion o liga a la que pertenece 
        public Team(Coach coach, Doctor doctor, string nameTeam, bool national, string nameNationOrLeague)
        {
            this.Coach = coach;
            this.Doctor = doctor;
            this.NameTeam = nameTeam;
            this.National = national;
            this.NameNationOrLeague = nameNationOrLeague;
        }

        //Para ver la informacion si es que se quiere obtener desde program
        public string NameNationOrLeague { get => nameNationOrLeague; set => nameNationOrLeague = value; }
        public List<Player> Players { get => players; set => players = value; }
        public Coach Coach { get => coach; set => coach = value; }
        public Doctor Doctor { get => doctor; set => doctor = value; }
        public string NameTeam { get => nameTeam; set => nameTeam = value; }
        public bool National { get => national; set => national = value; }

        //Corrobora la nacionalidad de todos los jugadores existentes
        public bool CorroborateNationality()
        {
            foreach (Player p in Players)
            {
                if (p.Nationality.ToLower() != NameNationOrLeague.ToLower())
                {
                    return false;
                }

            }   
            return true;
        }

        //Corrobora la nacionalidad de los jugadores agregados, si es que pertenecen a un equipo nacional
        public bool AddPlayer(Player player)
        {
            if (Players.Count<15)
            {
                if (National == true)
                {
                    if (player.Nationality.ToLower() == NameNationOrLeague.ToLower())
                    {
                        Players.Add(player);
                        Console.WriteLine("Jugador agregado");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("el jugador debe ser de la misma nacionalidad");
                        return false;
                    }
                }
                else
                {
                    Players.Add(player);
                    Console.WriteLine("Jugador agregado");
                    return true;
                }
            }
            else
            {
                Console.WriteLine("El equipo ha alcanzado su limite de jugadores");
                return false;
            }
            
            
        }

        //Retornamos la informacion, para hacerlo de forma mas ordenada
        //Notar que igualmente utilizamos los get y set de los atributos
        //Otra forma de hacerlo es poniendo los atributos estaticos, pero como queremos
        //que se obtenga la informacion igualmente desde afuera, lo dejamos asi.
        public void ReturnInfo()
        {
            Console.WriteLine("Informacion equipo:");
            Console.WriteLine("1) Nombre: "+NameTeam);
            if (National==true)
            {

                Console.WriteLine("2) Tipo: Nacional ");
                Console.WriteLine("3) Nombre nacion: " + NameNationOrLeague);
            }
            else
            {

                Console.WriteLine("2) Tipo: Liga ");
                Console.WriteLine("3) Nombre Liga: " + NameNationOrLeague);
            }
            Console.WriteLine("4) Medico: " + Doctor.Name);
            Console.WriteLine("5) Entrenador: " + Coach.Name);

            
            int contador = 1;
            if (Players.Count>0)
            {
                Console.WriteLine("6) Jugadores: ");
                foreach (Player p in Players)
                {
                    Console.WriteLine(" " + contador + ".- Nombre: " + p.Name + "- Num Camiseta: " + p.ShirtNumber);
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("6) No hay jugadores en el equipo");
            }
            


        }
        public bool DeletePlayer(Player player)
        {
            if (Players.Count>0)
            {
                if (Players.Contains(player)==true)
                {
                    Players.Remove(player);
                    return true;
                }
                else
                {
                    Console.WriteLine("No existe el jugador");
                    return false;
                }
                
            }
            else
            {
                Console.WriteLine("No existen jugadores para eliminar");
                return false;
            }
            
        }


    }
}
