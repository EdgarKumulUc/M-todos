namespace Biseccion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txterror = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtiter = new System.Windows.Forms.TextBox();
            this.lbliteraciones = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtxr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TABLADATOS = new System.Windows.Forms.DataGridView();
            this.Tablaxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaxl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaxu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablaFxl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablaFxu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tablaxr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaerror = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TABLADATOS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Método de Bisección";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(12, 84);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(80, 13);
            this.lbla.TabIndex = 1;
            this.lbla.Text = "Límite Inferior =";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(4, 116);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(87, 13);
            this.lblb.TabIndex = 2;
            this.lblb.Text = "Límite Superior =";
            // 
            // txta
            // 
            this.txta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txta.Location = new System.Drawing.Point(92, 82);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 3;
            // 
            // txtb
            // 
            this.txtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb.Location = new System.Drawing.Point(92, 112);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 4;
            // 
            // txterror
            // 
            this.txterror.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txterror.Location = new System.Drawing.Point(310, 85);
            this.txterror.Name = "txterror";
            this.txterror.Size = new System.Drawing.Size(100, 20);
            this.txterror.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Criterio Error";
            // 
            // txtiter
            // 
            this.txtiter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiter.Location = new System.Drawing.Point(310, 111);
            this.txtiter.Name = "txtiter";
            this.txtiter.Size = new System.Drawing.Size(100, 20);
            this.txtiter.TabIndex = 8;
            // 
            // lbliteraciones
            // 
            this.lbliteraciones.AutoSize = true;
            this.lbliteraciones.Location = new System.Drawing.Point(202, 114);
            this.lbliteraciones.Name = "lbliteraciones";
            this.lbliteraciones.Size = new System.Drawing.Size(100, 13);
            this.lbliteraciones.TabIndex = 7;
            this.lbliteraciones.Text = "Límite Iteraciones =";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtxr
            // 
            this.txtxr.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtxr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtxr.Enabled = false;
            this.txtxr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxr.Location = new System.Drawing.Point(642, 80);
            this.txtxr.Name = "txtxr";
            this.txtxr.Size = new System.Drawing.Size(137, 13);
            this.txtxr.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Raíz = ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Borrar todo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "f(x)=x^3+4x^2-10";
            // 
            // TABLADATOS
            // 
            this.TABLADATOS.AllowUserToAddRows = false;
            this.TABLADATOS.AllowUserToDeleteRows = false;
            this.TABLADATOS.AllowUserToResizeColumns = false;
            this.TABLADATOS.AllowUserToResizeRows = false;
            this.TABLADATOS.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.TABLADATOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TABLADATOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.TABLADATOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLADATOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tablaxi,
            this.tablaxl,
            this.tablaxu,
            this.TablaFxl,
            this.TablaFxu,
            this.Tablaxr,
            this.tablaerror});
            this.TABLADATOS.EnableHeadersVisualStyles = false;
            this.TABLADATOS.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.TABLADATOS.Location = new System.Drawing.Point(7, 140);
            this.TABLADATOS.Name = "TABLADATOS";
            this.TABLADATOS.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Red;
            this.TABLADATOS.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.TABLADATOS.Size = new System.Drawing.Size(799, 318);
            this.TABLADATOS.TabIndex = 15;
            // 
            // Tablaxi
            // 
            this.Tablaxi.HeaderText = "i";
            this.Tablaxi.Name = "Tablaxi";
            this.Tablaxi.ReadOnly = true;
            this.Tablaxi.Width = 30;
            // 
            // tablaxl
            // 
            this.tablaxl.HeaderText = "xl";
            this.tablaxl.Name = "tablaxl";
            this.tablaxl.ReadOnly = true;
            this.tablaxl.Width = 120;
            // 
            // tablaxu
            // 
            this.tablaxu.HeaderText = "xu";
            this.tablaxu.Name = "tablaxu";
            this.tablaxu.ReadOnly = true;
            this.tablaxu.Width = 120;
            // 
            // TablaFxl
            // 
            this.TablaFxl.HeaderText = "f(xl)";
            this.TablaFxl.Name = "TablaFxl";
            this.TablaFxl.ReadOnly = true;
            this.TablaFxl.Width = 120;
            // 
            // TablaFxu
            // 
            this.TablaFxu.HeaderText = "F(xu)";
            this.TablaFxu.Name = "TablaFxu";
            this.TablaFxu.ReadOnly = true;
            this.TablaFxu.Width = 120;
            // 
            // Tablaxr
            // 
            this.Tablaxr.HeaderText = "f(x)";
            this.Tablaxr.Name = "Tablaxr";
            this.Tablaxr.ReadOnly = true;
            this.Tablaxr.Width = 120;
            // 
            // tablaerror
            // 
            this.tablaerror.HeaderText = "Error";
            this.tablaerror.Name = "tablaerror";
            this.tablaerror.ReadOnly = true;
            this.tablaerror.Width = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "KUMUL UC EDGAR IVÁN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(823, 470);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TABLADATOS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtxr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtiter);
            this.Controls.Add(this.lbliteraciones);
            this.Controls.Add(this.txterror);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Biseección - Métodos Numéricos - KUMUL UC EDGAR IVÁN";
            ((System.ComponentModel.ISupportInitialize)(this.TABLADATOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txterror;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtiter;
        private System.Windows.Forms.Label lbliteraciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtxr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView TABLADATOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tablaxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablaxl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablaxu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TablaFxl;
        private System.Windows.Forms.DataGridViewTextBoxColumn TablaFxu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tablaxr;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablaerror;
        private System.Windows.Forms.Label label5;
    }
}

