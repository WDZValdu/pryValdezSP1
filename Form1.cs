using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace pryValdezSP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearArc_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter swCrearArchivo = new StreamWriter("Mi Archivo", false);
                MessageBox.Show("Archivo creado");
            }
            catch (Exception)
            {
                MessageBox.Show("Fatal Error");
                throw;
            }
            
        }

        private void btnGrabarArc_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter swManejoArchivo = new StreamWriter("Mi Archivo", true);
                swManejoArchivo.WriteLine(txtDatos.Text);
                swManejoArchivo.Close();

                
                MessageBox.Show("Archivo Grabado");

                txtDatos.Text = "";
                txtDatos.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Fatal Error");
                throw;
            }
           
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            /*StreamReader srManejoArchivo = new StreamReader("Mi Archivo", true);

            while (srManejoArchivo.EndOfStream == false)
            {
                txtDatos.Text = srManejoArchivo.ReadLine() + Environment.NewLine;


            }
            srManejoArchivo.Close();
            srManejoArchivo.Dispose();*/
            
            try
            {
                using (StreamReader srManejoArchivo = new StreamReader("Mi Archivo"))
                {
                    string contenido = ""; // Variable para acumular el contenido del archivo

                    while (srManejoArchivo.EndOfStream == false)
                    {
                        contenido += srManejoArchivo.ReadLine() + Environment.NewLine;
                    }

                    txtDatos.Text = contenido; // Mostrar todas las líneas en el cuadro de texto
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fatal Error");
                throw;
            }


        }
    }
}
