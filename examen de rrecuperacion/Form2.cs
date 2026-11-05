using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_de_rrecuperacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte nota1 = byte.Parse(textnota1.Text);
            byte nota2 = byte.Parse(textnota2.Text);
            byte nota3 = byte.Parse(textnota3.Text);
            float promedio = ((nota1 + nota2 + nota3) / 3);
            MessageBox.Show(" el resultado es" + promedio);



        }
    }
}
