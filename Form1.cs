using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_2_unidad_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //'Declaracion de variables de cantidad
        int CantidadHamburguesas;
        int cantidadHotDog;
        int cantidadSandwich;
        int cantidadTe;
        int cantidadRefresco;
        int cantidadPapas;

        double TotalVta;
        double costoHambuguesas;
        double costoHotDog;
        double costoSandwich;
        double costoTe;
        double costoRefresco;
        double costoPapas;

        //'Inicializar las variables con los precios de los productos

        double Hamburguesa = 20.5;
        double HotDog = 19.25;
        double Sandwich = 17.5;
        double PapasFritas = 4.5;
        double Refresco = 4;
        double Te = 5;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            //'Paquete No. 1 de comida
            textBox7.Text = "";
            if (radioButton1.Checked == true) ;
            {
                CantidadHamburguesas = 1;
                cantidadRefresco = 1;
                cantidadPapas = 1;
                cantidadHotDog = 0;
                cantidadSandwich = 0;
                cantidadTe = 0;
                //Inicializar valores
                textBox1.Text = CantidadHamburguesas.ToString();
                textBox6.Text = cantidadRefresco.ToString();
                textBox5.Text = cantidadPapas.ToString();
                //Activar las cajas de texto del paquete
                textBox1.Enabled = true;
                textBox6.Enabled = true;
                textBox5.Enabled = true;
                //Desactivar las otras cajas de texto
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                //Limpiar cajas de texto
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Paquete No.2 de comida
            textBox7.Text = "";
            if (radioButton2.Checked == true)
            {
                cantidadRefresco = 1;
                cantidadPapas = 1;
                cantidadHotDog = 1;
                cantidadTe = 0;
                cantidadSandwich = 0;
                CantidadHamburguesas = 0;
                //Inicializar valores
                textBox2.Text = cantidadHotDog.ToString();
                textBox6.Text = cantidadRefresco.ToString();
                textBox5.Text = cantidadPapas.ToString();
                //Activar las cajas de texto del paquete
                textBox2.Enabled = true;
                textBox6.Enabled = true;
                textBox5.Enabled = true;
                //Desactivar las otras cajas de texto
                textBox1.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                //Limpiar cajas de texto
                textBox1.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Text = "";
            if (radioButton3.Checked == true)
            {
                cantidadRefresco = 1;
                cantidadPapas = 1;
                cantidadHotDog = 0;
                cantidadTe = 0;
                cantidadSandwich = 1;
                CantidadHamburguesas = 0;
                //Inicializar valores
                textBox3.Text = cantidadSandwich.ToString();
                textBox6.Text = cantidadRefresco.ToString();
                textBox5.Text = cantidadPapas.ToString();
                //Activar las cajas de texto del paquete
                textBox3.Enabled = true;
                textBox6.Enabled = true;
                textBox5.Enabled = true;
                //Desactivar las otras cajas de texto
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox4.Enabled = false;
                //Limpiar cajas de texto
                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Text = "";
            if (radioButton4.Checked == true)
            {
                //Habilitar todas las entradas
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;

                textBox1.Text = CantidadHamburguesas.ToString();
                textBox2.Text = cantidadHotDog.ToString();
                textBox3.Text = cantidadSandwich.ToString();
                textBox4.Text = cantidadTe.ToString();
                textBox5.Text = cantidadPapas.ToString();
                textBox6.Text = cantidadRefresco.ToString();

                CantidadHamburguesas = 1;
                cantidadRefresco = 1;
                cantidadPapas = 1;
                cantidadHotDog = 1;
                cantidadSandwich = 1;
                cantidadTe = 1;

                // Limpiar cajas
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Multilicando la cantidad por el precio y sumando el total
            costoHambuguesas = (CantidadHamburguesas * Hamburguesa);
            costoHotDog = (cantidadHotDog * HotDog);
            costoSandwich = (cantidadSandwich * Sandwich);
            costoTe = (cantidadTe * Te);
            costoRefresco = (cantidadRefresco * Refresco);
            costoPapas = (cantidadPapas * PapasFritas);
            TotalVta = costoHambuguesas + costoHotDog + costoSandwich + costoTe + costoRefresco + costoPapas;
            textBox7.Text = TotalVta.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
    }
}
