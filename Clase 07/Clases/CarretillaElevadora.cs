using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_07.Clases
{
    internal class CarretillaElevadora : Carro
    {
        public int subirbrazos;
        public int bajarbrazos;    
        public CarretillaElevadora(string _marca, int maxvel, string dueño, string color) : base(_marca, maxvel, dueño, color)
        {

        }

        public string SubirBrazos()
        {
            if(subirbrazos == 0)
            {
                subirbrazos = 1;
                return "Se ha elevado la carga";
            }
            else
            {
                subirbrazos = 0;
                return "La carga ya está elevada";
            }
        }

        public string BajarBrazos()
        {
            if(bajarbrazos == 0)
            {
                bajarbrazos = 1;
                return "Se han bajado los brazos";
            }
            else
            {
                bajarbrazos = 0;
                return "Los brazos ya están abajo";
            }
        }

        public string Carga(string palabra)
        {
            string mensaje = " ";
            if(palabra == "No")
            {
                mensaje = "Se ha cargado la carretilla";
            }
            else
            {
                mensaje = "La carretilla ya está con carga";
            }
            return mensaje; ;
        }
    }
}
