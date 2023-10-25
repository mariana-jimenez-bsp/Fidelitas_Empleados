
namespace ActualizadorDePrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.dgvListaPrecio = new System.Windows.Forms.DataGridView();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.backgroundWorkerProc = new System.ComponentModel.BackgroundWorker();
            this.pbProcesar = new System.Windows.Forms.ProgressBar();
            this.lblRuta = new System.Windows.Forms.Label();
            this.cmbEsquemas = new System.Windows.Forms.ComboBox();
            this.lblEsquema = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnAbrir
            // 
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
            this.btnAbrir.Location = new System.Drawing.Point(673, 44);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(62, 32);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvListaPrecio
            // 
            this.dgvListaPrecio.AllowUserToAddRows = false;
            this.dgvListaPrecio.AllowUserToDeleteRows = false;
            this.dgvListaPrecio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaPrecio.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListaPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPrecio.Location = new System.Drawing.Point(32, 92);
            this.dgvListaPrecio.Name = "dgvListaPrecio";
            this.dgvListaPrecio.ReadOnly = true;
            this.dgvListaPrecio.Size = new System.Drawing.Size(721, 294);
            this.dgvListaPrecio.TabIndex = 1;
            // 
            // txtRuta
            // 
            this.txtRuta.Enabled = false;
            this.txtRuta.Location = new System.Drawing.Point(466, 12);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(22, 20);
            this.txtRuta.TabIndex = 2;
            this.txtRuta.Visible = false;
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProcesar.Location = new System.Drawing.Point(358, 405);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 30);
            this.btnProcesar.TabIndex = 3;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.txtProcesar_Click);
            // 
            // backgroundWorkerProc
            // 
            this.backgroundWorkerProc.WorkerReportsProgress = true;
            this.backgroundWorkerProc.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerProc_DoWork);
            this.backgroundWorkerProc.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerProc_ProgressChanged);
            this.backgroundWorkerProc.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerProc_RunWorkerCompleted);
            // 
            // pbProcesar
            // 
            this.pbProcesar.Location = new System.Drawing.Point(264, 441);
            this.pbProcesar.Name = "pbProcesar";
            this.pbProcesar.Size = new System.Drawing.Size(255, 23);
            this.pbProcesar.TabIndex = 4;
            this.pbProcesar.Visible = false;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblRuta.Location = new System.Drawing.Point(30, 389);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRuta.Size = new System.Drawing.Size(16, 13);
            this.lblRuta.TabIndex = 5;
            this.lblRuta.Text = "...";
            this.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRuta.Visible = false;
            // 
            // cmbEsquemas
            // 
            this.cmbEsquemas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbEsquemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEsquemas.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbEsquemas.FormattingEnabled = true;
            this.cmbEsquemas.Location = new System.Drawing.Point(103, 51);
            this.cmbEsquemas.Name = "cmbEsquemas";
            this.cmbEsquemas.Size = new System.Drawing.Size(168, 21);
            this.cmbEsquemas.TabIndex = 6;
            this.cmbEsquemas.SelectedValueChanged += new System.EventHandler(this.cmbEsquemas_SelectedValueChanged);
            // 
            // lblEsquema
            // 
            this.lblEsquema.AutoSize = true;
            this.lblEsquema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsquema.Location = new System.Drawing.Point(29, 54);
            this.lblEsquema.Name = "lblEsquema";
            this.lblEsquema.Size = new System.Drawing.Size(68, 13);
            this.lblEsquema.TabIndex = 7;
            this.lblEsquema.Text = "Esquemas:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 495);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.SteelBlue;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 482);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(789, 75);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Bitacora";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(789, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEsquema);
            this.Controls.Add(this.cmbEsquemas);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.pbProcesar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.dgvListaPrecio);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.splitter1);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAbrir;
        public System.Windows.Forms.DataGridView dgvListaPrecio;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnProcesar;
        private System.ComponentModel.BackgroundWorker backgroundWorkerProc;
        private System.Windows.Forms.ProgressBar pbProcesar;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.ComboBox cmbEsquemas;
        private System.Windows.Forms.Label lblEsquema;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button1;
    }
}

