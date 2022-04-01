using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_07.Clases
{
    internal class Tractor : Carro
    {
        public int levantarpala;
        public int bajarpala;
        public int capacidadcarga = 100;

        public Tractor(string _marca,  int maxvel, string dueño, string color) : base(_marca, maxvel, dueño, color)
        {

        }

        public string LevantarPala()
        {
            if(levantarpala == 0)
            {
                levantarpala = 1;
                return "La pala se levantó";
            }
            else
            {
                return "La pala ya está levantada";
            }
        }

        public string Bajarpala()
        {
            if(bajarpala == 0)
            {
                bajarpala = 1;
                return "La pala se bajó";
            }
            else
            {
                return "La pala ya está abajo";
            }
        }

        public string capacidad(int numero)
        {
            if(numero >= capacidadcarga)
            {
                return "Ha llegado a la capacidad maxima, no puede cargar más";
            }
            else
            {
                return $"Todavía puede cargar más, le quedan {capacidadcarga - numero} Quintales";
            }
        }
    }
}
