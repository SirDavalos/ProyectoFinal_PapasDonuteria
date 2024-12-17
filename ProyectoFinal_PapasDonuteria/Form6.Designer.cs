namespace ProyectoFinal_PapasDonuteria
{
    partial class Form6
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            labelUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(11, 223);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(484, 299);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 220, 255);
            button1.Location = new Point(98, 127);
            button1.Name = "button1";
            button1.Size = new Size(149, 56);
            button1.TabIndex = 3;
            button1.Text = "Generar codigo de barras";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 220, 255);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(labelUsuario);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 120);
            panel1.TabIndex = 21;
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Logo;
            pictureBox2.Location = new Point(11, 15);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(201, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(1985, 41);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.RightToLeft = RightToLeft.No;
            labelUsuario.Size = new Size(80, 22);
            labelUsuario.TabIndex = 17;
            labelUsuario.Text = "usuario";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 534);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox2;
        private Label labelUsuario;
    }
}