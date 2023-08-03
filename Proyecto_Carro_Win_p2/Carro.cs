using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Carro_Win_p3
{
    public class Carro
    {
        private String nro_producto;

        public String Nro_producto
        {
            get { return nro_producto; }
            set { nro_producto = value; }
        }

        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private int unidades_inventario;

        public int Unidades_inventario
        {
            get { return unidades_inventario; }
            set { unidades_inventario = value; }
        }

        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private double valor;

        public double Valor
        {
            get { return Precio * Unidades_inventario; }
        }

        public virtual void ListarCarro()
        {
            Console.WriteLine("Nro Producto: " + Nro_producto);
            Console.WriteLine("Descripcion: " + Descripcion);
            Console.WriteLine("Unidades en inventario: " + Unidades_inventario);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Valor: " + Valor);
            Console.WriteLine();
        }
    }
}
