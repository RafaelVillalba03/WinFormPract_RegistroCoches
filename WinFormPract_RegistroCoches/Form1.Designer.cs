namespace WinFormPract_RegistroCoches
{
    partial class Formulario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Edicion = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lblEur = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCoste = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblCoste = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grdRegistro = new System.Windows.Forms.DataGridView();
            this.Edicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // Edicion
            // 
            this.Edicion.Controls.Add(this.txtId);
            this.Edicion.Controls.Add(this.lbId);
            this.Edicion.Controls.Add(this.lblEur);
            this.Edicion.Controls.Add(this.dtFecha);
            this.Edicion.Controls.Add(this.txtCoste);
            this.Edicion.Controls.Add(this.txtMarca);
            this.Edicion.Controls.Add(this.lblCoste);
            this.Edicion.Controls.Add(this.lblFecha);
            this.Edicion.Controls.Add(this.lblMarca);
            this.Edicion.Location = new System.Drawing.Point(12, 12);
            this.Edicion.Name = "Edicion";
            this.Edicion.Size = new System.Drawing.Size(548, 192);
            this.Edicion.TabIndex = 0;
            this.Edicion.TabStop = false;
            this.Edicion.Text = "Edición";
            this.Edicion.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(446, 42);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(54, 31);
            this.txtId.TabIndex = 8;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(412, 42);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(28, 25);
            this.lbId.TabIndex = 7;
            this.lbId.Text = "Id";
            // 
            // lblEur
            // 
            this.lblEur.AutoSize = true;
            this.lblEur.Location = new System.Drawing.Point(478, 136);
            this.lblEur.Name = "lblEur";
            this.lblEur.Size = new System.Drawing.Size(22, 25);
            this.lblEur.TabIndex = 6;
            this.lblEur.Text = "€";
            this.lblEur.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(242, 86);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(258, 31);
            this.dtFecha.TabIndex = 5;
            // 
            // txtCoste
            // 
            this.txtCoste.Location = new System.Drawing.Point(244, 133);
            this.txtCoste.Name = "txtCoste";
            this.txtCoste.Size = new System.Drawing.Size(228, 31);
            this.txtCoste.TabIndex = 4;
            this.txtCoste.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCoste_KeyPress);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(244, 39);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(149, 31);
            this.txtMarca.TabIndex = 3;
            // 
            // lblCoste
            // 
            this.lblCoste.AutoSize = true;
            this.lblCoste.Location = new System.Drawing.Point(33, 133);
            this.lblCoste.Name = "lblCoste";
            this.lblCoste.Size = new System.Drawing.Size(57, 25);
            this.lblCoste.TabIndex = 2;
            this.lblCoste.Text = "Coste";
            this.lblCoste.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(33, 86);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(173, 25);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha de fabricación";
            this.lblFecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(33, 39);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(159, 25);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca del vehículo";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(12, 222);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(112, 34);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(152, 222);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 34);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(293, 222);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 34);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(666, 222);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 34);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(527, 222);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 34);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // grdRegistro
            // 
            this.grdRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRegistro.Location = new System.Drawing.Point(12, 276);
            this.grdRegistro.Name = "grdRegistro";
            this.grdRegistro.RowHeadersWidth = 62;
            this.grdRegistro.RowTemplate.Height = 33;
            this.grdRegistro.Size = new System.Drawing.Size(766, 286);
            this.grdRegistro.TabIndex = 6;
            this.grdRegistro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRegistro_CellClick);
            this.grdRegistro.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.grdRegistro_RowStateChanged);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 574);
            this.Controls.Add(this.grdRegistro);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.Edicion);
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Edicion.ResumeLayout(false);
            this.Edicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Edicion;
        private Label lblFecha;
        private Label lblMarca;
        private Label lblCoste;
        private TextBox txtCoste;
        private TextBox txtMarca;
        private Label lblEur;
        private DateTimePicker dtFecha;
        private Button btnAñadir;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnCancelar;
        private Button btnGuardar;
        private DataGridView grdRegistro;
        private TextBox txtId;
        private Label lbId;
    }
}