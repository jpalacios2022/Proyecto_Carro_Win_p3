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
    public partial class Win_Listar_inventario : Form
    {
        //CarroSub[] Arreglo_Carro;
        ArrayList Coleccion_Carro;
        
        public Win_Listar_inventario()
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
            //Arreglo_Carro = new CarroSub[sdata.GetLength(0)];
            //Lib_Metodos1.CargarDatos(Arreglo_Carro, sdata);

            // Creando una coleccion con el numero necesario de elementos
            Coleccion_Carro = new ArrayList();
            Lib_Metodos1.CargarDatos(Coleccion_Carro, sdata);


            //Conectando el arreglo de datos con el dataGridView.
            //dataGridView1.DataSource = Arreglo_Carro;

            //Conectando la coleccion de datos con el dataGridView.
            dataGridView1.DataSource = Coleccion_Carro;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

   


  
    }
}
