namespace FalsaPosicionFORM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txterror = new System.Windows.Forms.TextBox();
            this.txtiter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtxr = new System.Windows.Forms.TextBox();
            this.TABLADATOS = new System.Windows.Forms.DataGridView();
            this.Tablaxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaxl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaxu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablaFxl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablaFxu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tablaxr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaerror = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TABLADATOS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Limite Inferior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Limite Superior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Criterio de error";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(125, 54);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(141, 20);
            this.txta.TabIndex = 4;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(125, 114);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(141, 20);
            this.txtb.TabIndex = 5;
            // 
            // txterror
            // 
            this.txterror.Location = new System.Drawing.Point(384, 51);
            this.txterror.Name = "txterror";
            this.txterror.Size = new System.Drawing.Size(141, 20);
            this.txterror.TabIndex = 6;
            // 
            // txtiter
            // 
            this.txtiter.Location = new System.Drawing.Point(388, 111);
            this.txtiter.Name = "txtiter";
            this.txtiter.Size = new System.Drawing.Size(141, 20);
            this.txtiter.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Iteraciones Máx.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resultado";
            // 
            // txtxr
            // 
            this.txtxr.Location = new System.Drawing.Point(619, 76);
            this.txtxr.Name = "txtxr";
            this.txtxr.Size = new System.Drawing.Size(141, 20);
            this.txtxr.TabIndex = 10;
            // 
            // TABLADATOS
            // 
            this.TABLADATOS.AllowUserToAddRows = false;
            this.TABLADATOS.AllowUserToDeleteRows = false;
            this.TABLADATOS.AllowUserToResizeColumns = false;
            this.TABLADATOS.AllowUserToResizeRows = false;
            this.TABLADATOS.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.TABLADATOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TABLADATOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TABLADATOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLADATOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tablaxi,
            this.tablaxl,
            this.tablaxu,
            this.TablaFxl,
            this.TablaFxu,
            this.Tablaxr,
            this.tablaerror});
            this.TABLADATOS.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.TABLADATOS.Location = new System.Drawing.Point(12, 160);
            this.TABLADATOS.Name = "TABLADATOS";
            this.TABLADATOS.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.TABLADATOS.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TABLADATOS.Size = new System.Drawing.Size(799, 318);
            this.TABLADATOS.TabIndex = 16;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Falsa Posición = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "y = x^2-2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 480);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TABLADATOS);
            this.Controls.Add(this.txtxr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtiter);
            this.Controls.Add(this.txterror);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "KUMUL UC EDGAR IVÁN";
            ((System.ComponentModel.ISupportInitialize)(this.TABLADATOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txterror;
        private System.Windows.Forms.TextBox txtiter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtxr;
        private System.Windows.Forms.DataGridView TABLADATOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tablaxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablaxl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablaxu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TablaFxl;
        private System.Windows.Forms.DataGridViewTextBoxColumn TablaFxu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tablaxr;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablaerror;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

