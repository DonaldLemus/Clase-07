using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_07.Clases
{
    internal class Moto : Carro
    {
        public int frenoadelante;
        public int frenoatras;
        public int parrila;
        public int caballito;
        public Moto(string _marca, int maxvel, string dueño, string color) : base(_marca, maxvel, dueño, color)
        {

        }

        public string frenoAdelante()
        {
            if(frenoadelante == 0)
            {
                frenoadelante = 1;
                return "Ha frenado con el freno delantero";
            }
            else
            {
                frenoadelante = 0;
                return "El freno delantero ya está en uso";
            }  
        }
        public string frenoAtras()
        {
            if(frenoatras == 0)
            {
                frenoatras = 1;
                
                return "Ha freando con el freno trasero";
            }
            else
            {
                frenoatras = 0;
                return "El freno trasero ya está en uso";
            }   
        }

        public string Parrila()
        {
            if(parrila == 0)
            {
                parrila = 1;
                return "Parilla vacía";
            }
            else
            {
                return "Parria ocupada";
            }
        }
        public string Caballito()
        {
            if(caballito == 0)
            {
                caballito = 1;
                return "Esás haciendo un caballito brbrbr";
            }
            else
            {
                caballito= 0;
                return "Ya estabas haciendo un caballito, te acabas de partir la cabeza";
            }
        }
    }
}
