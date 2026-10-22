using System;
using System.Collections.Generic;
using System.Text;

namespace JuegodeCartasForms
{
    internal class CartaAgua : Personaje
    {
        public CartaAgua(string nombre, double hp, double atk, int eng, double def)
            : base(nombre, hp, atk, eng, def)
        {
        }

        public override void Atacar(Personaje enemigo)
        {
            double dañototal = ATK;
            if (ENG < 2) {/*energia insuficiente*/ return; }
            else
            {          
                if (enemigo is CartaTierra)
                {
                    dañototal = dañototal * 0.80;
                }

                else if (enemigo is CartaFuego)
                {
                    dañototal = dañototal * 2;
                }
                
                enemigo.RecibirDaño(dañototal);
                ENG -= 2;
            }
        }

        public override void HabilidadEsp()
        {
          
        }

    }
}
