using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Carro_Win_p3
{
    public partial class Win_Listar_inventario_db : Form
    {
        DataTable dt;
        
        public Win_Listar_inventario_db()
        {
            InitializeComponent();

            dt = Lib_Metodos1.Retorna_tabla();
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                String codLista = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                Win_BuscarCarro f1 = new Win_BuscarCarro();
                f1.Buscar_carro(codLista);
                f1.Show();
            }
        }

        




    }
}
