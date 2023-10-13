using System;

namespace PilasB
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarNodo = new System.Windows.Forms.Button();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.txtMiNodo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // btnAgregarNodo
            // 
            this.btnAgregarNodo.Location = new System.Drawing.Point(100, 71);
            this.btnAgregarNodo.Name = "btnAgregarNodo";
            this.btnAgregarNodo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarNodo.TabIndex = 2;
            this.btnAgregarNodo.Text = "Apilar";
            this.btnAgregarNodo.UseVisualStyleBackColor = true;
            this.btnAgregarNodo.Click += new System.EventHandler(this.btnAgregarNodo_Click);
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(257, 35);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(165, 251);
            this.lstPila.TabIndex = 3;
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.Location = new System.Drawing.Point(100, 121);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(75, 23);
            this.btnDesapilar.TabIndex = 4;
            this.btnDesapilar.Text = "Desapilar";
            this.btnDesapilar.UseVisualStyleBackColor = true;
            this.btnDesapilar.Click += new System.EventHandler(this.btnDesapilar_Click);
            // 
            // txtMiNodo
            // 
            this.txtMiNodo.Location = new System.Drawing.Point(87, 35);
            this.txtMiNodo.Name = "txtMiNodo";
            this.txtMiNodo.Size = new System.Drawing.Size(100, 20);
            this.txtMiNodo.TabIndex = 5;
            this.txtMiNodo.TextChanged += new System.EventHandler(this.txtMiNodo_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMiNodo);
            this.Controls.Add(this.btnDesapilar);
            this.Controls.Add(this.lstPila);
            this.Controls.Add(this.btnAgregarNodo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        





        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarNodo;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.Button btnDesapilar;
        private System.Windows.Forms.TextBox txtMiNodo;
    }
}

