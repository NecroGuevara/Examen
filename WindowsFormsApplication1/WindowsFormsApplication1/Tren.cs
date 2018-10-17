using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Tren
    {
        string nombre = "";
        string color = "";
        int tamaño = 0;

        public void Avanzar()
        {
            Console.WriteLine("El tren Avanza");
        }
        public void Reverza()
        {
            Console.WriteLine("El tren va de reverza");
        }
        public void Frenar()
        {
            Console.WriteLine("El tren frena");
        }
        public void Velocidad()
        {
            Console.WriteLine("El tren aumenta de velocidad");
        }
    }
}
