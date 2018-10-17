using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Bicicleta
    {
        string marca = "";
        string color = "";
        string modelo = "";

        public void Rodar()
        {
            Console.WriteLine("Voy a empezar a rodar");
        }
        public void Girar()
        {
            Console.WriteLine("Voy a Girar");
        }
        public void Frenar()
        {
            Console.WriteLine("Voy a frenar");
        }
        public void Velocidad()
        {
            Console.WriteLine("Voy a cambiar de velocidad");
        }
    }
}
