using System;
using System.Collections.Generic;
using System.Text;

namespace JuegodeCartasForms
{
    internal class CartaTierra : Personaje
    {
        public CartaTierra(string nombre, double hp, double atk, int eng, double def)
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
                    dañototal = dañototal * 1.5;
                }

                else if (enemigo is CartaAire)
                {
                    dañototal = dañototal * 0.80;
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
