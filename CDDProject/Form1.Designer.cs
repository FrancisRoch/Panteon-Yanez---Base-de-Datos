using System.Windows.Forms;

namespace CDDProject
{
    partial class mainprog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainprog));
            this.excelBtn = new System.Windows.Forms.Button();
            this.fileBtn = new System.Windows.Forms.Button();
            this.fileTxtb = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // excelBtn
            // 
            this.excelBtn.Enabled = false;
            this.excelBtn.Location = new System.Drawing.Point(209, 101);
            this.excelBtn.Name = "excelBtn";
            this.excelBtn.Size = new System.Drawing.Size(170, 56);
            this.excelBtn.TabIndex = 0;
            this.excelBtn.Text = "Convertir a Excel";
            this.excelBtn.UseVisualStyleBackColor = true;
            this.excelBtn.Click += new System.EventHandler(this.excelEvent);
            // 
            // fileBtn
            // 
            this.fileBtn.Location = new System.Drawing.Point(23, 101);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(170, 56);
            this.fileBtn.TabIndex = 1;
            this.fileBtn.Text = "Buscar Carpeta";
            this.fileBtn.UseVisualStyleBackColor = true;
            this.fileBtn.Click += new System.EventHandler(this.fileEvent);
            // 
            // fileTxtb
            // 
            this.fileTxtb.Location = new System.Drawing.Point(23, 63);
            this.fileTxtb.Name = "fileTxtb";
            this.fileTxtb.ReadOnly = true;
            this.fileTxtb.Size = new System.Drawing.Size(356, 20);
            this.fileTxtb.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(20, 30);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(359, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Busca una carpeta con archivos de texto para convertirlos a formato Excel";
            // 
            // mainprog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 190);
            this.Controls.Add(this.label);
            this.Controls.Add(this.fileTxtb);
            this.Controls.Add(this.fileBtn);
            this.Controls.Add(this.excelBtn);
            this.Name = "mainprog";
            this.Text = "CDD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button excelBtn;
        private System.Windows.Forms.Button fileBtn;
        private System.Windows.Forms.TextBox fileTxtb;
        private System.Windows.Forms.Label label;
    }
}

