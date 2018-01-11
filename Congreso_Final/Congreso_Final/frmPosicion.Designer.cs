namespace Congreso_Final
{
    partial class frmPosicion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosicion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarA = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.txtIdA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrPosicion = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnPosCon = new System.Windows.Forms.Button();
            this.btnPosMod = new System.Windows.Forms.Button();
            this.btnPosBaja = new System.Windows.Forms.Button();
            this.btnPosAlta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrPosicion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.btnLimpiarA);
            this.groupBox1.Controls.Add(this.txtNombreA);
            this.groupBox1.Controls.Add(this.txtIdA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtgrPosicion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(175, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 291);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posiciones";
            // 
            // btnLimpiarA
            // 
            this.btnLimpiarA.FlatAppearance.BorderSize = 0;
            this.btnLimpiarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarA.ImageIndex = 3;
            this.btnLimpiarA.ImageList = this.imageList2;
            this.btnLimpiarA.Location = new System.Drawing.Point(19, 82);
            this.btnLimpiarA.Name = "btnLimpiarA";
            this.btnLimpiarA.Size = new System.Drawing.Size(148, 50);
            this.btnLimpiarA.TabIndex = 14;
            this.btnLimpiarA.Text = "Limpiar    ";
            this.btnLimpiarA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarA.UseVisualStyleBackColor = true;
            this.btnLimpiarA.Click += new System.EventHandler(this.btnLimpiarA_Click_1);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "1600.png");
            this.imageList2.Images.SetKeyName(1, "delete1600.png");
            this.imageList2.Images.SetKeyName(2, "img_359924.png");
            this.imageList2.Images.SetKeyName(3, "kripto-clear-b.png");
            this.imageList2.Images.SetKeyName(4, "Very-Basic-Search-icon.png");
            this.imageList2.Images.SetKeyName(5, "android-close.png");
            // 
            // txtNombreA
            // 
            this.txtNombreA.Location = new System.Drawing.Point(99, 56);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(212, 20);
            this.txtNombreA.TabIndex = 13;
            this.txtNombreA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreA_KeyPress);
            // 
            // txtIdA
            // 
            this.txtIdA.Location = new System.Drawing.Point(99, 19);
            this.txtIdA.Name = "txtIdA";
            this.txtIdA.Size = new System.Drawing.Size(50, 20);
            this.txtIdA.TabIndex = 12;
            this.txtIdA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdA_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Posicion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Posicion";
            // 
            // dtgrPosicion
            // 
            this.dtgrPosicion.AllowUserToAddRows = false;
            this.dtgrPosicion.AllowUserToDeleteRows = false;
            this.dtgrPosicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrPosicion.Location = new System.Drawing.Point(6, 138);
            this.dtgrPosicion.Name = "dtgrPosicion";
            this.dtgrPosicion.ReadOnly = true;
            this.dtgrPosicion.Size = new System.Drawing.Size(305, 139);
            this.dtgrPosicion.TabIndex = 0;
            this.dtgrPosicion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrPosicion_CellDoubleClick_1);
            this.dtgrPosicion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgrPosicion_KeyDown_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "android-close.png");
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ImageIndex = 0;
            this.btnCerrar.ImageList = this.imageList1;
            this.btnCerrar.Location = new System.Drawing.Point(497, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 32);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnPosCon);
            this.panel1.Controls.Add(this.btnPosMod);
            this.panel1.Controls.Add(this.btnPosBaja);
            this.panel1.Controls.Add(this.btnPosAlta);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 291);
            this.panel1.TabIndex = 20;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageIndex = 5;
            this.button6.ImageList = this.imageList2;
            this.button6.Location = new System.Drawing.Point(3, 227);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 50);
            this.button6.TabIndex = 10;
            this.button6.Text = "Cerrar      ";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // btnPosCon
            // 
            this.btnPosCon.FlatAppearance.BorderSize = 0;
            this.btnPosCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosCon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosCon.ImageKey = "Very-Basic-Search-icon.png";
            this.btnPosCon.ImageList = this.imageList2;
            this.btnPosCon.Location = new System.Drawing.Point(3, 171);
            this.btnPosCon.Name = "btnPosCon";
            this.btnPosCon.Size = new System.Drawing.Size(148, 50);
            this.btnPosCon.TabIndex = 8;
            this.btnPosCon.Text = "Consultar   ";
            this.btnPosCon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPosCon.UseVisualStyleBackColor = true;
            this.btnPosCon.Click += new System.EventHandler(this.btnPosCon_Click);
            // 
            // btnPosMod
            // 
            this.btnPosMod.FlatAppearance.BorderSize = 0;
            this.btnPosMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosMod.ImageKey = "img_359924.png";
            this.btnPosMod.ImageList = this.imageList2;
            this.btnPosMod.Location = new System.Drawing.Point(3, 115);
            this.btnPosMod.Name = "btnPosMod";
            this.btnPosMod.Size = new System.Drawing.Size(148, 50);
            this.btnPosMod.TabIndex = 7;
            this.btnPosMod.Text = "Modificar   ";
            this.btnPosMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPosMod.UseVisualStyleBackColor = true;
            this.btnPosMod.Click += new System.EventHandler(this.btnPosMod_Click);
            // 
            // btnPosBaja
            // 
            this.btnPosBaja.FlatAppearance.BorderSize = 0;
            this.btnPosBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosBaja.ImageKey = "delete1600.png";
            this.btnPosBaja.ImageList = this.imageList2;
            this.btnPosBaja.Location = new System.Drawing.Point(3, 59);
            this.btnPosBaja.Name = "btnPosBaja";
            this.btnPosBaja.Size = new System.Drawing.Size(148, 50);
            this.btnPosBaja.TabIndex = 6;
            this.btnPosBaja.Text = "Borrar     ";
            this.btnPosBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPosBaja.UseVisualStyleBackColor = true;
            this.btnPosBaja.Click += new System.EventHandler(this.btnPosBaja_Click_1);
            // 
            // btnPosAlta
            // 
            this.btnPosAlta.FlatAppearance.BorderSize = 0;
            this.btnPosAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosAlta.ImageIndex = 0;
            this.btnPosAlta.ImageList = this.imageList2;
            this.btnPosAlta.Location = new System.Drawing.Point(3, 3);
            this.btnPosAlta.Name = "btnPosAlta";
            this.btnPosAlta.Size = new System.Drawing.Size(148, 50);
            this.btnPosAlta.TabIndex = 5;
            this.btnPosAlta.Text = "Agregar   ";
            this.btnPosAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPosAlta.UseVisualStyleBackColor = true;
            this.btnPosAlta.Click += new System.EventHandler(this.btnPosAlta_Click);
            // 
            // frmPosicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(545, 313);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPosicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPosicion";
            this.Load += new System.EventHandler(this.frmPosicion_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrPosicion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.TextBox txtIdA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrPosicion;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnPosCon;
        private System.Windows.Forms.Button btnPosMod;
        private System.Windows.Forms.Button btnPosBaja;
        private System.Windows.Forms.Button btnPosAlta;
        private System.Windows.Forms.Button btnLimpiarA;
    }
}