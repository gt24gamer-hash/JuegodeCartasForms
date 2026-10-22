using System;
using System.Collections.Generic;
using System.Text;

namespace JuegodeCartasForms
{
    internal abstract class Personaje
    {
        public string Nombre { get; set; }
        private double hp;
        public double HP
        {
            get { return hp; }
            protected set
            {
                if (value < 0) { hp = 0; }
                else if (value > 99) { hp = 99; }
                else { hp = value; }
            }
        }
        private double atk;
        public double ATK
        {
            get { return atk; }
            set
            {
                if (value < 1) { atk = 1; }
                else if (value > 20) { atk = 20; }
                else { atk = value; }
            }
        }
        private int eng;
        public int ENG
        {
            get { return eng; }
            set
            {
                if (value < 0) { eng = 0; }
                else if (value > 10) { eng = 10; }
                else { eng = value; }
            }
        }
        private double def;
        public double DEF
        {
            get { return def; }
            set
            {
                if (value < 0) { def = 0; }
                else if (value > 20) { def = 20; }
                else { def = value; }
            }
        }

        public Personaje(string nombre, double hp, double atk, int eng, double def)
        {
            Nombre = nombre;
            HP = hp;
            ATK = atk;
            ENG = eng;
            DEF = def;

        }

        public virtual void RecibirDaño(double daño)
        {

            double dañoRestante;
            double defensaInicial;

            if (daño <= DEF)
            {
                DEF -= daño;
            }
            else
            {
                dañoRestante = daño;
                defensaInicial = DEF;

                DEF -= daño;
                dañoRestante -= defensaInicial;

                HP -= dañoRestante;

            }
        }

        public virtual void Defender()
        {
            DEF += 1;
        }

        public abstract void Atacar(Personaje enemigo);

        public abstract void HabilidadEsp();


    }
}
