using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programaArchivo1
{
    public partial class Form1 : Form
    {
        string nombredearchivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            StreamWriter fichero;
            string frase1 = txtWrite1.Text;
            string frase2 = txtWrite2.Text;
            string frase3 = txtWrite3.Text;

            fichero = File.CreateText("FicheroFinal.txt");
            //fichero = File.CreateText(nombredearchivo);
            fichero.WriteLine(frase1);
            fichero.WriteLine(frase2);
            fichero.WriteLine(frase3);
            //fichero = File.CreateText("Fichero1.txt");
            fichero.Close();





        }

       
    }
}
