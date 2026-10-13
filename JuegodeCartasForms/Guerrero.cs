using System;
using System.Collections.Generic;
using System.Text;

namespace JuegodeCartasForms
{
    internal class Guerrero : Personaje
    {
        public Guerrero(string nombre, double fuerza, double magia, double resistencia/*, string objeto1, string objeto2*/)
            : base(nombre, fuerza, magia, resistencia/*, objeto1, objeto2*/)
        {
            Vida = Vida * 1.2;
        }

        public override void recibirDaño(double daño)
        {
            double defensa = Resistencia * 1.8;

            double dañoVerdadero = daño - defensa;

            if (dañoVerdadero < 0) { dañoVerdadero = 0; }

            base.recibirDaño(dañoVerdadero);
            
        }

        public override double CalcularDaño()
        {
            double dañoTotal = Fuerza * 1.5;

            return dañoTotal;
        }


    
    }
}
