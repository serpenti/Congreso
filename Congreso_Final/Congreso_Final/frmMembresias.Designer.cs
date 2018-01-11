namespace Congreso_Final
{
    partial class frmMembresias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMembresias));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnPerCon = new System.Windows.Forms.Button();
            this.btnPerMod = new System.Windows.Forms.Button();
            this.btnPerBaja = new System.Windows.Forms.Button();
            this.btnPerAlta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.txtIdA = new System.Windows.Forms.TextBox();
            this.btnLimpiarA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrArea = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrArea)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(157, 310);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageIndex = 4;
            this.button6.ImageList = this.imageList2;
            this.button6.Location = new System.Drawing.Point(3, 244);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 50);
            this.button6.TabIndex = 10;
            this.button6.Text = "Cerrar      ";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "1600.png");
            this.imageList2.Images.SetKeyName(1, "delete1600.png");
            this.imageList2.Images.SetKeyName(2, "img_359924.png");
            this.imageList2.Images.SetKeyName(3, "Very-Basic-Search-icon.png");
            this.imageList2.Images.SetKeyName(4, "android-close.png");
            this.imageList2.Images.SetKeyName(5, "kripto-clear-b.png");
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
            this.btnPerCon.Click += new System.EventHandler(this.btnPerCon_Click);
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
            this.btnPerMod.Click += new System.EventHandler(this.btnPerMod_Click);
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
            this.btnPerBaja.Click += new System.EventHandler(this.btnPerBaja_Click);
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
            this.btnPerAlta.Click += new System.EventHandler(this.btnPerAlta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCosto);
            this.groupBox1.Controls.Add(this.txtNombreA);
            this.groupBox1.Controls.Add(this.txtIdA);
            this.groupBox1.Controls.Add(this.btnLimpiarA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtgrArea);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(175, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 310);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membresias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Descuento";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(99, 122);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(111, 20);
            this.txtDescuento.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(99, 89);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(212, 20);
            this.txtCosto.TabIndex = 14;
            // 
            // txtNombreA
            // 
            this.txtNombreA.Location = new System.Drawing.Point(99, 56);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(212, 20);
            this.txtNombreA.TabIndex = 13;
            // 
            // txtIdA
            // 
            this.txtIdA.Location = new System.Drawing.Point(99, 19);
            this.txtIdA.Name = "txtIdA";
            this.txtIdA.Size = new System.Drawing.Size(50, 20);
            this.txtIdA.TabIndex = 12;
            // 
            // btnLimpiarA
            // 
            this.btnLimpiarA.FlatAppearance.BorderSize = 0;
            this.btnLimpiarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarA.ImageIndex = 5;
            this.btnLimpiarA.ImageList = this.imageList2;
            this.btnLimpiarA.Location = new System.Drawing.Point(230, 125);
            this.btnLimpiarA.Name = "btnLimpiarA";
            this.btnLimpiarA.Size = new System.Drawing.Size(148, 50);
            this.btnLimpiarA.TabIndex = 11;
            this.btnLimpiarA.Text = "Limpiar    ";
            this.btnLimpiarA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarA.UseVisualStyleBackColor = true;
            this.btnLimpiarA.Click += new System.EventHandler(this.btnLimpiarA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Membresia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Membresia";
            // 
            // dtgrArea
            // 
            this.dtgrArea.AllowUserToAddRows = false;
            this.dtgrArea.AllowUserToDeleteRows = false;
            this.dtgrArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrArea.Location = new System.Drawing.Point(6, 181);
            this.dtgrArea.Name = "dtgrArea";
            this.dtgrArea.ReadOnly = true;
            this.dtgrArea.Size = new System.Drawing.Size(372, 113);
            this.dtgrArea.TabIndex = 0;
            this.dtgrArea.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrArea_CellDoubleClick);
            this.dtgrArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgrArea_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "android-close.png");
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ImageIndex = 0;
            this.btnCerrar.ImageList = this.imageList1;
            this.btnCerrar.Location = new System.Drawing.Point(565, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 32);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // frmMembresias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(612, 336);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMembresias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArea";
            this.Load += new System.EventHandler(this.frmArea_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPerCon;
        private System.Windows.Forms.Button btnPerMod;
        private System.Windows.Forms.Button btnPerBaja;
        private System.Windows.Forms.Button btnPerAlta;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrArea;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.TextBox txtIdA;
        private System.Windows.Forms.Button btnLimpiarA;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCosto;
    }
}