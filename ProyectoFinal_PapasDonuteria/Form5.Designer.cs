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
            groupBox2 = new GroupBox();
            buttonEfec = new Button();
            buttonTarj = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 30);
            label1.Name = "label1";
            label1.Size = new Size(213, 31);
            label1.TabIndex = 0;
            label1.Text = "Datos de la compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(450, 46);
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
            groupBox1.Location = new Point(44, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 198);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonTarj);
            groupBox2.Controls.Add(buttonEfec);
            groupBox2.Location = new Point(450, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 196);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // buttonEfec
            // 
            buttonEfec.Location = new Point(52, 23);
            buttonEfec.Name = "buttonEfec";
            buttonEfec.Size = new Size(120, 70);
            buttonEfec.TabIndex = 0;
            buttonEfec.Text = "Efectivo";
            buttonEfec.UseVisualStyleBackColor = true;
            buttonEfec.Click += buttonEfec_Click;
            // 
            // buttonTarj
            // 
            buttonTarj.Location = new Point(52, 113);
            buttonTarj.Name = "buttonTarj";
            buttonTarj.Size = new Size(120, 70);
            buttonTarj.TabIndex = 1;
            buttonTarj.Text = "Tarjeta";
            buttonTarj.UseVisualStyleBackColor = true;
            buttonTarj.Click += buttonTarj_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
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
    }
}