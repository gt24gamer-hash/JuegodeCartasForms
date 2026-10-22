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



        }

        public override void HabilidadEsp()
        {
            throw new NotImplementedException();
        }

    }
}
