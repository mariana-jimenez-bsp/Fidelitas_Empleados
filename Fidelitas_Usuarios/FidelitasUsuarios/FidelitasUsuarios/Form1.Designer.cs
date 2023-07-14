
namespace FidelitasUsuarios
{
    partial class Form1
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
            this.btnSchema = new System.Windows.Forms.Label();
            this.cbxSchema = new System.Windows.Forms.ComboBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblRute = new System.Windows.Forms.Label();
            this.lblRoute = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSchema
            // 
            this.btnSchema.AutoSize = true;
            this.btnSchema.Location = new System.Drawing.Point(55, 46);
            this.btnSchema.Name = "btnSchema";
            this.btnSchema.Size = new System.Drawing.Size(51, 13);
            this.btnSchema.TabIndex = 0;
            this.btnSchema.Text = "Esquema";
            // 
            // cbxSchema
            // 
            this.cbxSchema.FormattingEnabled = true;
            this.cbxSchema.Location = new System.Drawing.Point(182, 43);
            this.cbxSchema.Name = "cbxSchema";
            this.cbxSchema.Size = new System.Drawing.Size(121, 21);
            this.cbxSchema.TabIndex = 1;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(38, 153);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(703, 202);
            this.dgvEmployee.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(637, 36);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Excel";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lblRute
            // 
            this.lblRute.AutoSize = true;
            this.lblRute.Location = new System.Drawing.Point(70, 356);
            this.lblRute.Name = "lblRute";
            this.lblRute.Size = new System.Drawing.Size(0, 13);
            this.lblRute.TabIndex = 4;
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Location = new System.Drawing.Point(55, 369);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(35, 13);
            this.lblRoute.TabIndex = 5;
            this.lblRoute.Text = "label1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.lblRute);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.cbxSchema);
            this.Controls.Add(this.btnSchema);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnSchema;
        private System.Windows.Forms.ComboBox cbxSchema;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblRute;
        private System.Windows.Forms.Label lblRoute;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

