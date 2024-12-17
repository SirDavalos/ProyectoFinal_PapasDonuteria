namespace ProyectoFinal_PapasDonuteria
{
    partial class Form5
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelfecha = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            buttonTarj = new Button();
            buttonEfec = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            labelUsuario = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 146);
            label1.Name = "label1";
            label1.Size = new Size(213, 31);
            label1.TabIndex = 0;
            label1.Text = "Datos de la compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(427, 146);
            label2.Name = "label2";
            label2.Size = new Size(196, 31);
            label2.TabIndex = 1;
            label2.Text = "Métodos de pago";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 36);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 2;
            label3.Text = "Cantidad de donas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 84);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 3;
            label4.Text = "Tot a pagar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 138);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 4;
            label5.Text = "Fecha";
            // 
            // labelfecha
            // 
            labelfecha.AutoSize = true;
            labelfecha.Location = new Point(170, 138);
            labelfecha.Name = "labelfecha";
            labelfecha.Size = new Size(54, 20);
            labelfecha.TabIndex = 5;
            labelfecha.Text = "FECHA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(labelfecha);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(21, 178);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 198);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonTarj);
            groupBox2.Controls.Add(buttonEfec);
            groupBox2.Location = new Point(427, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 196);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // buttonTarj
            // 
            buttonTarj.BackColor = Color.FromArgb(255, 220, 255);
            buttonTarj.Location = new Point(52, 113);
            buttonTarj.Name = "buttonTarj";
            buttonTarj.Size = new Size(120, 70);
            buttonTarj.TabIndex = 1;
            buttonTarj.Text = "Tarjeta";
            buttonTarj.UseVisualStyleBackColor = false;
            buttonTarj.Click += buttonTarj_Click;
            // 
            // buttonEfec
            // 
            buttonEfec.BackColor = Color.FromArgb(255, 220, 255);
            buttonEfec.Location = new Point(52, 23);
            buttonEfec.Name = "buttonEfec";
            buttonEfec.Size = new Size(120, 70);
            buttonEfec.TabIndex = 0;
            buttonEfec.Text = "Efectivo";
            buttonEfec.UseVisualStyleBackColor = false;
            buttonEfec.Click += buttonEfec_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 220, 255);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelUsuario);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 107);
            panel1.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(222, 55);
            label6.Name = "label6";
            label6.Size = new Size(376, 28);
            label6.TabIndex = 21;
            label6.Text = "Elige, personaliza y difruta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(222, 15);
            label7.Name = "label7";
            label7.Size = new Size(348, 39);
            label7.TabIndex = 20;
            label7.Text = "PAPA'S DONUTERIA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(11, 15);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(1478, 41);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.RightToLeft = RightToLeft.No;
            labelUsuario.Size = new Size(80, 22);
            labelUsuario.TabIndex = 17;
            labelUsuario.Text = "usuario";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 427);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelfecha;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button buttonTarj;
        private Button buttonEfec;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private Label labelUsuario;
    }
}