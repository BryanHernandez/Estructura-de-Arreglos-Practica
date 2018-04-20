using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Estructura_de_Arreglos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Inventario inventario = new Inventario();
        Auto autoN;

        private void button1_Click(object sender, EventArgs e)//Agregar boton
        {
            autoN = new Auto();
            txtPosicion.Value = inventario.cantidad + 2;
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

        private void Borrar()
        {
            throw new NotImplementedException();
        }

        private void read()//nota cambia el leer por read cambio raro como apunte pregunta el profesor sobre este error
        {
            throw new NotImplementedException();
        }
    
        private void button4_Click(object sender, EventArgs e)//Insertar
        {
            autoN = new Auto();
            inventario.posicion = Convert.ToInt16(txtPosicion.Value) - 1;
            leer();
            inventario.Insertar(autoN);
            Borrar();
        }

        private void leer()
        {
            throw new NotImplementedException();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            inventario.posicion = Convert.ToInt16(txtPosicion.Value) - 1;
            inventario.Eliminar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string placa = txtPlacas.Text;
            inventario.Buscar(placa);
            txtList.Text = inventario.ToString();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            inventario.Lista();
            txtList.Text = inventario.ToString();
            txtPosicion.Value = inventario.cantidad + 1;
        }
    }
}
