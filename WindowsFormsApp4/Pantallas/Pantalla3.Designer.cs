﻿namespace WindowsFormsApp4
{
    partial class Pantalla3
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtGV1 = new System.Windows.Forms.DataGridView();
            this.dtGV2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGV1
            // 
            this.dtGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtGV1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGV1.ColumnHeadersHeight = 29;
            this.dtGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGV1.Location = new System.Drawing.Point(217, 101);
            this.dtGV1.Margin = new System.Windows.Forms.Padding(4);
            this.dtGV1.Name = "dtGV1";
            this.dtGV1.RowHeadersWidth = 51;
            this.dtGV1.Size = new System.Drawing.Size(910, 228);
            this.dtGV1.TabIndex = 0;
            this.dtGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV1_CellContentClick);
            // 
            // dtGV2
            // 
            this.dtGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtGV2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGV2.ColumnHeadersHeight = 29;
            this.dtGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGV2.Location = new System.Drawing.Point(217, 471);
            this.dtGV2.Margin = new System.Windows.Forms.Padding(4);
            this.dtGV2.Name = "dtGV2";
            this.dtGV2.RowHeadersWidth = 51;
            this.dtGV2.Size = new System.Drawing.Size(910, 229);
            this.dtGV2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(478, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 392);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Entrada";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(347, 392);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 22);
            this.textBox1.TabIndex = 5;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(821, 389);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 28);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "Codificar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(975, 389);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 28);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "Analizar";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn2.Enabled = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1176, 675);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pantalla3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 727);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGV2);
            this.Controls.Add(this.dtGV1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pantalla3";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pantalla3_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGV1;
        private System.Windows.Forms.DataGridView dtGV2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn2;
    }
}

