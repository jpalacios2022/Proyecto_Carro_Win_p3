using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Carro_Win_p3
{
    public class CarroSub : Carro
    {
        private String modelo;

        public CarroSub() { }

        public CarroSub(String Nro_producto, String Descripcion, int Unidades_inventario, double Precio, String Modelo)
        {
            this.Nro_producto = Nro_producto;
            this.Descripcion = Descripcion;
            this.Unidades_inventario = Unidades_inventario;
            this.Precio = Precio;
            this.Modelo = Modelo;
        }

        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public new double Valor
        {
            get { return (base.Precio * base.Unidades_inventario) + (base.Precio * base.Unidades_inventario * 0.05); }
        }

        public double GastoInventario()
        {
            return (base.Precio * base.Unidades_inventario * 0.05);
        }

        public override void ListarCarro()
        {
            Console.WriteLine("Nro Producto: " + base.Nro_producto);
            Console.WriteLine("Descripcion: " + base.Descripcion);
            Console.WriteLine("Unidades en inventario: " + base.Unidades_inventario);
            Console.WriteLine("Precio: " + base.Precio);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Valor: " + base.Valor);
            Console.WriteLine("Gasto inventario: " + GastoInventario());
            Console.WriteLine();
        }

    }
}
