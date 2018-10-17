using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Carro
    {
        string marca = "";
        string color = "";
        string modelo = "";

        public void Rodar()
        {
            Console.WriteLine("El carro avanza");
        }
        public void Girar()
        {
            Console.WriteLine("El carro gira a la derecha");
        }
        public void Frenar()
        {
            Console.WriteLine("El carro frena");
        }
        public void Velocidad()
        {
            Console.WriteLine("El carro aumenta la velocidad");
        }
    }
}
