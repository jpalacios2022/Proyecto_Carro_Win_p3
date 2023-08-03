namespace Proyecto_Carro_Win_p3
{
    partial class WinMenu
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
            this.Button_Opcion4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Opcion4
            // 
            this.Button_Opcion4.Location = new System.Drawing.Point(94, 31);
            this.Button_Opcion4.Name = "Button_Opcion4";
            this.Button_Opcion4.Size = new System.Drawing.Size(186, 39);
            this.Button_Opcion4.TabIndex = 3;
            this.Button_Opcion4.Text = "1. Listar el inventario BD";
            this.Button_Opcion4.UseVisualStyleBackColor = true;
            this.Button_Opcion4.Click += new System.EventHandler(this.Button_Opcion4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "2. Vehiculos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "3. Facturas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WinMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 218);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button_Opcion4);
            this.Name = "WinMenu";
            this.Text = "WinMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Opcion4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

