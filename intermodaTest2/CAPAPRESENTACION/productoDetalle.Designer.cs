namespace intermodaTest2.CAPAPRESENTACION
{
    partial class productoDetalle
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
            this.checkboxEstado = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cUnidadMedida = new System.Windows.Forms.ComboBox();
            this.cTipo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkboxEstado
            // 
            this.checkboxEstado.AutoSize = true;
            this.checkboxEstado.Location = new System.Drawing.Point(71, 148);
            this.checkboxEstado.Name = "checkboxEstado";
            this.checkboxEstado.Size = new System.Drawing.Size(61, 19);
            this.checkboxEstado.TabIndex = 24;
            this.checkboxEstado.Text = "Estado";
            this.checkboxEstado.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "Guardar";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(86, 51);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(121, 23);
            this.tNombre.TabIndex = 22;
            // 
            // tCodigo
            // 
            this.tCodigo.Location = new System.Drawing.Point(86, 22);
            this.tCodigo.Name = "tCodigo";
            this.tCodigo.Size = new System.Drawing.Size(121, 23);
            this.tCodigo.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Medida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tipo:";
            // 
            // cUnidadMedida
            // 
            this.cUnidadMedida.FormattingEnabled = true;
            this.cUnidadMedida.Location = new System.Drawing.Point(86, 112);
            this.cUnidadMedida.Name = "cUnidadMedida";
            this.cUnidadMedida.Size = new System.Drawing.Size(121, 23);
            this.cUnidadMedida.TabIndex = 16;
            // 
            // cTipo
            // 
            this.cTipo.FormattingEnabled = true;
            this.cTipo.Location = new System.Drawing.Point(86, 83);
            this.cTipo.Name = "cTipo";
            this.cTipo.Size = new System.Drawing.Size(121, 23);
            this.cTipo.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // productoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 237);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkboxEstado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.tCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cUnidadMedida);
            this.Controls.Add(this.cTipo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "productoDetalle";
            this.Text = "productoDetalle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.productoDetalle_FormClosed_1);
            this.Load += new System.EventHandler(this.productoDetalle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public CheckBox checkboxEstado;
        public TextBox tNombre;
        public TextBox tCodigo;
        public ComboBox cUnidadMedida;
        public ComboBox cTipo;
        private Button button2;
    }
}