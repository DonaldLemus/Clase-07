using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_07.Clases
{
    internal class Carro
    {
        public string Marca { get; }

        public int Modelo { get; }

        public string owner { get; set; }

        public string Color { get; set; }

        private int Encendido = 0;
        private int velocidad_actual = 0;
        public int MAXVELOCIDAD { get; }

        //CONSTRUCTOR
        public Carro(string _marca, int maxvel, string dueño, string color)
        {
            Marca = _marca;
            MAXVELOCIDAD = maxvel;
            owner = dueño;
            Color = color;
        }

        public string acelerar()
        {
            string mensaje = " ";
            if (Encendido == 0)
            {
                return  $"El carro esta apagado, asi no se puede";
            }

            if (velocidad_actual < MAXVELOCIDAD)
            {
                velocidad_actual += 10;
                mensaje = $"Ha acelerado 10, esta es la velocidad {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje =  $"Vas a maxima velocidad que es {MAXVELOCIDAD} KPH";
            }
            return mensaje;
        }

        public string acelerar(int AcekerarAkph)
        {
            if (Encendido == 0)
            {
                return $"El carro esta apagado, asi no se puede";
            }
            string mensaje = "";
            if (velocidad_actual < MAXVELOCIDAD)
            {
                velocidad_actual += AcekerarAkph;
                mensaje = $"Ha acelerado {AcekerarAkph}, esta es la velocidad {velocidad_actual} KPH";

            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"Vas a maxima velocidad que es {MAXVELOCIDAD} KPH";
            }
            return mensaje;

        }

        public string EncenderMotor()
        {
            if (Encendido == 0)
            {
                Encendido = 1;
                velocidad_actual = 0;
                return "Se ha encendido el motor";

            }
            else
            {
                return "El motor ya está encendido";
            }
        }

        public string DameInformacion()
        {
            return $"Soy un vehiculo tipo {Marca}, color {Color} y mi dueño es {owner}";
        }
    }
}
