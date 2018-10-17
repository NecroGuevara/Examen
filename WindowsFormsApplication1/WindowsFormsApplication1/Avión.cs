using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Avión
    {
        string marca = "";
        string color = "";
        string modelo = "";

        public void Encender()
        {
            Console.WriteLine("Voy a encender el motor");
        }
        public void Planear()
        {
            Console.WriteLine("Voy a planear");
        }
        public void Frenar()
        {
            Console.WriteLine("Voy a frenar");
        }
        public void Apagar()
        {
            Console.WriteLine("Voy a apagar los motores");
        }
    }
}
