using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractico2.Clases
{
    class ProductoPorFactura
    {
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private float precioVenta;

        public float PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }

        private Factura factura;

        public Factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }


    }
}
