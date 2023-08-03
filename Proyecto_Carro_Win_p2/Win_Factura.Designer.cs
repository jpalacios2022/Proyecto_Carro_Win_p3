namespace Proyecto_Carro_Win_p3
{
    partial class Win_Factura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_NroProducto = new System.Windows.Forms.TextBox();
            this.textBox_Unidades = new System.Windows.Forms.TextBox();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.b_agregar = new System.Windows.Forms.Button();
            this.textBox_NroFactura = new System.Windows.Forms.TextBox();
            this.b_buscar = new System.Windows.Forms.Button();
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Modelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.b_procesar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(674, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox_NroProducto
            // 
            this.textBox_NroProducto.Location = new System.Drawing.Point(108, 80);
            this.textBox_NroProducto.Name = "textBox_NroProducto";
            this.textBox_NroProducto.Size = new System.Drawing.Size(79, 20);
            this.textBox_NroProducto.TabIndex = 3;
            // 
            // textBox_Unidades
            // 
            this.textBox_Unidades.Location = new System.Drawing.Point(464, 80);
            this.textBox_Unidades.Name = "textBox_Unidades";
            this.textBox_Unidades.Size = new System.Drawing.Size(52, 20);
            this.textBox_Unidades.TabIndex = 6;
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.Location = new System.Drawing.Point(522, 80);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(100, 20);
            this.textBox_Precio.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(105, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nro_producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(461, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unidades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(519, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio";
            // 
            // b_agregar
            // 
            this.b_agregar.Location = new System.Drawing.Point(628, 79);
            this.b_agregar.Name = "b_agregar";
            this.b_agregar.Size = new System.Drawing.Size(70, 23);
            this.b_agregar.TabIndex = 7;
            this.b_agregar.Text = "Agregar";
            this.b_agregar.UseVisualStyleBackColor = true;
            this.b_agregar.Click += new System.EventHandler(this.b_agregar_Click);
            // 
            // textBox_NroFactura
            // 
            this.textBox_NroFactura.Location = new System.Drawing.Point(47, 28);
            this.textBox_NroFactura.Name = "textBox_NroFactura";
            this.textBox_NroFactura.Size = new System.Drawing.Size(100, 20);
            this.textBox_NroFactura.TabIndex = 1;
            // 
            // b_buscar
            // 
            this.b_buscar.Location = new System.Drawing.Point(24, 79);
            this.b_buscar.Name = "b_buscar";
            this.b_buscar.Size = new System.Drawing.Size(75, 23);
            this.b_buscar.TabIndex = 2;
            this.b_buscar.Text = "Buscar:";
            this.b_buscar.UseVisualStyleBackColor = true;
            this.b_buscar.Click += new System.EventHandler(this.b_buscar_Click);
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.Location = new System.Drawing.Point(193, 80);
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            this.textBox_Descripcion.Size = new System.Drawing.Size(129, 20);
            this.textBox_Descripcion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(190, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(47, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nro_Factura";
            // 
            // textBox_Modelo
            // 
            this.textBox_Modelo.Location = new System.Drawing.Point(328, 80);
            this.textBox_Modelo.Name = "textBox_Modelo";
            this.textBox_Modelo.Size = new System.Drawing.Size(130, 20);
            this.textBox_Modelo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(325, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Modelo";
            // 
            // b_procesar
            // 
            this.b_procesar.Location = new System.Drawing.Point(294, 281);
            this.b_procesar.Name = "b_procesar";
            this.b_procesar.Size = new System.Drawing.Size(126, 24);
            this.b_procesar.TabIndex = 17;
            this.b_procesar.Text = "Procesar";
            this.b_procesar.UseVisualStyleBackColor = true;
            this.b_procesar.Click += new System.EventHandler(this.b_procesar_Click);
            // 
            // Win_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 318);
            this.Controls.Add(this.b_procesar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Modelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Descripcion);
            this.Controls.Add(this.b_buscar);
            this.Controls.Add(this.textBox_NroFactura);
            this.Controls.Add(this.b_agregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Precio);
            this.Controls.Add(this.textBox_Unidades);
            this.Controls.Add(this.textBox_NroProducto);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Win_Factura";
            this.Text = "Win_Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_NroProducto;
        private System.Windows.Forms.TextBox textBox_Unidades;
        private System.Windows.Forms.TextBox textBox_Precio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_agregar;
        private System.Windows.Forms.TextBox textBox_NroFactura;
        private System.Windows.Forms.Button b_buscar;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Modelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_procesar;
    }
}