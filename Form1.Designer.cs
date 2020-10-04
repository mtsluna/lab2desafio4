using System.Windows.Forms;

namespace desafio4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numeroPiso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cantVentas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.basePrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupStatus = new System.Windows.Forms.GroupBox();
            this.usado = new System.Windows.Forms.RadioButton();
            this.nuevo = new System.Windows.Forms.RadioButton();
            this.type = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.piso = new System.Windows.Forms.RadioButton();
            this.calcular = new System.Windows.Forms.Button();
            this.groupStatus.SuspendLayout();
            this.type.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "COTIZADOR DE INMUEBLES";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 2);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Que tipo de inmuebles desea tasar?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(16, 77);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(259, 22);
            this.direccion.TabIndex = 5;
            this.direccion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingrese la dirección:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ingrese la cantidad de m2:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(16, 134);
            this.m.Name = "m";
            this.m.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m.Size = new System.Drawing.Size(259, 22);
            this.m.TabIndex = 8;
            this.m.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.m.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressIsNumber);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ingrese el número de piso:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // numeroPiso
            // 
            this.numeroPiso.Location = new System.Drawing.Point(16, 319);
            this.numeroPiso.Name = "numeroPiso";
            this.numeroPiso.Size = new System.Drawing.Size(259, 22);
            this.numeroPiso.TabIndex = 10;
            this.numeroPiso.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.numeroPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressIsNumber);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ingrese el número de ventanas:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cantVentas
            // 
            this.cantVentas.Enabled = false;
            this.cantVentas.Location = new System.Drawing.Point(16, 374);
            this.cantVentas.Name = "cantVentas";
            this.cantVentas.Size = new System.Drawing.Size(259, 22);
            this.cantVentas.TabIndex = 12;
            this.cantVentas.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.cantVentas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressIsNumber);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ingrese el estado del inmueble:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Precio base:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // basePrice
            // 
            this.basePrice.Location = new System.Drawing.Point(16, 450);
            this.basePrice.Name = "basePrice";
            this.basePrice.Size = new System.Drawing.Size(259, 22);
            this.basePrice.TabIndex = 18;
            this.basePrice.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.basePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressIsNumber);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 529);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Precio calculado:";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(16, 549);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(259, 22);
            this.price.TabIndex = 20;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressIsNumber);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(16, 417);
            this.label9.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 2);
            this.label9.TabIndex = 21;
            // 
            // groupStatus
            // 
            this.groupStatus.Controls.Add(this.usado);
            this.groupStatus.Controls.Add(this.nuevo);
            this.groupStatus.Location = new System.Drawing.Point(16, 184);
            this.groupStatus.Name = "groupStatus";
            this.groupStatus.Size = new System.Drawing.Size(259, 39);
            this.groupStatus.TabIndex = 22;
            this.groupStatus.TabStop = false;
            // 
            // usado
            // 
            this.usado.AutoSize = true;
            this.usado.Location = new System.Drawing.Point(144, 12);
            this.usado.Name = "usado";
            this.usado.Size = new System.Drawing.Size(70, 21);
            this.usado.TabIndex = 1;
            this.usado.Text = "Usado";
            this.usado.UseVisualStyleBackColor = true;
            // 
            // nuevo
            // 
            this.nuevo.AutoSize = true;
            this.nuevo.Checked = true;
            this.nuevo.Location = new System.Drawing.Point(7, 12);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(140, 21);
            this.nuevo.TabIndex = 0;
            this.nuevo.TabStop = true;
            this.nuevo.Text = "Nuevo (-15 años)";
            this.nuevo.UseVisualStyleBackColor = true;
            // 
            // type
            // 
            this.type.Controls.Add(this.radioButton2);
            this.type.Controls.Add(this.piso);
            this.type.Location = new System.Drawing.Point(16, 247);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(259, 39);
            this.type.TabIndex = 23;
            this.type.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(70, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Local Comercial";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // piso
            // 
            this.piso.AutoSize = true;
            this.piso.Checked = true;
            this.piso.Location = new System.Drawing.Point(7, 12);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(56, 21);
            this.piso.TabIndex = 0;
            this.piso.TabStop = true;
            this.piso.Text = "Piso";
            this.piso.UseVisualStyleBackColor = true;
            this.piso.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            this.piso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressIsNumber);
            // 
            // calcular
            // 
            this.calcular.Enabled = false;
            this.calcular.Location = new System.Drawing.Point(16, 490);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(261, 23);
            this.calcular.TabIndex = 24;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 588);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.basePrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cantVentas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numeroPiso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.m);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupStatus);
            this.Controls.Add(this.type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cotizador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupStatus.ResumeLayout(false);
            this.groupStatus.PerformLayout();
            this.type.ResumeLayout(false);
            this.type.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox direccion;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox m;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox numeroPiso;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox cantVentas;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox basePrice;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox price;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.GroupBox groupStatus;
        public System.Windows.Forms.RadioButton usado;
        public System.Windows.Forms.RadioButton nuevo;
        public System.Windows.Forms.GroupBox type;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton piso;
        private System.Windows.Forms.Button calcular;
    }
}

