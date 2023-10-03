using System;
namespace EjercicioI04
{
	public class Boligrafo
	{
		public short cantidadTintaMaxima;
		private ConsoleColor color;
		private short tinta;

		public Boligrafo(short tinta, ConsoleColor color)
		{
			this.tinta = tinta;
			this.color = color;
			cantidadTintaMaxima = 100;
		}

		public ConsoleColor GetColor()
		{
			return color;
		}

        public short GetTinta()
        {
            return tinta;
        }

		public void Pintar(short gasto, out string dibujo)
		{

            // dibujo inicialmente lo pongo en vacio porque si no hay tinta no va a dibujar nada
            dibujo = "";

			// si tenemos tinta, entonces ahi hago el dibujo
            if (tinta >= 0)
            {

                //aca hago guardo en la variable que llamo "resultante" lo que quedaría de tinta si se hace el dibujo entero
                short resultante = (short)(tinta - gasto);

				// ejemplo:
				// si gasto = 10 y tinta = 15, resultante = 5
				// si gasto = 5 y tinta = 3, resultante = -2

				// aca guardo el valor actual de tinta antes de hace el dibujo, lo que pense yo es:
				// si tu tinta actual es 3 y el dibujo que queres hacer es 5
				// lo unico q vas a poder hacer de tu dibujo es lo que te alcance la tinta (o sea 3) (asi lo pide el enunciado)
				short gastoReal = tinta;

				// aca digo:
				// si  resultante es MAYOR O IGUAL A CER0 (o sea tenía tinta suficiente
				// para hacer el dibujo entero) entonces cambio gastoReal a gasto, porque alcanzo a hacerlo entero
				// ponele que el dibujo que tenes que hacer es de 10 y de tinta tenias 15
				// en la linea 41 gastoReal = 15, pero en realidad no gastamos 15, gastamos solo 10, entonces lo cambio
				if (resultante >= 0)
					gastoReal = gasto;

				// si resultante es MENOR a CERO (ejemplo linea 37), es decir no te alcanza para hacer el dibujo entero
				// entonces tu gasto es el TOTAL de lo que tenias de tinta (lo que hago en la linea 41)

				// aca resto la tinta usada
				SetTinta((short)(gastoReal*-1));
				// aca hago el dibujo (total o hasta donde se llegue)
				dibujo = string.Concat(Enumerable.Repeat("*", gastoReal));
			}
		}

		public void Recargar()
		{
			SetTinta((short)(cantidadTintaMaxima-tinta));
		}

		private void SetTinta(short tinta)
		{
			short tintaResultante = (short)(this.tinta + tinta);

			if(tintaResultante >= 0 && tintaResultante <= cantidadTintaMaxima)
			{
				this.tinta = tintaResultante;
			}
			
		}
    }
}

