namespace Congreso_Final
{
    partial class frmCapitulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapitulos));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgrCapitulos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.txtPresidente = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.cmbOrganizacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha_c = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtNombreCap = new System.Windows.Forms.TextBox();
            this.txtIdCap = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnPerCon = new System.Windows.Forms.Button();
            this.btnPerMod = new System.Windows.Forms.Button();
            this.btnPerBaja = new System.Windows.Forms.Button();
            this.btnPerAlta = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrCapitulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ImageIndex = 0;
            this.btnCerrar.Location = new System.Drawing.Point(731, -48);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 32);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox2.Controls.Add(this.dtgrCapitulos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 260);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda general";
            // 
            // dtgrCapitulos
            // 
            this.dtgrCapitulos.AllowUserToAddRows = false;
            this.dtgrCapitulos.AllowUserToDeleteRows = false;
            this.dtgrCapitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrCapitulos.Location = new System.Drawing.Point(6, 19);
            this.dtgrCapitulos.Name = "dtgrCapitulos";
            this.dtgrCapitulos.ReadOnly = true;
            this.dtgrCapitulos.Size = new System.Drawing.Size(665, 227);
            this.dtgrCapitulos.TabIndex = 1;
            this.dtgrCapitulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrCapitulos_CellDoubleClick);
            this.dtgrCapitulos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgrCapitulos_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.txtEncargado);
            this.groupBox1.Controls.Add(this.txtPresidente);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.cmbOrganizacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFecha_c);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtComentario);
            this.groupBox1.Controls.Add(this.txtNombreCap);
            this.groupBox1.Controls.Add(this.txtIdCap);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(173, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 266);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del Capitulo";
            // 
            // txtEncargado
            // 
            this.txtEncargado.Location = new System.Drawing.Point(97, 136);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(219, 21);
            this.txtEncargado.TabIndex = 35;
            this.txtEncargado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEncargado_KeyPress);
            // 
            // txtPresidente
            // 
            this.txtPresidente.Location = new System.Drawing.Point(97, 107);
            this.txtPresidente.Name = "txtPresidente";
            this.txtPresidente.Size = new System.Drawing.Size(219, 21);
            this.txtPresidente.TabIndex = 34;
            this.txtPresidente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPresidente_KeyPress);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.ImageIndex = 4;
            this.btnLimpiar.ImageList = this.imageList2;
            this.btnLimpiar.Location = new System.Drawing.Point(329, 211);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(148, 49);
            this.btnLimpiar.TabIndex = 33;
            this.btnLimpiar.Text = "Limpiar    ";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.imageList2.Images.SetKeyName(6, "51372.png");
            // 
            // cmbOrganizacion
            // 
            this.cmbOrganizacion.FormattingEnabled = true;
            this.cmbOrganizacion.Location = new System.Drawing.Point(105, 78);
            this.cmbOrganizacion.Name = "cmbOrganizacion";
            this.cmbOrganizacion.Size = new System.Drawing.Size(211, 23);
            this.cmbOrganizacion.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Creado";
            // 
            // dtpFecha_c
            // 
            this.dtpFecha_c.Enabled = false;
            this.dtpFecha_c.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_c.Location = new System.Drawing.Point(97, 226);
            this.dtpFecha_c.Name = "dtpFecha_c";
            this.dtpFecha_c.Size = new System.Drawing.Size(184, 21);
            this.dtpFecha_c.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Comentarios";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Presidente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Encargado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Organizacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // txtComentario
            // 
            this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComentario.Location = new System.Drawing.Point(97, 163);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(219, 57);
            this.txtComentario.TabIndex = 9;
            // 
            // txtNombreCap
            // 
            this.txtNombreCap.Location = new System.Drawing.Point(97, 52);
            this.txtNombreCap.Name = "txtNombreCap";
            this.txtNombreCap.Size = new System.Drawing.Size(219, 21);
            this.txtNombreCap.TabIndex = 1;
            this.txtNombreCap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCap_KeyPress);
            // 
            // txtIdCap
            // 
            this.txtIdCap.Location = new System.Drawing.Point(97, 28);
            this.txtIdCap.Name = "txtIdCap";
            this.txtIdCap.Size = new System.Drawing.Size(50, 21);
            this.txtIdCap.TabIndex = 0;
            this.txtIdCap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCap_KeyPress);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "android-close.png");
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageIndex = 0;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(662, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 31);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnPerCon);
            this.panel1.Controls.Add(this.btnPerMod);
            this.panel1.Controls.Add(this.btnPerBaja);
            this.panel1.Controls.Add(this.btnPerAlta);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 266);
            this.panel1.TabIndex = 13;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageIndex = 1;
            this.button6.ImageList = this.imageList2;
            this.button6.Location = new System.Drawing.Point(4, 213);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 50);
            this.button6.TabIndex = 12;
            this.button6.Text = "Cerrar      ";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnPerCon
            // 
            this.btnPerCon.FlatAppearance.BorderSize = 0;
            this.btnPerCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerCon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerCon.ImageKey = "Very-Basic-Search-icon.png";
            this.btnPerCon.ImageList = this.imageList2;
            this.btnPerCon.Location = new System.Drawing.Point(4, 160);
            this.btnPerCon.Name = "btnPerCon";
            this.btnPerCon.Size = new System.Drawing.Size(148, 50);
            this.btnPerCon.TabIndex = 11;
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
            this.btnPerMod.Location = new System.Drawing.Point(4, 107);
            this.btnPerMod.Name = "btnPerMod";
            this.btnPerMod.Size = new System.Drawing.Size(148, 50);
            this.btnPerMod.TabIndex = 10;
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
            this.btnPerBaja.Location = new System.Drawing.Point(4, 55);
            this.btnPerBaja.Name = "btnPerBaja";
            this.btnPerBaja.Size = new System.Drawing.Size(148, 50);
            this.btnPerBaja.TabIndex = 9;
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
            this.btnPerAlta.TabIndex = 7;
            this.btnPerAlta.Text = "Agregar   ";
            this.btnPerAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerAlta.UseVisualStyleBackColor = true;
            this.btnPerAlta.Click += new System.EventHandler(this.btnPerAlta_Click);
            // 
            // frmCapitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(704, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCapitulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCapitulos";
            this.Load += new System.EventHandler(this.frmCapitulos_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrCapitulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgrCapitulos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha_c;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtNombreCap;
        private System.Windows.Forms.TextBox txtIdCap;
        private System.Windows.Forms.ComboBox cmbOrganizacion;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnPerCon;
        private System.Windows.Forms.Button btnPerMod;
        private System.Windows.Forms.Button btnPerBaja;
        private System.Windows.Forms.Button btnPerAlta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.TextBox txtPresidente;
    }
}