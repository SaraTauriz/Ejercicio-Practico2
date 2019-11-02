using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractico2.Clases
{
    class Producto
    {

        private string codigo;

        public  string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private float precioVenta;

        public float PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }

    }
}
