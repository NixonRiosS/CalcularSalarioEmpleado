namespace EjercicioConCondicionales2
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
            this.txt_horast = new System.Windows.Forms.TextBox();
            this.txt_valorh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_resumenpago = new System.Windows.Forms.GroupBox();
            this.lbl_salariof = new System.Windows.Forms.Label();
            this.lbl_incremento = new System.Windows.Forms.Label();
            this.lbl_descuentosalud = new System.Windows.Forms.Label();
            this.lbl_salariob = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.cmb_empleadoadmin = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gb_resumenpago.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo de Salario Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese las horas trabajadas por el empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese el valor de la hora trabajada:";
            // 
            // txt_horast
            // 
            this.txt_horast.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_horast.Location = new System.Drawing.Point(450, 89);
            this.txt_horast.Name = "txt_horast";
            this.txt_horast.Size = new System.Drawing.Size(122, 35);
            this.txt_horast.TabIndex = 3;
            // 
            // txt_valorh
            // 
            this.txt_valorh.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorh.Location = new System.Drawing.Point(450, 146);
            this.txt_valorh.Name = "txt_valorh";
            this.txt_valorh.Size = new System.Drawing.Size(168, 35);
            this.txt_valorh.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(512, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gb_resumenpago
            // 
            this.gb_resumenpago.Controls.Add(this.lbl_salariof);
            this.gb_resumenpago.Controls.Add(this.lbl_incremento);
            this.gb_resumenpago.Controls.Add(this.lbl_descuentosalud);
            this.gb_resumenpago.Controls.Add(this.lbl_salariob);
            this.gb_resumenpago.Controls.Add(this.label7);
            this.gb_resumenpago.Controls.Add(this.label4);
            this.gb_resumenpago.Controls.Add(this.label6);
            this.gb_resumenpago.Controls.Add(this.label5);
            this.gb_resumenpago.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_resumenpago.Location = new System.Drawing.Point(26, 310);
            this.gb_resumenpago.Name = "gb_resumenpago";
            this.gb_resumenpago.Size = new System.Drawing.Size(753, 137);
            this.gb_resumenpago.TabIndex = 6;
            this.gb_resumenpago.TabStop = false;
            this.gb_resumenpago.Text = "Resumen de Pago:";
            this.gb_resumenpago.Visible = false;
            // 
            // lbl_salariof
            // 
            this.lbl_salariof.AutoSize = true;
            this.lbl_salariof.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salariof.Location = new System.Drawing.Point(414, 27);
            this.lbl_salariof.Name = "lbl_salariof";
            this.lbl_salariof.Size = new System.Drawing.Size(85, 28);
            this.lbl_salariof.TabIndex = 14;
            this.lbl_salariof.Text = "label11";
            // 
            // lbl_incremento
            // 
            this.lbl_incremento.AutoSize = true;
            this.lbl_incremento.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_incremento.Location = new System.Drawing.Point(125, 103);
            this.lbl_incremento.Name = "lbl_incremento";
            this.lbl_incremento.Size = new System.Drawing.Size(85, 28);
            this.lbl_incremento.TabIndex = 13;
            this.lbl_incremento.Text = "label10";
            // 
            // lbl_descuentosalud
            // 
            this.lbl_descuentosalud.AutoSize = true;
            this.lbl_descuentosalud.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descuentosalud.Location = new System.Drawing.Point(162, 67);
            this.lbl_descuentosalud.Name = "lbl_descuentosalud";
            this.lbl_descuentosalud.Size = new System.Drawing.Size(73, 28);
            this.lbl_descuentosalud.TabIndex = 12;
            this.lbl_descuentosalud.Text = "label9";
            // 
            // lbl_salariob
            // 
            this.lbl_salariob.AutoSize = true;
            this.lbl_salariob.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salariob.Location = new System.Drawing.Point(125, 27);
            this.lbl_salariob.Name = "lbl_salariob";
            this.lbl_salariob.Size = new System.Drawing.Size(73, 28);
            this.lbl_salariob.TabIndex = 11;
            this.lbl_salariob.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(294, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Salario Final:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salario Base:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Incremento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descuento Salud:";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(659, 206);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(106, 55);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // cmb_empleadoadmin
            // 
            this.cmb_empleadoadmin.FormattingEnabled = true;
            this.cmb_empleadoadmin.Items.AddRange(new object[] {
            "No",
            "Si"});
            this.cmb_empleadoadmin.Location = new System.Drawing.Point(26, 229);
            this.cmb_empleadoadmin.Name = "cmb_empleadoadmin";
            this.cmb_empleadoadmin.Size = new System.Drawing.Size(122, 21);
            this.cmb_empleadoadmin.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Empleado Administrativo?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_empleadoadmin);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.gb_resumenpago);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_valorh);
            this.Controls.Add(this.txt_horast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora de Salario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_resumenpago.ResumeLayout(false);
            this.gb_resumenpago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_horast;
        private System.Windows.Forms.TextBox txt_valorh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gb_resumenpago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_salariof;
        private System.Windows.Forms.Label lbl_incremento;
        private System.Windows.Forms.Label lbl_descuentosalud;
        private System.Windows.Forms.Label lbl_salariob;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.ComboBox cmb_empleadoadmin;
        private System.Windows.Forms.Label label8;
    }
}

