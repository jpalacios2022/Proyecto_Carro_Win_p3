using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Carro_Win_p3
{
    public partial class Win_Registro_inventario : Form
    {
        CarroSub[] Arreglo_Carro;
        int cursor = 0;

        public Win_Registro_inventario()
        {
            InitializeComponent();

            // Creando un arreglo con datos
            String[,] sdata = {
                               {"001", "KIA","5","400000.00","0", "Picanto"},
                               {"002", "Fiat", "3", "300000.00","0", "Uno"},
                               {"003", "Camaro","1","1000000.00","0", "Z28"},
                               {"004","Mercedez Benz", "1","1200000","0", "250S"},
                               {"005","Mustang","3","900000","0", "Modelo II"}
                              };

            // Creando un arreglo con el numero necesario de elementos
            Arreglo_Carro = new CarroSub[sdata.GetLength(0)];
            Lib_Metodos1.CargarDatos(Arreglo_Carro, sdata);

        }

        private void Mostrar_Registro_Ventana(int cursor)
        {
            textBox_NroProducto.Text = Arreglo_Carro[cursor].Nro_producto;
            textBox_Descripcion.Text = Arreglo_Carro[cursor].Descripcion;
            textBox_Precio.Text = Arreglo_Carro[cursor].Precio.ToString();
            textBox_Unidades.Text = Arreglo_Carro[cursor].Unidades_inventario.ToString();
            textBox_Modelo.Text = Arreglo_Carro[cursor].Modelo;
            textBox_Valor.Text = Arreglo_Carro[cursor].Valor.ToString();
        }

        private void Button_Primero_Click(object sender, EventArgs e)
        {
            cursor = Lib_Metodos1.Mostrar_Carro(Arreglo_Carro, 'p', cursor);
            Mostrar_Registro_Ventana(cursor);
            
        }

        private void Button_Proximo_Click(object sender, EventArgs e)
        {
            cursor = Lib_Metodos1.Mostrar_Carro(Arreglo_Carro, 'o', cursor);
            Mostrar_Registro_Ventana(cursor);
        }

        private void Button_Anterior_Click(object sender, EventArgs e)
        {
            cursor = Lib_Metodos1.Mostrar_Carro(Arreglo_Carro, 'a', cursor);
            Mostrar_Registro_Ventana(cursor);
        }

        private void Button_Ultimo_Click(object sender, EventArgs e)
        {
            cursor = Lib_Metodos1.Mostrar_Carro(Arreglo_Carro, 'u', cursor);
            Mostrar_Registro_Ventana(cursor);
        }
    }
}
