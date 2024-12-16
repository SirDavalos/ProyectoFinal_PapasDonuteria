namespace ProyectoFinal_PapasDonuteria
{
    partial class Altas
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
            labelFechaHora = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonLogOut = new Button();
            labelUsuario = new Label();
            timerFechaHora = new System.Windows.Forms.Timer(components);
            textBoxId = new TextBox();
            textBoxTipo = new TextBox();
            textBoxNombre = new TextBox();
            textBoxExistencia = new TextBox();
            textBoxPrecio = new TextBox();
            textBoxImagen = new TextBox();
            textBoxDescri = new TextBox();
            buttonAlta = new Button();
            pictureBoxImg = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnCargarImagen = new Button();
            label11 = new Label();
            buttonSalir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImg).BeginInit();
            SuspendLayout();
            // 
            // labelFechaHora
            // 
            labelFechaHora.AutoSize = true;
            labelFechaHora.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFechaHora.Location = new Point(12, 93);
            labelFechaHora.Name = "labelFechaHora";
            labelFechaHora.Size = new Size(117, 19);
            labelFechaHora.TabIndex = 27;
            labelFechaHora.Text = "FECHA Y HORA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(466, 93);
            label2.Name = "label2";
            label2.Size = new Size(100, 30);
            label2.TabIndex = 26;
            label2.Text = "ALTAS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 220, 255);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonLogOut);
            panel1.Controls.Add(labelUsuario);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 84);
            panel1.TabIndex = 25;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(850, 31);
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
            buttonLogOut.Location = new Point(920, 25);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(74, 30);
            buttonLogOut.TabIndex = 18;
            buttonLogOut.Text = "log out";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(1658, 31);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.RightToLeft = RightToLeft.No;
            labelUsuario.Size = new Size(64, 18);
            labelUsuario.TabIndex = 17;
            labelUsuario.Text = "usuario";
            // 
            // timerFechaHora
            // 
            timerFechaHora.Tick += timerFechaHora_Tick;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(155, 171);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(176, 23);
            textBoxId.TabIndex = 28;
            // 
            // textBoxTipo
            // 
            textBoxTipo.Location = new Point(155, 208);
            textBoxTipo.Name = "textBoxTipo";
            textBoxTipo.Size = new Size(176, 23);
            textBoxTipo.TabIndex = 29;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(155, 245);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(176, 23);
            textBoxNombre.TabIndex = 30;
            // 
            // textBoxExistencia
            // 
            textBoxExistencia.Location = new Point(155, 319);
            textBoxExistencia.Name = "textBoxExistencia";
            textBoxExistencia.Size = new Size(176, 23);
            textBoxExistencia.TabIndex = 33;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(155, 282);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(176, 23);
            textBoxPrecio.TabIndex = 32;
            // 
            // textBoxImagen
            // 
            textBoxImagen.Location = new Point(694, 128);
            textBoxImagen.Name = "textBoxImagen";
            textBoxImagen.Size = new Size(220, 23);
            textBoxImagen.TabIndex = 31;
            // 
            // textBoxDescri
            // 
            textBoxDescri.Location = new Point(410, 208);
            textBoxDescri.Multiline = true;
            textBoxDescri.Name = "textBoxDescri";
            textBoxDescri.Size = new Size(220, 97);
            textBoxDescri.TabIndex = 34;
            // 
            // buttonAlta
            // 
            buttonAlta.Location = new Point(390, 395);
            buttonAlta.Name = "buttonAlta";
            buttonAlta.Size = new Size(252, 31);
            buttonAlta.TabIndex = 35;
            buttonAlta.Text = "AÑADIR";
            buttonAlta.UseVisualStyleBackColor = true;
            buttonAlta.Click += buttonAlta_Click;
            // 
            // pictureBoxImg
            // 
            pictureBoxImg.Location = new Point(694, 157);
            pictureBoxImg.Name = "pictureBoxImg";
            pictureBoxImg.Size = new Size(220, 220);
            pictureBoxImg.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImg.TabIndex = 36;
            pictureBoxImg.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(113, 171);
            label5.Name = "label5";
            label5.Size = new Size(36, 19);
            label5.TabIndex = 37;
            label5.Text = "Id:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(77, 245);
            label6.Name = "label6";
            label6.Size = new Size(72, 19);
            label6.TabIndex = 38;
            label6.Text = "Nombre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(95, 208);
            label7.Name = "label7";
            label7.Size = new Size(54, 19);
            label7.TabIndex = 39;
            label7.Text = "Tipo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(77, 282);
            label8.Name = "label8";
            label8.Size = new Size(72, 19);
            label8.TabIndex = 40;
            label8.Text = "Precio:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(41, 319);
            label9.Name = "label9";
            label9.Size = new Size(108, 19);
            label9.TabIndex = 41;
            label9.Text = "Existencia:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(458, 175);
            label10.Name = "label10";
            label10.Size = new Size(117, 19);
            label10.TabIndex = 42;
            label10.Text = "Descripcion:";
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.Location = new Point(694, 383);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(220, 33);
            btnCargarImagen.TabIndex = 43;
            btnCargarImagen.Text = "CARGAR IMAGEN";
            btnCargarImagen.UseVisualStyleBackColor = true;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(768, 104);
            label11.Name = "label11";
            label11.Size = new Size(72, 19);
            label11.TabIndex = 44;
            label11.Text = "Imagen:";
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(12, 412);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(137, 26);
            buttonSalir.TabIndex = 45;
            buttonSalir.Text = "SALIR";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // Altas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 450);
            Controls.Add(buttonSalir);
            Controls.Add(label11);
            Controls.Add(btnCargarImagen);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBoxImg);
            Controls.Add(buttonAlta);
            Controls.Add(textBoxDescri);
            Controls.Add(textBoxExistencia);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxImagen);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxTipo);
            Controls.Add(textBoxId);
            Controls.Add(labelFechaHora);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Altas";
            Text = "Altas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFechaHora;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button buttonLogOut;
        private Label labelUsuario;
        private Label label4;
        private System.Windows.Forms.Timer timerFechaHora;
        private TextBox textBoxId;
        private TextBox textBoxTipo;
        private TextBox textBoxNombre;
        private TextBox textBoxExistencia;
        private TextBox textBoxPrecio;
        private TextBox textBoxImagen;
        private TextBox textBoxDescri;
        private Button buttonAlta;
        private PictureBox pictureBoxImg;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnCargarImagen;
        private Label label11;
        private Button buttonSalir;
    }
}