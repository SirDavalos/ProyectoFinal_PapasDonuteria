namespace ProyectoFinal_PapasDonuteria
{
    partial class FormListaProd
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
            label11 = new Label();
            labelFechaHora = new Label();
            lblLista = new Label();
            panel1 = new Panel();
            label12 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonLogOut = new Button();
            labelUsuario = new Label();
            dataGridViewLista = new DataGridView();
            timerFechaHora = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(771, 107);
            label11.Name = "label11";
            label11.Size = new Size(72, 19);
            label11.TabIndex = 69;
            label11.Text = "Imagen:";
            // 
            // labelFechaHora
            // 
            labelFechaHora.AutoSize = true;
            labelFechaHora.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFechaHora.Location = new Point(15, 96);
            labelFechaHora.Name = "labelFechaHora";
            labelFechaHora.Size = new Size(117, 19);
            labelFechaHora.TabIndex = 68;
            labelFechaHora.Text = "FECHA Y HORA";
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Font = new Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLista.ForeColor = Color.FromArgb(255, 128, 128);
            lblLista.Location = new Point(364, 96);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(292, 30);
            lblLista.TabIndex = 67;
            lblLista.Text = "LISTA DE PRODUCTOS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 220, 255);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonLogOut);
            panel1.Controls.Add(labelUsuario);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 84);
            panel1.TabIndex = 66;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(1658, 31);
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
            label4.Location = new Point(2466, 31);
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
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(3274, 31);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.RightToLeft = RightToLeft.No;
            labelUsuario.Size = new Size(64, 18);
            labelUsuario.TabIndex = 17;
            labelUsuario.Text = "usuario";
            // 
            // dataGridViewLista
            // 
            dataGridViewLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLista.Location = new Point(125, 184);
            dataGridViewLista.Name = "dataGridViewLista";
            dataGridViewLista.Size = new Size(639, 226);
            dataGridViewLista.TabIndex = 70;
            // 
            // FormListaProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 450);
            Controls.Add(dataGridViewLista);
            Controls.Add(label11);
            Controls.Add(labelFechaHora);
            Controls.Add(lblLista);
            Controls.Add(panel1);
            Name = "FormListaProd";
            Text = "FormListaProd";
            Load += FormListaProd_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label labelFechaHora;
        private Label lblLista;
        private Panel panel1;
        private Label label12;
        private Label label4;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button buttonLogOut;
        private Label labelUsuario;
        private DataGridView dataGridViewLista;
        private System.Windows.Forms.Timer timerFechaHora;
    }
}