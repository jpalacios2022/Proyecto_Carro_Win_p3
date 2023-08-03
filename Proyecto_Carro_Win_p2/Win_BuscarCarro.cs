using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Carro_Win_p3
{
    public partial class Win_BuscarCarro : Form
    {
        public Win_BuscarCarro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar_carro(textBox1.Text);
        }

        public void Buscar_carro(String codCarro)
        {
            CarroSub ObjCarro = Lib_Metodos1.ObtenerCarro(codCarro);
            if (ObjCarro != null)
            {
                Mostrar_registro(ObjCarro);
            }
        }

        public void Mostrar_registro(CarroSub ObjCarro)
        {
            textBox1.Text = "";
            textBox2.Text = ObjCarro.Nro_producto;
            textBox3.Text = ObjCarro.Descripcion;
            textBox4.Text = ObjCarro.Precio.ToString();
            textBox7.Text = ObjCarro.Unidades_inventario.ToString();
            textBox5.Text = ObjCarro.Modelo;
            textBox6.Text = ObjCarro.Valor.ToString();
        }

        private void b_primero_Click(object sender, EventArgs e)
        {
            CarroSub ObjCarro = Lib_Metodos1.ObtenerCarro_primero();
            if (ObjCarro != null)
            {
                Mostrar_registro(ObjCarro);
            }
        }

        private void b_ultimo_Click(object sender, EventArgs e)
        {
            CarroSub ObjCarro = Lib_Metodos1.ObtenerCarro_ultimo();
            if (ObjCarro != null)
            {
                Mostrar_registro(ObjCarro);
            }
        }

        private void b_proximo_Click(object sender, EventArgs e)
        {
            CarroSub ObjCarro = Lib_Metodos1.ObtenerCarro_proximo(textBox2.Text);
            if (ObjCarro != null)
            {
                Mostrar_registro(ObjCarro);
            }
        }

        private void b_anterior_Click(object sender, EventArgs e)
        {
            CarroSub ObjCarro = Lib_Metodos1.ObtenerCarro_anterior(textBox2.Text);
            if (ObjCarro != null)
            {
                Mostrar_registro(ObjCarro);
            }
        }

        private void b_limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void b_guardar_Click(object sender, EventArgs e)
        {
            CarroSub ObjCarro = new CarroSub();

            if (textBox2.Text.Length != 0 && textBox3.Text.Length != 0  && textBox4.Text.Length != 0 && textBox5.Text.Length != 0 && textBox7.Text.Length != 0)
            {
                ObjCarro.Nro_producto = textBox2.Text;
                ObjCarro.Descripcion = textBox3.Text;
                ObjCarro.Precio = Double.Parse(textBox4.Text);
                ObjCarro.Unidades_inventario = Int32.Parse(textBox7.Text);
                ObjCarro.Modelo = textBox5.Text;

                Lib_Metodos1.GuardarCarro(ObjCarro);
            }
            else
            {
                MessageBox.Show("No se puede grabar ese registro. Campos nulos no son permitidos.");
            }
            
        }

        private void b_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea eliminar este registro?", "Eliminar Carro", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Lib_Metodos1.EliminarCarro(textBox2.Text);

                b_limpiar.PerformClick();
            }
            
        }

        private void Win_BuscarCarro_Load(object sender, EventArgs e)
        {

        }

   

    }
}
