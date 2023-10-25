
namespace FidelitasUsuarios
{
    partial class Bitacora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacora));
            this.dtgBitacora = new System.Windows.Forms.DataGridView();
            this.Numero_Error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBitacora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgBitacora
            // 
            this.dtgBitacora.AllowUserToAddRows = false;
            this.dtgBitacora.AllowUserToDeleteRows = false;
            this.dtgBitacora.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_Error,
            this.Mensaje,
            this.Num_Empleado,
            this.Fecha});
            this.dtgBitacora.Location = new System.Drawing.Point(12, 66);
            this.dtgBitacora.Name = "dtgBitacora";
            this.dtgBitacora.Size = new System.Drawing.Size(765, 388);
            this.dtgBitacora.TabIndex = 0;
            // 
            // Numero_Error
            // 
            this.Numero_Error.HeaderText = "Error";
            this.Numero_Error.Name = "Numero_Error";
            // 
            // Mensaje
            // 
            this.Mensaje.HeaderText = "Mensaje";
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Width = 350;
            // 
            // Num_Empleado
            // 
            this.Num_Empleado.HeaderText = "Numero Empleado";
            this.Num_Empleado.Name = "Num_Empleado";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(702, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Atras";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 483);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.SteelBlue;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 473);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(789, 84);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(789, 557);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtgBitacora);
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            ((System.ComponentModel.ISupportInitialize)(this.dtgBitacora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Error;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Splitter splitter1;
    }
}