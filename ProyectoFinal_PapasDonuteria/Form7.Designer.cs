namespace ProyectoFinal_PapasDonuteria
{
    partial class Form7
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonPagar = new Button();
            textBoxPin = new TextBox();
            label4 = new Label();
            textBoxAnio = new TextBox();
            textBoxMes = new TextBox();
            textBoxNumTarj = new TextBox();
            textBoxNom = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonPagar);
            groupBox1.Controls.Add(textBoxPin);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxAnio);
            groupBox1.Controls.Add(textBoxMes);
            groupBox1.Controls.Add(textBoxNumTarj);
            groupBox1.Controls.Add(textBoxNom);
            groupBox1.Location = new Point(39, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 304);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 115);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 8;
            label3.Text = "Fecha de vencimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 82);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 7;
            label2.Text = "Numero de tarjeta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 50);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre en la tarjeta";
            // 
            // buttonPagar
            // 
            buttonPagar.Location = new Point(203, 187);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(94, 29);
            buttonPagar.TabIndex = 1;
            buttonPagar.Text = "Pagar";
            buttonPagar.UseVisualStyleBackColor = true;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // textBoxPin
            // 
            textBoxPin.Location = new Point(203, 143);
            textBoxPin.Name = "textBoxPin";
            textBoxPin.Size = new Size(125, 27);
            textBoxPin.TabIndex = 5;
            textBoxPin.Text = "xxxx";
            textBoxPin.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 150);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 4;
            label4.Text = "PIN";
            // 
            // textBoxAnio
            // 
            textBoxAnio.Location = new Point(276, 112);
            textBoxAnio.Name = "textBoxAnio";
            textBoxAnio.Size = new Size(99, 27);
            textBoxAnio.TabIndex = 4;
            textBoxAnio.Text = "yyyy";
            textBoxAnio.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxMes
            // 
            textBoxMes.Location = new Point(203, 112);
            textBoxMes.Name = "textBoxMes";
            textBoxMes.Size = new Size(67, 27);
            textBoxMes.TabIndex = 3;
            textBoxMes.Text = "mm";
            textBoxMes.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNumTarj
            // 
            textBoxNumTarj.Location = new Point(203, 79);
            textBoxNumTarj.Name = "textBoxNumTarj";
            textBoxNumTarj.Size = new Size(172, 27);
            textBoxNumTarj.TabIndex = 2;
            textBoxNumTarj.Text = "xxxx-xxxx-xxxx-xxxx";
            textBoxNumTarj.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(203, 46);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(210, 27);
            textBoxNom.TabIndex = 1;
            textBoxNom.Text = "Nombre";
            textBoxNom.TextAlign = HorizontalAlignment.Center;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form7";
            Text = "Form7";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonPagar;
        private TextBox textBoxPin;
        private Label label4;
        private TextBox textBoxAnio;
        private TextBox textBoxMes;
        private TextBox textBoxNumTarj;
        private TextBox textBoxNom;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}