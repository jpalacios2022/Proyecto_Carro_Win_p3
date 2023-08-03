using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Carro_Win_p3
{
    class Factura_Item
    {
        private String nro_factura;

        public String Nro_factura
        {
            get { return nro_factura; }
            set { nro_factura = value; }
        }
        private String nro_producto;

        public String Nro_producto
        {
            get { return nro_producto; }
            set { nro_producto = value; }
        }
        private int unidades;

        public int Unidades
        {
            get { return unidades; }
            set { unidades = value; }
        }
        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

    }
}
