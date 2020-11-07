namespace CRUD
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnagregar = new System.Windows.Forms.ToolStripButton();
            this.btnsubir_informacion = new System.Windows.Forms.ToolStripButton();
            this.btnbuscar = new System.Windows.Forms.ToolStripButton();
            this.btneditar = new System.Windows.Forms.ToolStripButton();
            this.btnsalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnguardar = new System.Windows.Forms.ToolStripButton();
            this.btneliminar = new System.Windows.Forms.ToolStripButton();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.lblnota1 = new System.Windows.Forms.Label();
            this.lblnota2 = new System.Windows.Forms.Label();
            this.lblnota3 = new System.Windows.Forms.Label();
            this.lblnota4 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.txtnota4 = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgresultados = new System.Windows.Forms.DataGridView();
            this.lbldatos_estudiante = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgresultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnagregar.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.Image")));
            this.btnagregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnagregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnagregar.MergeIndex = 5;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Padding = new System.Windows.Forms.Padding(5);
            this.btnagregar.Size = new System.Drawing.Size(94, 94);
            this.btnagregar.Text = "Agregar";
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnsubir_informacion
            // 
            this.btnsubir_informacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnsubir_informacion.Image = ((System.Drawing.Image)(resources.GetObject("btnsubir_informacion.Image")));
            this.btnsubir_informacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnsubir_informacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsubir_informacion.MergeIndex = 5;
            this.btnsubir_informacion.Name = "btnsubir_informacion";
            this.btnsubir_informacion.Padding = new System.Windows.Forms.Padding(5);
            this.btnsubir_informacion.Size = new System.Drawing.Size(94, 94);
            this.btnsubir_informacion.Text = "Subir";
            this.btnsubir_informacion.Click += new System.EventHandler(this.btnsubir_informacion_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnbuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbuscar.MergeIndex = 5;
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Padding = new System.Windows.Forms.Padding(5);
            this.btnbuscar.Size = new System.Drawing.Size(94, 94);
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneditar
            // 
            this.btneditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btneditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneditar.MergeIndex = 5;
            this.btneditar.Name = "btneditar";
            this.btneditar.Padding = new System.Windows.Forms.Padding(5);
            this.btneditar.Size = new System.Drawing.Size(94, 94);
            this.btneditar.Text = "Editar";
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnsalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsalir.MergeIndex = 5;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Padding = new System.Windows.Forms.Padding(5);
            this.btnsalir.Size = new System.Drawing.Size(94, 94);
            this.btnsalir.Text = "Salir";
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnsubir_informacion,
            this.btnguardar,
            this.btnagregar,
            this.btnbuscar,
            this.btneditar,
            this.btneliminar,
            this.btnsalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(667, 97);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnguardar
            // 
            this.btnguardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnguardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(84, 94);
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btneliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(84, 94);
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(473, 114);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 1;
            this.lblcodigo.Text = "Codigo";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(25, 164);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Location = new System.Drawing.Point(25, 218);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(38, 13);
            this.lblcorreo.TabIndex = 3;
            this.lblcorreo.Text = "Correo";
            // 
            // lblnota1
            // 
            this.lblnota1.AutoSize = true;
            this.lblnota1.Location = new System.Drawing.Point(114, 278);
            this.lblnota1.Name = "lblnota1";
            this.lblnota1.Size = new System.Drawing.Size(39, 13);
            this.lblnota1.TabIndex = 4;
            this.lblnota1.Text = "Nota 1";
            // 
            // lblnota2
            // 
            this.lblnota2.AutoSize = true;
            this.lblnota2.Location = new System.Drawing.Point(246, 278);
            this.lblnota2.Name = "lblnota2";
            this.lblnota2.Size = new System.Drawing.Size(39, 13);
            this.lblnota2.TabIndex = 5;
            this.lblnota2.Text = "Nota 2";
            // 
            // lblnota3
            // 
            this.lblnota3.AutoSize = true;
            this.lblnota3.Location = new System.Drawing.Point(394, 278);
            this.lblnota3.Name = "lblnota3";
            this.lblnota3.Size = new System.Drawing.Size(39, 13);
            this.lblnota3.TabIndex = 6;
            this.lblnota3.Text = "Nota 3";
            // 
            // lblnota4
            // 
            this.lblnota4.AutoSize = true;
            this.lblnota4.Location = new System.Drawing.Point(530, 278);
            this.lblnota4.Name = "lblnota4";
            this.lblnota4.Size = new System.Drawing.Size(39, 13);
            this.lblnota4.TabIndex = 7;
            this.lblnota4.Text = "Nota 4";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(536, 111);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(99, 20);
            this.txtcodigo.TabIndex = 8;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(100, 164);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(535, 20);
            this.txtnombre.TabIndex = 9;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(100, 218);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(535, 20);
            this.txtcorreo.TabIndex = 10;
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(166, 275);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(52, 20);
            this.txtnota1.TabIndex = 11;
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(305, 275);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(52, 20);
            this.txtnota2.TabIndex = 12;
            // 
            // txtnota3
            // 
            this.txtnota3.Location = new System.Drawing.Point(445, 275);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(52, 20);
            this.txtnota3.TabIndex = 13;
            // 
            // txtnota4
            // 
            this.txtnota4.Location = new System.Drawing.Point(580, 275);
            this.txtnota4.Name = "txtnota4";
            this.txtnota4.Size = new System.Drawing.Size(54, 20);
            this.txtnota4.TabIndex = 14;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.RightToLeftChanged += new System.EventHandler(this.Form1_Load);
            // 
            // dgresultados
            // 
            this.dgresultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgresultados.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgresultados.Location = new System.Drawing.Point(28, 317);
            this.dgresultados.Name = "dgresultados";
            this.dgresultados.Size = new System.Drawing.Size(607, 140);
            this.dgresultados.TabIndex = 15;
            // 
            // lbldatos_estudiante
            // 
            this.lbldatos_estudiante.AutoSize = true;
            this.lbldatos_estudiante.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatos_estudiante.Location = new System.Drawing.Point(25, 111);
            this.lbldatos_estudiante.Name = "lbldatos_estudiante";
            this.lbldatos_estudiante.Size = new System.Drawing.Size(141, 20);
            this.lbldatos_estudiante.TabIndex = 16;
            this.lbldatos_estudiante.Text = "DATOS ESTUDIANTE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 491);
            this.Controls.Add(this.lbldatos_estudiante);
            this.Controls.Add(this.dgresultados);
            this.Controls.Add(this.txtnota4);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblnota4);
            this.Controls.Add(this.lblnota3);
            this.Controls.Add(this.lblnota2);
            this.Controls.Add(this.lblnota1);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "CALCULO DE NOTAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgresultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnagregar;
        private System.Windows.Forms.ToolStripButton btnsubir_informacion;
        private System.Windows.Forms.ToolStripButton btnbuscar;
        private System.Windows.Forms.ToolStripButton btneditar;
        private System.Windows.Forms.ToolStripButton btnsalir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.Label lblnota1;
        private System.Windows.Forms.Label lblnota2;
        private System.Windows.Forms.Label lblnota3;
        private System.Windows.Forms.Label lblnota4;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.TextBox txtnota4;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.DataGridView dgresultados;
        private System.Windows.Forms.Label lbldatos_estudiante;
        private System.Windows.Forms.ToolStripButton btneliminar;
        private System.Windows.Forms.ToolStripButton btnguardar;
    }
}

