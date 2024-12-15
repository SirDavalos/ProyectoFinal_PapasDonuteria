namespace ProyectoFinal_PapasDonuteria
{
    partial class Form3
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
            pictureBoxForma = new PictureBox();
            pictureBoxMasa = new PictureBox();
            pictureBoxGlas = new PictureBox();
            buttonFormaL = new Button();
            buttonFormaR = new Button();
            buttonMasaL = new Button();
            buttonMasaR = new Button();
            buttonGlasL = new Button();
            buttonGlasR = new Button();
            richTextBoxMasa = new RichTextBox();
            richTextBoxGlas = new RichTextBox();
            dateTimePickerEntrega = new DateTimePicker();
            numUDCantidad = new NumericUpDown();
            buttonAdd = new Button();
            buttonVPedido = new Button();
            buttonComprar = new Button();
            richTextBoxForma = new RichTextBox();
            labelUsuario = new Label();
            buttonLogOut = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            richTextBoxExiF = new RichTextBox();
            richTextBoxExiM = new RichTextBox();
            richTextBoxExiG = new RichTextBox();
            label2 = new Label();
            labelFechaHora = new Label();
            timerFechaHora = new System.Windows.Forms.Timer(components);
            buttonBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMasa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGlas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDCantidad).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxForma
            // 
            pictureBoxForma.Location = new Point(70, 133);
            pictureBoxForma.Name = "pictureBoxForma";
            pictureBoxForma.Size = new Size(220, 220);
            pictureBoxForma.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxForma.TabIndex = 0;
            pictureBoxForma.TabStop = false;
            // 
            // pictureBoxMasa
            // 
            pictureBoxMasa.Location = new Point(395, 133);
            pictureBoxMasa.Name = "pictureBoxMasa";
            pictureBoxMasa.Size = new Size(220, 220);
            pictureBoxMasa.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMasa.TabIndex = 1;
            pictureBoxMasa.TabStop = false;
            // 
            // pictureBoxGlas
            // 
            pictureBoxGlas.Location = new Point(718, 133);
            pictureBoxGlas.Name = "pictureBoxGlas";
            pictureBoxGlas.Size = new Size(220, 220);
            pictureBoxGlas.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGlas.TabIndex = 2;
            pictureBoxGlas.TabStop = false;
            // 
            // buttonFormaL
            // 
            buttonFormaL.BackColor = Color.FromArgb(255, 220, 255);
            buttonFormaL.Location = new Point(30, 195);
            buttonFormaL.Name = "buttonFormaL";
            buttonFormaL.Size = new Size(34, 97);
            buttonFormaL.TabIndex = 3;
            buttonFormaL.Text = "<";
            buttonFormaL.UseVisualStyleBackColor = false;
            buttonFormaL.Click += buttonFormaL_Click;
            // 
            // buttonFormaR
            // 
            buttonFormaR.BackColor = Color.FromArgb(255, 220, 255);
            buttonFormaR.Location = new Point(296, 195);
            buttonFormaR.Name = "buttonFormaR";
            buttonFormaR.Size = new Size(34, 97);
            buttonFormaR.TabIndex = 4;
            buttonFormaR.Text = ">";
            buttonFormaR.UseVisualStyleBackColor = false;
            buttonFormaR.Click += buttonFormaR_Click;
            // 
            // buttonMasaL
            // 
            buttonMasaL.BackColor = Color.FromArgb(255, 220, 255);
            buttonMasaL.Location = new Point(354, 195);
            buttonMasaL.Name = "buttonMasaL";
            buttonMasaL.Size = new Size(34, 97);
            buttonMasaL.TabIndex = 5;
            buttonMasaL.Text = "<";
            buttonMasaL.UseVisualStyleBackColor = false;
            buttonMasaL.Click += buttonMasaL_Click;
            // 
            // buttonMasaR
            // 
            buttonMasaR.BackColor = Color.FromArgb(255, 220, 255);
            buttonMasaR.Location = new Point(620, 195);
            buttonMasaR.Name = "buttonMasaR";
            buttonMasaR.Size = new Size(34, 97);
            buttonMasaR.TabIndex = 6;
            buttonMasaR.Text = ">";
            buttonMasaR.UseVisualStyleBackColor = false;
            buttonMasaR.Click += buttonMasaR_Click;
            // 
            // buttonGlasL
            // 
            buttonGlasL.BackColor = Color.FromArgb(255, 220, 255);
            buttonGlasL.Location = new Point(678, 195);
            buttonGlasL.Name = "buttonGlasL";
            buttonGlasL.Size = new Size(34, 97);
            buttonGlasL.TabIndex = 7;
            buttonGlasL.Text = "<";
            buttonGlasL.UseVisualStyleBackColor = false;
            buttonGlasL.Click += buttonGlasL_Click;
            // 
            // buttonGlasR
            // 
            buttonGlasR.BackColor = Color.FromArgb(255, 220, 255);
            buttonGlasR.Location = new Point(944, 195);
            buttonGlasR.Name = "buttonGlasR";
            buttonGlasR.Size = new Size(34, 97);
            buttonGlasR.TabIndex = 8;
            buttonGlasR.Text = ">";
            buttonGlasR.UseVisualStyleBackColor = false;
            buttonGlasR.Click += buttonGlasR_Click;
            // 
            // richTextBoxMasa
            // 
            richTextBoxMasa.BackColor = Color.FromArgb(255, 240, 255);
            richTextBoxMasa.Font = new Font("Consolas", 9.75F);
            richTextBoxMasa.Location = new Point(395, 356);
            richTextBoxMasa.Name = "richTextBoxMasa";
            richTextBoxMasa.ReadOnly = true;
            richTextBoxMasa.Size = new Size(175, 77);
            richTextBoxMasa.TabIndex = 10;
            richTextBoxMasa.Text = "";
            // 
            // richTextBoxGlas
            // 
            richTextBoxGlas.BackColor = Color.FromArgb(255, 240, 255);
            richTextBoxGlas.Font = new Font("Consolas", 9.75F);
            richTextBoxGlas.Location = new Point(718, 358);
            richTextBoxGlas.Name = "richTextBoxGlas";
            richTextBoxGlas.ReadOnly = true;
            richTextBoxGlas.Size = new Size(175, 75);
            richTextBoxGlas.TabIndex = 11;
            richTextBoxGlas.Text = "";
            // 
            // dateTimePickerEntrega
            // 
            dateTimePickerEntrega.CalendarMonthBackground = Color.White;
            dateTimePickerEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerEntrega.Format = DateTimePickerFormat.Short;
            dateTimePickerEntrega.Location = new Point(168, 493);
            dateTimePickerEntrega.MinDate = new DateTime(2024, 12, 14, 0, 0, 0, 0);
            dateTimePickerEntrega.Name = "dateTimePickerEntrega";
            dateTimePickerEntrega.Size = new Size(160, 29);
            dateTimePickerEntrega.TabIndex = 12;
            dateTimePickerEntrega.Value = new DateTime(2024, 12, 14, 0, 0, 0, 0);
            // 
            // numUDCantidad
            // 
            numUDCantidad.BackColor = Color.FromArgb(255, 230, 255);
            numUDCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numUDCantidad.Location = new Point(168, 442);
            numUDCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUDCantidad.Name = "numUDCantidad";
            numUDCantidad.Size = new Size(160, 29);
            numUDCantidad.TabIndex = 13;
            numUDCantidad.TextAlign = HorizontalAlignment.Center;
            numUDCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(255, 220, 255);
            buttonAdd.Location = new Point(424, 442);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(160, 35);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "AÑADIR";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonVPedido
            // 
            buttonVPedido.BackColor = Color.FromArgb(255, 220, 255);
            buttonVPedido.Location = new Point(680, 440);
            buttonVPedido.Name = "buttonVPedido";
            buttonVPedido.Size = new Size(160, 35);
            buttonVPedido.TabIndex = 15;
            buttonVPedido.Text = "VER PEDIDO";
            buttonVPedido.UseVisualStyleBackColor = false;
            buttonVPedido.Click += buttonVPedido_Click;
            // 
            // buttonComprar
            // 
            buttonComprar.BackColor = Color.FromArgb(255, 220, 255);
            buttonComprar.Location = new Point(424, 483);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(160, 35);
            buttonComprar.TabIndex = 16;
            buttonComprar.Text = "COMPRAR";
            buttonComprar.UseVisualStyleBackColor = false;
            buttonComprar.Click += buttonComprar_Click;
            // 
            // richTextBoxForma
            // 
            richTextBoxForma.BackColor = Color.FromArgb(255, 240, 255);
            richTextBoxForma.Font = new Font("Consolas", 9.75F);
            richTextBoxForma.Location = new Point(70, 356);
            richTextBoxForma.Name = "richTextBoxForma";
            richTextBoxForma.ReadOnly = true;
            richTextBoxForma.Size = new Size(175, 77);
            richTextBoxForma.TabIndex = 9;
            richTextBoxForma.Text = "";
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(850, 31);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.RightToLeft = RightToLeft.No;
            labelUsuario.Size = new Size(64, 18);
            labelUsuario.TabIndex = 17;
            labelUsuario.Text = "usuario";
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 220, 255);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonLogOut);
            panel1.Controls.Add(labelUsuario);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 84);
            panel1.TabIndex = 19;
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
            // richTextBoxExiF
            // 
            richTextBoxExiF.BackColor = Color.FromArgb(255, 240, 255);
            richTextBoxExiF.Font = new Font("Consolas", 9.75F);
            richTextBoxExiF.Location = new Point(250, 370);
            richTextBoxExiF.Name = "richTextBoxExiF";
            richTextBoxExiF.ReadOnly = true;
            richTextBoxExiF.Size = new Size(40, 48);
            richTextBoxExiF.TabIndex = 20;
            richTextBoxExiF.Text = "";
            // 
            // richTextBoxExiM
            // 
            richTextBoxExiM.BackColor = Color.FromArgb(255, 240, 255);
            richTextBoxExiM.Font = new Font("Consolas", 9.75F);
            richTextBoxExiM.Location = new Point(575, 370);
            richTextBoxExiM.Name = "richTextBoxExiM";
            richTextBoxExiM.ReadOnly = true;
            richTextBoxExiM.Size = new Size(40, 48);
            richTextBoxExiM.TabIndex = 21;
            richTextBoxExiM.Text = "";
            // 
            // richTextBoxExiG
            // 
            richTextBoxExiG.BackColor = Color.FromArgb(255, 240, 255);
            richTextBoxExiG.Font = new Font("Consolas", 9.75F);
            richTextBoxExiG.Location = new Point(899, 370);
            richTextBoxExiG.Name = "richTextBoxExiG";
            richTextBoxExiG.ReadOnly = true;
            richTextBoxExiG.Size = new Size(40, 48);
            richTextBoxExiG.TabIndex = 22;
            richTextBoxExiG.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(362, 93);
            label2.Name = "label2";
            label2.Size = new Size(286, 30);
            label2.TabIndex = 23;
            label2.Text = "CREACION DE DONAS";
            // 
            // labelFechaHora
            // 
            labelFechaHora.AutoSize = true;
            labelFechaHora.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFechaHora.Location = new Point(12, 93);
            labelFechaHora.Name = "labelFechaHora";
            labelFechaHora.Size = new Size(117, 19);
            labelFechaHora.TabIndex = 24;
            labelFechaHora.Text = "FECHA Y HORA";
            // 
            // timerFechaHora
            // 
            timerFechaHora.Tick += timerFechaHora_Tick;
            // 
            // buttonBorrar
            // 
            buttonBorrar.BackColor = Color.FromArgb(255, 220, 255);
            buttonBorrar.Location = new Point(680, 483);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(160, 35);
            buttonBorrar.TabIndex = 25;
            buttonBorrar.Text = "BORRAR PEDIDO";
            buttonBorrar.UseVisualStyleBackColor = false;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 535);
            Controls.Add(buttonBorrar);
            Controls.Add(labelFechaHora);
            Controls.Add(label2);
            Controls.Add(richTextBoxExiG);
            Controls.Add(richTextBoxExiM);
            Controls.Add(richTextBoxExiF);
            Controls.Add(panel1);
            Controls.Add(buttonComprar);
            Controls.Add(buttonVPedido);
            Controls.Add(buttonAdd);
            Controls.Add(numUDCantidad);
            Controls.Add(dateTimePickerEntrega);
            Controls.Add(richTextBoxGlas);
            Controls.Add(richTextBoxMasa);
            Controls.Add(richTextBoxForma);
            Controls.Add(buttonGlasR);
            Controls.Add(buttonGlasL);
            Controls.Add(buttonMasaR);
            Controls.Add(buttonMasaL);
            Controls.Add(buttonFormaR);
            Controls.Add(buttonFormaL);
            Controls.Add(pictureBoxGlas);
            Controls.Add(pictureBoxMasa);
            Controls.Add(pictureBoxForma);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBoxForma).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMasa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGlas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDCantidad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxForma;
        private PictureBox pictureBoxMasa;
        private PictureBox pictureBoxGlas;
        private Button buttonFormaL;
        private Button buttonFormaR;
        private Button buttonMasaL;
        private Button buttonMasaR;
        private Button buttonGlasL;
        private Button buttonGlasR;
        private RichTextBox richTextBoxMasa;
        private RichTextBox richTextBoxGlas;
        private DateTimePicker dateTimePickerEntrega;
        private NumericUpDown numUDCantidad;
        private Button buttonAdd;
        private Button buttonVPedido;
        private Button buttonComprar;
        private RichTextBox richTextBoxForma;
        private Label labelUsuario;
        private Button buttonLogOut;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private RichTextBox richTextBoxExiF;
        private RichTextBox richTextBoxExiM;
        private RichTextBox richTextBoxExiG;
        private Label label2;
        private Label label3;
        private Label labelFechaHora;
        private System.Windows.Forms.Timer timerFechaHora;
        private Button buttonBorrar;
    }
}