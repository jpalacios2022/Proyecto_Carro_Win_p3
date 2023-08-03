using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Carro_Win_p3
{
    public partial class Win_Factura : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        
        public Win_Factura()
        {
            InitializeComponent();

        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                CarroSub ObjCarro = new CarroSub();

                ObjCarro.Nro_producto = textBox_NroProducto.Text;
                ObjCarro.Descripcion = textBox_Descripcion.Text;
                ObjCarro.Unidades_inventario = Int32.Parse(textBox_Unidades.Text);
                ObjCarro.Precio = double.Parse(textBox_Precio.Text);
                ObjCarro.Modelo = textBox_Modelo.Text;
                
                bindingSource1.Add(ObjCarro);
                dataGridView1.DataSource = bindingSource1;

                dataGridView1.Columns["Nro_producto"].DisplayIndex = 0;
                dataGridView1.Columns["Descripcion"].DisplayIndex = 1;
                dataGridView1.Columns["Modelo"].DisplayIndex = 2;
                dataGridView1.Columns["Unidades_Inventario"].DisplayIndex = 3;
                dataGridView1.Columns["Precio"].DisplayIndex = 4;
                dataGridView1.Columns["Valor"].DisplayIndex = 5;

                dataGridView1.Columns["Unidades_Inventario"].HeaderText = "Cantidad";
                dataGridView1.Columns["Valor"].HeaderText = "Subtotal";

                //dataGridView1.Columns["Modelo"].Visible = false;
                //dataGridView1.Columns["Valor"].Visible = false;

                dataGridView1.AutoSize = true;

                Limpiar_campos_items();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el campo de unidades/precio");
            }
           
        }

        public void Procesar_Items_Factura()
        {
            if (textBox_NroFactura.Text != "")
            {
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    Factura_Item ObjItem = new Factura_Item();

                    ObjItem.Nro_factura = textBox_NroFactura.Text;
                    ObjItem.Nro_producto = dataGridView1.Rows[row.Index].Cells[2].Value.ToString();
                    ObjItem.Unidades = Int32.Parse(dataGridView1.Rows[row.Index].Cells[4].Value.ToString());
                    ObjItem.Precio = Double.Parse(dataGridView1.Rows[row.Index].Cells[5].Value.ToString());

                    Lib_Metodos1.GuardarFacturaItem(ObjItem);
                    Lib_Metodos1.ActualizarInventario(ObjItem);
                }
            }
            else
            {
                MessageBox.Show("Numero de factura no debe ir en blanco.");

            }
        }

        public void Buscar_carro(String codCarro)
        {
            CarroSub ObjCarro = Lib_Metodos1.ObtenerCarro(codCarro);
            if (ObjCarro != null)
            {
                textBox_NroProducto.Text = ObjCarro.Nro_producto;
                textBox_Descripcion.Text = ObjCarro.Descripcion;
                textBox_Unidades.Text = "1";
                textBox_Precio.Text = ObjCarro.Precio.ToString();
                textBox_Modelo.Text = ObjCarro.Modelo;
            }
            else
            {
                Limpiar_campos_items();
            }
        }

        private void b_buscar_Click(object sender, EventArgs e)
        {
            Buscar_carro(textBox_NroProducto.Text);
        }

        private void Limpiar_campos_items()
        {
            textBox_NroProducto.Text = "";
            textBox_Descripcion.Text = "";
            textBox_Unidades.Text = "";
            textBox_Precio.Text = "";
            textBox_Modelo.Text = "";
        }

        private void b_procesar_Click(object sender, EventArgs e)
        {
            //Procesar_Factura_Encabezado();
            Procesar_Items_Factura();
            //Actualizar_Inventario();
            //Procesar_Transaccion();
        }


    }
}
