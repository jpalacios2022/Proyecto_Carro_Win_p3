using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using System.Windows.Forms;

namespace Proyecto_Carro_Win_p3
{
    public partial class WinFormTestSQL : Form
    {
        DataTable dt;
        
        public WinFormTestSQL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = Lib_Metodos1.Retorna_tabla();
            dataGridView1.DataSource = dt;

        }
    }
}
