using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_de_Arreglos
{
    class Inventario
    {
        int _Cantidad;
        int _Posicion;
        string Datos = "";
        public int posicion { get { return _Posicion; } set { _Posicion = value; } }

        Auto[] lisAuto = new Auto[15];
        public int cantidad { get { return _Cantidad; } }
        public Inventario()

        {
            _Cantidad = 0;
            _Posicion = 0;
        }

        public void Agregar(Auto Car)
        {
            if (_Cantidad < 14)

            {
                lisAuto[_Cantidad] = Car;
                _Cantidad++;
            }
            else
            {
                lisAuto[_Cantidad] = Car;
            }
        }
       
        private void Mover()
        {
            for (int a = _Cantidad; a > _Posicion; a--)
            {
                lisAuto[a] = lisAuto[a - 1];
            }
        }
        public void Eliminar()

        {
            if (lisAuto[_Posicion] != null)
            {
                lisAuto[_Posicion] = null;
                MoverBorrar();
                _Cantidad--;
            }

        }
        private void MoverBorrar()
        {
            for (int a = _Posicion; a < _Cantidad; a++)

            {
                lisAuto[a] = lisAuto[a + 1];
            }
        }
        public void Lista()
        {
            Datos = "";
            for (int a = 0; a <= (_Cantidad - 1); a++)
            {
                Datos += (a + 1) + "._\t" + lisAuto[a].ToString() + Environment.NewLine;
            }
        }
        public void Buscar(string placa)
        {
            bool existe = false;
            Datos = "";
            int a = 0;
            while (existe == false && a <= _Cantidad)
            {
                if (lisAuto[a].placa == placa)
                {
                    Datos = (a + 1) + "._\t" + lisAuto[a].ToString();
                    MessageBox.Show("Carro encontrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    a = _Cantidad;
                    existe = true;
                }
                a++;
            }
        }
        public override string ToString()
        {
            return Datos;
       }
    }
}

/*Metodo burbuja
for (c = 0 ; c<(n - 1 ); c++)
  {
    for (d = 0 ; d<n - c - 1; d++)
    {
      if (array[d] > array[d + 1]) /* For decreasing order use < 
      {
        swap       = array[d];
        array[d]   = array[d + 1];
        array[d + 1] = swap;
      }
    }
  }

    */

