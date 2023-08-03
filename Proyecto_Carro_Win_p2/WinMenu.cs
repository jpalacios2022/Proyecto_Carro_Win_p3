using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Carro_Win_p3
{
    public partial class WinMenu : Form
    {
        CarroSub[] Arreglo_Carro;

        public WinMenu()
        {
            InitializeComponent();

        }

  
        private void Button_Opcion2_Click(object sender, EventArgs e)
        {
            if (Arreglo_Carro[0] != null)
            {
                MessageBox.Show("Total inventario: " + Lib_Metodos1.TotalInventario(Arreglo_Carro).ToString());
            }
            else
            {
                MessageBox.Show("Se debe usar la opcion 0 primero.");
            }
            
        }


        private void Button_Opcion4_Click(object sender, EventArgs e)
        {
            Win_Listar_inventario_db f1 = new Win_Listar_inventario_db();
            f1.Show();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Win_BuscarCarro f2 = new Win_BuscarCarro();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Win_Factura f3 = new Win_Factura();
            f3.Show();
        }
    }
}
