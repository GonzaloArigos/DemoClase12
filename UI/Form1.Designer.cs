namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnCrear = new Button();
            dtpFecha = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            txtDescripcion = new TextBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            txtIdModificar = new TextBox();
            btnModificar = new Button();
            dtpNuevaFecha = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            txtNuevaDescripcion = new TextBox();
            groupBox3 = new GroupBox();
            btnEliminar = new Button();
            txtIdEliminar = new TextBox();
            label6 = new Label();
            dgvTareas = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCrear);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Location = new Point(29, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 168);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nueva Tarea";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(236, 123);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(86, 23);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(101, 77);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(221, 23);
            dtpFecha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 83);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 43);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(101, 40);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(221, 23);
            txtDescripcion.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtIdModificar);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(dtpNuevaFecha);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtNuevaDescripcion);
            groupBox2.Location = new Point(29, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 189);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar Tarea";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 41);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 6;
            label5.Text = "ID de tarea:";
            // 
            // txtIdModificar
            // 
            txtIdModificar.Location = new Point(101, 38);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(221, 23);
            txtIdModificar.TabIndex = 5;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(236, 153);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // dtpNuevaFecha
            // 
            dtpNuevaFecha.Location = new Point(101, 112);
            dtpNuevaFecha.Name = "dtpNuevaFecha";
            dtpNuevaFecha.Size = new Size(221, 23);
            dtpNuevaFecha.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 118);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 78);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 1;
            label4.Text = "Descripcion:";
            // 
            // txtNuevaDescripcion
            // 
            txtNuevaDescripcion.Location = new Point(101, 75);
            txtNuevaDescripcion.Name = "txtNuevaDescripcion";
            txtNuevaDescripcion.Size = new Size(221, 23);
            txtNuevaDescripcion.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(txtIdEliminar);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(29, 409);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(345, 117);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar tarea";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(236, 72);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(101, 29);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(221, 23);
            txtIdEliminar.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 32);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 0;
            label6.Text = "ID de tarea:";
            // 
            // dgvTareas
            // 
            dgvTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareas.Location = new Point(413, 25);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.Size = new Size(412, 501);
            dgvTareas.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 558);
            Controls.Add(dgvTareas);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDescripcion;
        private Button btnCrear;
        private DateTimePicker dtpFecha;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txtIdModificar;
        private Button btnModificar;
        private DateTimePicker dtpNuevaFecha;
        private Label label3;
        private Label label4;
        private TextBox txtNuevaDescripcion;
        private GroupBox groupBox3;
        private Button btnEliminar;
        private TextBox txtIdEliminar;
        private Label label6;
        private DataGridView dgvTareas;
    }
}
