using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace JuegodeCartasForms
{
    internal class GestordeEscenario
    {
        Queue<Personaje> team1 = new Queue<Personaje>();
        Queue<Personaje> team2 = new Queue<Personaje>();

        Stack<string> historial = new Stack<string>();
        RegistrodeBatalla registro = new RegistrodeBatalla();

        public void AñadiraEquipo(Personaje personaje, int team) 
        {

            if (team == 1)
            {
                team1.Enqueue(personaje);
            }
            else if (team == 2) 
            { 
                team2.Enqueue(personaje);
            }
        }
    
        public Personaje Relevo(Personaje personajeActual, int teamjugador)
        {
            if (personajeActual.HP > 0)
            {
                if (teamjugador == 1)
                {
                    team1.Enqueue(personajeActual);
                }
                else if (teamjugador == 2)
                {
                    team2.Enqueue(personajeActual);
                }
            }

            Personaje personajeEntrante = null;

                if (teamjugador == 1)
                {
                    personajeEntrante = team1.Dequeue();
                string team1Relevo = "El jugador 1 ha relevado a " + personajeActual.Nombre + " y entra " + personajeEntrante.Nombre;
                
                registro.RegistrarTurno(team1Relevo);

                historial.Push(team1Relevo);
                }
                else if (teamjugador == 2)
                {
                    personajeEntrante = team2.Dequeue();
                string team2Relevo = "El jugador 2 ha relevado a " + personajeActual.Nombre + " y entra " + personajeEntrante.Nombre;
                
                registro.RegistrarTurno(team2Relevo);

                historial.Push(team2Relevo);
                }
            
            return personajeEntrante;
        }
    
    
    
    }
}
