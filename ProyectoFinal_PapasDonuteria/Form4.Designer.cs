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
            components = new System.ComponentModel.Container();
            lblNombreAdmin = new Label();
            lblSalir = new Button();
            panel1 = new Panel();
            label12 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonLogOut = new Button();
            labelUsuario = new Label();
            labelFechaHora = new Label();
            timerFechaHora = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            btnAgregar = new Button();
            btnVerLista = new Button();
            btnEliminar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombreAdmin
            // 
            lblNombreAdmin.AutoSize = true;
            lblNombreAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreAdmin.Location = new Point(550, 36);
            lblNombreAdmin.Name = "lblNombreAdmin";
            lblNombreAdmin.Size = new Size(139, 21);
            lblNombreAdmin.TabIndex = 0;
            lblNombreAdmin.Text = "Nombre de Admin";
            // 
            // lblSalir
            // 
            lblSalir.Location = new Point(532, 315);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new Size(114, 44);
            lblSalir.TabIndex = 5;
            lblSalir.Text = "Salir";
            lblSalir.UseVisualStyleBackColor = true;
            lblSalir.Click += lblSalir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 220, 255);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblNombreAdmin);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonLogOut);
            panel1.Controls.Add(labelUsuario);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 84);
            panel1.TabIndex = 67;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(2238, 31);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(64, 18);
            label12.TabIndex = 67;
            label12.Text = "usuario";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3046, 31);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(64, 18);
            label4.TabIndex = 22;
            label4.Text = "usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(194, 41);
            label3.Name = "label3";
            label3.Size = new Size(260, 22);
            label3.TabIndex = 21;
            label3.Text = "aqui debe ir nuestro logo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(194, 11);
            label1.Name = "label1";
            label1.Size = new Size(272, 30);
            label1.TabIndex = 20;
            label1.Text = "PAPA'S DONUTERIA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(10, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.White;
            buttonLogOut.Location = new Point(695, 33);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(74, 30);
            buttonLogOut.TabIndex = 18;
            buttonLogOut.Text = "log out";
            buttonLogOut.UseVisualStyleBackColor = false;
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(3854, 31);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.RightToLeft = RightToLeft.No;
            labelUsuario.Size = new Size(64, 18);
            labelUsuario.TabIndex = 17;
            labelUsuario.Text = "usuario";
            // 
            // labelFechaHora
            // 
            labelFechaHora.AutoSize = true;
            labelFechaHora.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFechaHora.Location = new Point(44, 99);
            labelFechaHora.Name = "labelFechaHora";
            labelFechaHora.Size = new Size(117, 19);
            labelFechaHora.TabIndex = 68;
            labelFechaHora.Text = "FECHA Y HORA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(244, 99);
            label2.Name = "label2";
            label2.Size = new Size(360, 30);
            label2.TabIndex = 27;
            label2.Text = "MENU DE ADMINISTRADOR";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(181, 182);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 44);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVerLista
            // 
            btnVerLista.Location = new Point(181, 315);
            btnVerLista.Name = "btnVerLista";
            btnVerLista.Size = new Size(114, 44);
            btnVerLista.TabIndex = 3;
            btnVerLista.Text = "Ver lista de Productos";
            btnVerLista.UseVisualStyleBackColor = true;
            btnVerLista.Click += btnVerLista_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(181, 248);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 44);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 433);
            Controls.Add(btnVerLista);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(labelFechaHora);
            Controls.Add(btnAgregar);
            Controls.Add(panel1);
            Controls.Add(lblSalir);
            Name = "FormAdmin";
            Text = "Menu de Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreAdmin;
        private Button lblSalir;
        private Panel panel1;
        private Label label12;
        private Label label4;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button buttonLogOut;
        private Label labelUsuario;
        private Label labelFechaHora;
        private System.Windows.Forms.Timer timerFechaHora;
        private Label label2;
        private Button btnAgregar;
        private Button btnVerLista;
        private Button btnEliminar;
    }
}