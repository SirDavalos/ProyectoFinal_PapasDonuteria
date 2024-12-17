namespace ProyectoFinal_PapasDonuteria
{
    partial class Form2
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
            buttonInicio = new Button();
            textBoxUsuario = new TextBox();
            SuspendLayout();
            // 
            // buttonInicio
            // 
            buttonInicio.Location = new Point(348, 387);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(125, 30);
            buttonInicio.TabIndex = 0;
            buttonInicio.Text = "Iniciar Sesion";
            buttonInicio.UseVisualStyleBackColor = true;
            buttonInicio.Click += buttonInicio_Click;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(293, 271);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Usuario";
            textBoxUsuario.Size = new Size(250, 23);
            textBoxUsuario.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxUsuario);
            Controls.Add(buttonInicio);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonInicio;
        private TextBox textBoxUsuario;
    }
}