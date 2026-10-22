using System;
using System.Collections.Generic;
using System.Text;

namespace JuegodeCartasForms
{
    internal class CartaFuego : Personaje
    {
        public CartaFuego(string nombre, double hp, double atk, int eng, double def)
            : base(nombre, hp, atk, eng, def)
        {
        }

        public override void Atacar(Personaje enemigo)
        {
            double dañototal = ATK;
            if (ENG < 2) {/*energia insuficiente*/ return; }
            else
            {
                if (enemigo is CartaAgua)
                {
                    dañototal = dañototal * 0.50;
                }
                
                else if (enemigo is CartaAire)
                {
                    dañototal = dañototal * 1.15;
                }

                enemigo.RecibirDaño(dañototal);
                ENG -= 2;
            }
        }

        int turnosRestantesBuffFuego;

        public override void HabilidadEsp()
        {
            
            if (ENG < 6) { return; }
            else
            {
                turnosRestantesBuffFuego = 3;
                /*Habilidad de fuego: Prendido en Candela*/

                HP += 25;
                ATK += 5;
                ENG -= 6;
            }

        }

    }
}
