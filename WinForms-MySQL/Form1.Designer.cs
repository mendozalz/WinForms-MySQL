﻿namespace WinForms_MySQL
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
            btnBuscar = new Button();
            label1 = new Label();
            dataGridView = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            edad = new DataGridViewTextBoxColumn();
            lblNombre = new Label();
            lblApellido = new Label();
            lblEdad = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtInsNombre = new TextBox();
            txtInsEdad = new TextBox();
            btnGuardar = new Button();
            txtInsApellido = new TextBox();
            btnEditar = new Button();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(458, 215);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 50;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 1;
            label1.Text = "Estado de la conexión";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { id, nombre, apellido, edad });
            dataGridView.Location = new Point(92, 244);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(443, 255);
            dataGridView.TabIndex = 2;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            // 
            // nombre
            // 
            nombre.HeaderText = "nombre";
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.HeaderText = "apellido";
            apellido.Name = "apellido";
            // 
            // edad
            // 
            edad.HeaderText = "edad";
            edad.Name = "edad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(90, 176);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 33;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(215, 176);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 33;
            lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(341, 175);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 33;
            lblEdad.Text = "Edad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 216);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 43;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(215, 216);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 43;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(341, 215);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 53);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 30;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 88);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 31;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 125);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 32;
            label4.Text = "Edad";
            // 
            // txtInsNombre
            // 
            txtInsNombre.Location = new Point(166, 50);
            txtInsNombre.Name = "txtInsNombre";
            txtInsNombre.Size = new Size(208, 23);
            txtInsNombre.TabIndex = 0;
            // 
            // txtInsEdad
            // 
            txtInsEdad.Location = new Point(166, 122);
            txtInsEdad.Name = "txtInsEdad";
            txtInsEdad.Size = new Size(208, 23);
            txtInsEdad.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(439, 49);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtInsApellido
            // 
            txtInsApellido.Location = new Point(166, 88);
            txtInsApellido.Name = "txtInsApellido";
            txtInsApellido.Size = new Size(208, 23);
            txtInsApellido.TabIndex = 1;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(439, 88);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(439, 125);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 5;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 511);
            Controls.Add(btnBorrar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtInsApellido);
            Controls.Add(txtInsEdad);
            Controls.Add(txtInsNombre);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(lblEdad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(dataGridView);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Label label1;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn edad;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblEdad;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEdad;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtInsNombre;
        private TextBox txtInsEdad;
        private Button btnGuardar;
        private TextBox txtInsApellido;
        private Button btnEditar;
        private Button btnBorrar;
    }
}
