namespace Congreso_Final
{
    partial class frmRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistros));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnPerCon = new System.Windows.Forms.Button();
            this.btnPerMod = new System.Windows.Forms.Button();
            this.btnPerBaja = new System.Windows.Forms.Button();
            this.btnPerAlta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarA = new System.Windows.Forms.Button();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.txtIdA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrPosicion = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrPosicion)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "android-close.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "1600.png");
            this.imageList2.Images.SetKeyName(1, "android-close.png");
            this.imageList2.Images.SetKeyName(2, "delete1600.png");
            this.imageList2.Images.SetKeyName(3, "img_359924.png");
            this.imageList2.Images.SetKeyName(4, "kripto-clear-b.png");
            this.imageList2.Images.SetKeyName(5, "Very-Basic-Search-icon.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnPerCon);
            this.panel1.Controls.Add(this.btnPerMod);
            this.panel1.Controls.Add(this.btnPerBaja);
            this.panel1.Controls.Add(this.btnPerAlta);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 291);
            this.panel1.TabIndex = 22;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageIndex = 1;
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
            // btnPerCon
            // 
            this.btnPerCon.FlatAppearance.BorderSize = 0;
            this.btnPerCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerCon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerCon.ImageKey = "Very-Basic-Search-icon.png";
            this.btnPerCon.ImageList = this.imageList2;
            this.btnPerCon.Location = new System.Drawing.Point(3, 171);
            this.btnPerCon.Name = "btnPerCon";
            this.btnPerCon.Size = new System.Drawing.Size(148, 50);
            this.btnPerCon.TabIndex = 8;
            this.btnPerCon.Text = "Consultar   ";
            this.btnPerCon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerCon.UseVisualStyleBackColor = true;
            this.btnPerCon.Click += new System.EventHandler(this.btnPerCon_Click_1);
            // 
            // btnPerMod
            // 
            this.btnPerMod.FlatAppearance.BorderSize = 0;
            this.btnPerMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerMod.ImageKey = "img_359924.png";
            this.btnPerMod.ImageList = this.imageList2;
            this.btnPerMod.Location = new System.Drawing.Point(3, 115);
            this.btnPerMod.Name = "btnPerMod";
            this.btnPerMod.Size = new System.Drawing.Size(148, 50);
            this.btnPerMod.TabIndex = 7;
            this.btnPerMod.Text = "Modificar   ";
            this.btnPerMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerMod.UseVisualStyleBackColor = true;
            this.btnPerMod.Click += new System.EventHandler(this.btnPerMod_Click_1);
            // 
            // btnPerBaja
            // 
            this.btnPerBaja.FlatAppearance.BorderSize = 0;
            this.btnPerBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerBaja.ImageKey = "delete1600.png";
            this.btnPerBaja.ImageList = this.imageList2;
            this.btnPerBaja.Location = new System.Drawing.Point(3, 59);
            this.btnPerBaja.Name = "btnPerBaja";
            this.btnPerBaja.Size = new System.Drawing.Size(148, 50);
            this.btnPerBaja.TabIndex = 6;
            this.btnPerBaja.Text = "Borrar     ";
            this.btnPerBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerBaja.UseVisualStyleBackColor = true;
            this.btnPerBaja.Click += new System.EventHandler(this.btnPerBaja_Click_1);
            // 
            // btnPerAlta
            // 
            this.btnPerAlta.FlatAppearance.BorderSize = 0;
            this.btnPerAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerAlta.ImageIndex = 0;
            this.btnPerAlta.ImageList = this.imageList2;
            this.btnPerAlta.Location = new System.Drawing.Point(3, 3);
            this.btnPerAlta.Name = "btnPerAlta";
            this.btnPerAlta.Size = new System.Drawing.Size(148, 50);
            this.btnPerAlta.TabIndex = 5;
            this.btnPerAlta.Text = "Agregar   ";
            this.btnPerAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerAlta.UseVisualStyleBackColor = true;
            this.btnPerAlta.Click += new System.EventHandler(this.btnPerAlta_Click_1);
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
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registros";
            // 
            // btnLimpiarA
            // 
            this.btnLimpiarA.FlatAppearance.BorderSize = 0;
            this.btnLimpiarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarA.ImageIndex = 4;
            this.btnLimpiarA.ImageList = this.imageList2;
            this.btnLimpiarA.Location = new System.Drawing.Point(19, 82);
            this.btnLimpiarA.Name = "btnLimpiarA";
            this.btnLimpiarA.Size = new System.Drawing.Size(148, 50);
            this.btnLimpiarA.TabIndex = 14;
            this.btnLimpiarA.Text = "Limpiar    ";
            this.btnLimpiarA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarA.UseVisualStyleBackColor = true;
            // 
            // txtNombreA
            // 
            this.txtNombreA.Location = new System.Drawing.Point(108, 56);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(203, 20);
            this.txtNombreA.TabIndex = 13;
            // 
            // txtIdA
            // 
            this.txtIdA.Location = new System.Drawing.Point(99, 19);
            this.txtIdA.Name = "txtIdA";
            this.txtIdA.Size = new System.Drawing.Size(50, 20);
            this.txtIdA.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de registro";
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
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_2);
            // 
            // frmRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(546, 313);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistros";
            this.Load += new System.EventHandler(this.frmRegistros_Load_1);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrPosicion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnPerCon;
        private System.Windows.Forms.Button btnPerMod;
        private System.Windows.Forms.Button btnPerBaja;
        private System.Windows.Forms.Button btnPerAlta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiarA;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.TextBox txtIdA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrPosicion;
        private System.Windows.Forms.Button btnCerrar;
    }
}