using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bicicleta bicicleta = new Bicicleta();
            bicicleta.Rodar();
            bicicleta.Girar();
            bicicleta.Frenar();
        }

        
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
