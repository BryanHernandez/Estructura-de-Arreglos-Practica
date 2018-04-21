using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_de_Arreglos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Inventario inventario = new Inventario();
        Auto autoN;

        private void btnAgregar_Click(object sender, EventArgs e)

        {
            autoN = new Auto();
    
            if (inventario.cantidad < 15)
            {
                leer();
                inventario.Agregar(autoN);
                Borrar();
            }
            else
            {
                MessageBox.Show("LLeno", "Espacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void read()//nota cambia el leer por read cambio raro como apunte pregunta el profesor sobre este error
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //Lista
        {
            inventario.Lista();
            txtList.Text = inventario.ToString();

        }

        private void button2_Click(object sender, EventArgs e) //Buscar
        {
            string placa = txtPlacas.Text;
            inventario.Buscar(placa);
            txtList.Text = inventario.ToString();
        }
        private void Borrar()

        {
            txtModelo.Clear();
            txtFecha.Clear();
            txtPlacas.Clear();
            txtTelefono.Clear();
        }
        private void leer()
        {
            autoN.modelo = txtModelo.Text;
            autoN.fecha = txtFecha.Text;
            autoN.placa = txtPlacas.Text;
            autoN.telefono = txtTelefono.Text;


        }

        private void button4_Click(object sender, EventArgs e)//Insertar
        {
          /* autoN = new Auto();
            leer();
            inventario.Insertar(autoN);
            txtList.Text = inventario.ToString();*/
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            inventario.Eliminar();
            txtList.Text = inventario.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
