namespace frmPrincipal
{
    partial class frmPrincipal
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
            this.btnNombre = new System.Windows.Forms.Button();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtNombres2 = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudId_servi = new System.Windows.Forms.NumericUpDown();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudId_servi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNombre
            // 
            this.btnNombre.Location = new System.Drawing.Point(196, 12);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(368, 39);
            this.btnNombre.TabIndex = 0;
            this.btnNombre.Text = "Mostrar informacion";
            this.btnNombre.UseVisualStyleBackColor = true;
            this.btnNombre.Click += new System.EventHandler(this.btnNombre_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(6, 35);
            this.txtNombres.Multiline = true;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(732, 241);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // txtNombres2
            // 
            this.txtNombres2.Location = new System.Drawing.Point(7, 76);
            this.txtNombres2.Multiline = true;
            this.txtNombres2.Name = "txtNombres2";
            this.txtNombres2.ReadOnly = true;
            this.txtNombres2.Size = new System.Drawing.Size(718, 119);
            this.txtNombres2.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(494, 26);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(153, 29);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Mostrar informacion";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(29, 332);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(108, 35);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Id Hotel: ";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNombre);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 282);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudId_servi);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.btnFiltrar);
            this.groupBox2.Controls.Add(this.txtNombres2);
            this.groupBox2.Location = new System.Drawing.Point(22, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 223);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // nudId_servi
            // 
            this.nudId_servi.Location = new System.Drawing.Point(94, 31);
            this.nudId_servi.Maximum = new decimal(new int[] {9, 0, 0, 0});
            this.nudId_servi.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudId_servi.Name = "nudId_servi";
            this.nudId_servi.Size = new System.Drawing.Size(114, 22);
            this.nudId_servi.TabIndex = 7;
            this.nudId_servi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudId_servi.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(26, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 31);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "id Hotel";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudId_servi)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown nudId_servi;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label lblName;

        private System.Windows.Forms.TextBox txtNombres2;
        private System.Windows.Forms.Button btnFiltrar;

        private System.Windows.Forms.TextBox txtNombres;

        private System.Windows.Forms.Button btnNombre;

        #endregion
    }
}