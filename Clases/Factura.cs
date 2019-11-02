using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractico2.Clases
{
    class Factura
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private DateTime fecha;

        public DateTime Fecha

        {
            get { return fecha; }
            set { fecha = value; }
        }

        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private ProductoPorFactura productoPorFactura;

        public ProductoPorFactura ProductoPorFactura
        {
            get { return productoPorFactura; }
            set { productoPorFactura = value; }
        }

        private int iva;

        public int IVA
        {
            get { return iva; }
            set { iva = value; }
        }

        private int subtotal;

        public int Subtoral
        {
            get { return subtotal; }
            set { subtotal = value; }
        }


    }
}
