﻿namespace ProyectoFinal_PapasDonuteria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonMenu = new Button();
            SuspendLayout();
            // 
            // buttonMenu
            // 
            buttonMenu.Location = new Point(455, 464);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(133, 32);
            buttonMenu.TabIndex = 0;
            buttonMenu.Text = "Ir a Menu";
            buttonMenu.UseVisualStyleBackColor = true;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 508);
            Controls.Add(buttonMenu);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonMenu;
    }
}
