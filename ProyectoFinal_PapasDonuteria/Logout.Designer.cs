namespace ProyectoFinal_PapasDonuteria
{
    partial class Logout
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
            buttonSi = new Button();
            buttonNo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 18);
            label1.Name = "label1";
            label1.Size = new Size(211, 52);
            label1.TabIndex = 0;
            label1.Text = "¿Seguro que quiere\r\ncerrar sesion?";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonSi
            // 
            buttonSi.Location = new Point(41, 118);
            buttonSi.Name = "buttonSi";
            buttonSi.Size = new Size(109, 32);
            buttonSi.TabIndex = 1;
            buttonSi.Text = "Si";
            buttonSi.UseVisualStyleBackColor = true;
            buttonSi.Click += buttonSi_Click;
            // 
            // buttonNo
            // 
            buttonNo.Location = new Point(221, 118);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(109, 32);
            buttonNo.TabIndex = 2;
            buttonNo.Text = "No";
            buttonNo.UseVisualStyleBackColor = true;
            buttonNo.Click += buttonNo_Click;
            // 
            // Logout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 177);
            Controls.Add(buttonNo);
            Controls.Add(buttonSi);
            Controls.Add(label1);
            Name = "Logout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Logout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonSi;
        private Button buttonNo;
    }
}