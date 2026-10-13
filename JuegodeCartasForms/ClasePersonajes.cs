using System;
using System.Collections.Generic;
using System.Text;

namespace JuegodeCartasForms
{
    internal abstract class Personaje
    {
        public string Nombre { get ; set; }
        private double vida = 100;
        public double Vida
        {
            get { return vida; }
            protected set
            {
                if (value < 0) { vida = 0; }
                else { vida = value; }
            }
        }


        private double fuerza;
        public double Fuerza
        {
            get { return fuerza; }
            set{
                if (value < 1) { fuerza = 1; }
                else if (value > 20) { fuerza = 20; }
                else { fuerza = value; }
               }
        }

        private double magia;
        public double Magia
        {
            get { return magia; }
            set
            {
                if (value < 1) { magia = 1; }
                else if (value > 20) { magia = 20; }
                else { magia = value; }
            }
        }

        private double resistencia;
        public double Resistencia 
        { 
            get { return resistencia;  }
            set {
                if (value < 1) { resistencia = 1; }
                else if (value > 20) { resistencia = 20; }
                else { resistencia = value; }
                }
        }

       /* public string objeto1 { get; set; }
        public string objeto2 { get; set; }*/


        public Personaje(string nombre, double fuerza, double magia, double resistencia/*, string objeto1, string objeto2*/)
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Magia = magia;
            Resistencia = resistencia;
           /* this.objeto1 = objeto1;
            this.objeto2 = objeto2;*/

        }

        public virtual void recibirDaño(double daño)
        { 
            Vida = Vida-daño;
            //el personaje pierde vida
        }

        public abstract double CalcularDaño();
    }
}
