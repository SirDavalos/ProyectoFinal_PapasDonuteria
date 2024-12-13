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
            ((System.ComponentModel.ISupportInitialize)pictureBoxForma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMasa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGlas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDCantidad).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxForma
            // 
            pictureBoxForma.Location = new Point(70, 111);
            pictureBoxForma.Name = "pictureBoxForma";
            pictureBoxForma.Size = new Size(220, 220);
            pictureBoxForma.TabIndex = 0;
            pictureBoxForma.TabStop = false;
            // 
            // pictureBoxMasa
            // 
            pictureBoxMasa.Location = new Point(394, 111);
            pictureBoxMasa.Name = "pictureBoxMasa";
            pictureBoxMasa.Size = new Size(220, 220);
            pictureBoxMasa.TabIndex = 1;
            pictureBoxMasa.TabStop = false;
            // 
            // pictureBoxGlas
            // 
            pictureBoxGlas.Location = new Point(718, 111);
            pictureBoxGlas.Name = "pictureBoxGlas";
            pictureBoxGlas.Size = new Size(220, 220);
            pictureBoxGlas.TabIndex = 2;
            pictureBoxGlas.TabStop = false;
            // 
            // buttonFormaL
            // 
            buttonFormaL.Location = new Point(30, 173);
            buttonFormaL.Name = "buttonFormaL";
            buttonFormaL.Size = new Size(34, 97);
            buttonFormaL.TabIndex = 3;
            buttonFormaL.Text = "<";
            buttonFormaL.UseVisualStyleBackColor = true;
            buttonFormaL.Click += buttonFormaL_Click;
            // 
            // buttonFormaR
            // 
            buttonFormaR.Location = new Point(296, 173);
            buttonFormaR.Name = "buttonFormaR";
            buttonFormaR.Size = new Size(34, 97);
            buttonFormaR.TabIndex = 4;
            buttonFormaR.Text = ">";
            buttonFormaR.UseVisualStyleBackColor = true;
            buttonFormaR.Click += buttonFormaR_Click;
            // 
            // buttonMasaL
            // 
            buttonMasaL.Location = new Point(354, 173);
            buttonMasaL.Name = "buttonMasaL";
            buttonMasaL.Size = new Size(34, 97);
            buttonMasaL.TabIndex = 5;
            buttonMasaL.Text = "<";
            buttonMasaL.UseVisualStyleBackColor = true;
            buttonMasaL.Click += buttonMasaL_Click;
            // 
            // buttonMasaR
            // 
            buttonMasaR.Location = new Point(620, 173);
            buttonMasaR.Name = "buttonMasaR";
            buttonMasaR.Size = new Size(34, 97);
            buttonMasaR.TabIndex = 6;
            buttonMasaR.Text = ">";
            buttonMasaR.UseVisualStyleBackColor = true;
            buttonMasaR.Click += buttonMasaR_Click;
            // 
            // buttonGlasL
            // 
            buttonGlasL.Location = new Point(678, 173);
            buttonGlasL.Name = "buttonGlasL";
            buttonGlasL.Size = new Size(34, 97);
            buttonGlasL.TabIndex = 7;
            buttonGlasL.Text = "<";
            buttonGlasL.UseVisualStyleBackColor = true;
            buttonGlasL.Click += buttonGlasL_Click;
            // 
            // buttonGlasR
            // 
            buttonGlasR.Location = new Point(944, 173);
            buttonGlasR.Name = "buttonGlasR";
            buttonGlasR.Size = new Size(34, 97);
            buttonGlasR.TabIndex = 8;
            buttonGlasR.Text = ">";
            buttonGlasR.UseVisualStyleBackColor = true;
            buttonGlasR.Click += buttonGlasR_Click;
            // 
            // richTextBoxMasa
            // 
            richTextBoxMasa.Location = new Point(394, 337);
            richTextBoxMasa.Name = "richTextBoxMasa";
            richTextBoxMasa.ReadOnly = true;
            richTextBoxMasa.Size = new Size(220, 60);
            richTextBoxMasa.TabIndex = 10;
            richTextBoxMasa.Text = "";
            // 
            // richTextBoxGlas
            // 
            richTextBoxGlas.Location = new Point(718, 337);
            richTextBoxGlas.Name = "richTextBoxGlas";
            richTextBoxGlas.ReadOnly = true;
            richTextBoxGlas.Size = new Size(220, 60);
            richTextBoxGlas.TabIndex = 11;
            richTextBoxGlas.Text = "";
            // 
            // dateTimePickerEntrega
            // 
            dateTimePickerEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerEntrega.Format = DateTimePickerFormat.Short;
            dateTimePickerEntrega.Location = new Point(168, 481);
            dateTimePickerEntrega.MinDate = new DateTime(2024, 12, 12, 0, 0, 0, 0);
            dateTimePickerEntrega.Name = "dateTimePickerEntrega";
            dateTimePickerEntrega.Size = new Size(160, 29);
            dateTimePickerEntrega.TabIndex = 12;
            dateTimePickerEntrega.Value = new DateTime(2024, 12, 12, 18, 18, 39, 0);
            // 
            // numUDCantidad
            // 
            numUDCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numUDCantidad.Location = new Point(168, 430);
            numUDCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUDCantidad.Name = "numUDCantidad";
            numUDCantidad.Size = new Size(160, 29);
            numUDCantidad.TabIndex = 13;
            numUDCantidad.TextAlign = HorizontalAlignment.Center;
            numUDCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(424, 449);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(160, 35);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "AÑADIR";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonVPedido
            // 
            buttonVPedido.Location = new Point(680, 428);
            buttonVPedido.Name = "buttonVPedido";
            buttonVPedido.Size = new Size(160, 35);
            buttonVPedido.TabIndex = 15;
            buttonVPedido.Text = "VER PEDIDO";
            buttonVPedido.UseVisualStyleBackColor = true;
            buttonVPedido.Click += buttonVPedido_Click;
            // 
            // buttonComprar
            // 
            buttonComprar.Location = new Point(680, 475);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(160, 35);
            buttonComprar.TabIndex = 16;
            buttonComprar.Text = "COMPRAR";
            buttonComprar.UseVisualStyleBackColor = true;
            buttonComprar.Click += buttonComprar_Click;
            // 
            // richTextBoxForma
            // 
            richTextBoxForma.Location = new Point(70, 337);
            richTextBoxForma.Name = "richTextBoxForma";
            richTextBoxForma.ReadOnly = true;
            richTextBoxForma.Size = new Size(220, 60);
            richTextBoxForma.TabIndex = 9;
            richTextBoxForma.Text = "";
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(900, 25);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.RightToLeft = RightToLeft.No;
            labelUsuario.Size = new Size(72, 18);
            labelUsuario.TabIndex = 17;
            labelUsuario.Text = "joihasjd";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 535);
            Controls.Add(labelUsuario);
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
    }
}