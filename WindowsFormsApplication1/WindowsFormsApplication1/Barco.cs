using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Barco
    {
        string marca = "";
        string color = "";
        string modelo = "";

        public void Flotar()
        {
            Console.WriteLine("El barco flota");
        }
        public void Girar()
        {
            Console.WriteLine("El barco gira");
        }
        public void Reversa()
        {
            Console.WriteLine("El barco va en reversa");
        }
        public void Velocidad()
        {
            Console.WriteLine("El barco aumento su velocidad");
        }
    }
}
