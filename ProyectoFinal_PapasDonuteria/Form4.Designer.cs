namespace ProyectoFinal_PapasDonuteria
{
    partial class FormAdmin
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
            lblNombreAdmin = new Label();
            btnAgregar = new Button();
            btnVerLista = new Button();
            btnEliminar = new Button();
            lblSalir = new Button();
            groupBoxProductos = new GroupBox();
            groupBoxProductos.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreAdmin
            // 
            lblNombreAdmin.AutoSize = true;
            lblNombreAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreAdmin.Location = new Point(22, 31);
            lblNombreAdmin.Name = "lblNombreAdmin";
            lblNombreAdmin.Size = new Size(139, 21);
            lblNombreAdmin.TabIndex = 0;
            lblNombreAdmin.Text = "Nombre de Admin";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(26, 33);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 44);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVerLista
            // 
            btnVerLista.Location = new Point(26, 154);
            btnVerLista.Name = "btnVerLista";
            btnVerLista.Size = new Size(114, 44);
            btnVerLista.TabIndex = 3;
            btnVerLista.Text = "Ver lista de Productos";
            btnVerLista.UseVisualStyleBackColor = true;
            btnVerLista.Click += btnVerLista_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(26, 94);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 44);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblSalir
            // 
            lblSalir.Location = new Point(642, 338);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new Size(114, 44);
            lblSalir.TabIndex = 5;
            lblSalir.Text = "Salir";
            lblSalir.UseVisualStyleBackColor = true;
            lblSalir.Click += lblSalir_Click;
            // 
            // groupBoxProductos
            // 
            groupBoxProductos.Controls.Add(btnEliminar);
            groupBoxProductos.Controls.Add(btnVerLista);
            groupBoxProductos.Controls.Add(btnAgregar);
            groupBoxProductos.Location = new Point(21, 159);
            groupBoxProductos.Name = "groupBoxProductos";
            groupBoxProductos.Size = new Size(169, 279);
            groupBoxProductos.TabIndex = 6;
            groupBoxProductos.TabStop = false;
            groupBoxProductos.Text = "Productos";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxProductos);
            Controls.Add(lblSalir);
            Controls.Add(lblNombreAdmin);
            Name = "FormAdmin";
            Text = "Menu de Admin";
            groupBoxProductos.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreAdmin;
        private Button btnAgregar;
        private Button btnVerLista;
        private Button btnEliminar;
        private Button lblSalir;
        private GroupBox groupBoxProductos;
    }
}