namespace Presentation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DvgDatos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textcodsalida = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCodigoPais = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSalir = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuevo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DvgDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // DvgDatos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DvgDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DvgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DvgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DvgDatos.ColumnHeadersHeight = 15;
            this.DvgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DvgDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DvgDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DvgDatos.Location = new System.Drawing.Point(7, 277);
            this.DvgDatos.Name = "DvgDatos";
            this.DvgDatos.RowHeadersVisible = false;
            this.DvgDatos.Size = new System.Drawing.Size(783, 275);
            this.DvgDatos.TabIndex = 1;
            this.DvgDatos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DvgDatos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DvgDatos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DvgDatos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DvgDatos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DvgDatos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DvgDatos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DvgDatos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DvgDatos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DvgDatos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DvgDatos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DvgDatos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DvgDatos.ThemeStyle.HeaderStyle.Height = 15;
            this.DvgDatos.ThemeStyle.ReadOnly = false;
            this.DvgDatos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DvgDatos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DvgDatos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DvgDatos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DvgDatos.ThemeStyle.RowsStyle.Height = 22;
            this.DvgDatos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DvgDatos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // textcodsalida
            // 
            this.textcodsalida.BorderRadius = 13;
            this.textcodsalida.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textcodsalida.DefaultText = "Codigo Salida";
            this.textcodsalida.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textcodsalida.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textcodsalida.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textcodsalida.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textcodsalida.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textcodsalida.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textcodsalida.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textcodsalida.Location = new System.Drawing.Point(367, 121);
            this.textcodsalida.Name = "textcodsalida";
            this.textcodsalida.PasswordChar = '\0';
            this.textcodsalida.PlaceholderText = "Codigo Salida";
            this.textcodsalida.SelectedText = "";
            this.textcodsalida.Size = new System.Drawing.Size(171, 33);
            this.textcodsalida.TabIndex = 2;
            this.textcodsalida.Enter += new System.EventHandler(this.textcodsalida_Enter);
            this.textcodsalida.Leave += new System.EventHandler(this.textcodsalida_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo Salida ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codigo Pais";
            // 
            // textCodigoPais
            // 
            this.textCodigoPais.BorderRadius = 13;
            this.textCodigoPais.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCodigoPais.DefaultText = "Codigo Pais";
            this.textCodigoPais.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textCodigoPais.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textCodigoPais.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCodigoPais.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCodigoPais.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textCodigoPais.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textCodigoPais.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textCodigoPais.Location = new System.Drawing.Point(367, 42);
            this.textCodigoPais.Name = "textCodigoPais";
            this.textCodigoPais.PasswordChar = '\0';
            this.textCodigoPais.PlaceholderText = "Codigo Pais";
            this.textCodigoPais.SelectedText = "";
            this.textCodigoPais.Size = new System.Drawing.Size(175, 33);
            this.textCodigoPais.TabIndex = 6;
            this.textCodigoPais.Enter += new System.EventHandler(this.textCodigoPais_Enter);
            this.textCodigoPais.Leave += new System.EventHandler(this.textCodigoPais_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtSalir);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Location = new System.Drawing.Point(562, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 213);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // txtSalir
            // 
            this.txtSalir.BorderRadius = 13;
            this.txtSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtSalir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtSalir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalir.ForeColor = System.Drawing.Color.White;
            this.txtSalir.Location = new System.Drawing.Point(69, 153);
            this.txtSalir.Name = "txtSalir";
            this.txtSalir.Size = new System.Drawing.Size(92, 39);
            this.txtSalir.TabIndex = 4;
            this.txtSalir.Text = "Salir";
            this.txtSalir.Click += new System.EventHandler(this.txtSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BorderRadius = 13;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuevo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(20, 94);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(89, 30);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderRadius = 13;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(130, 39);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 30);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BorderRadius = 13;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(130, 94);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 30);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BorderRadius = 13;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(20, 39);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 30);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderRadius = 13;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "Buscar...";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Location = new System.Drawing.Point(12, 236);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "Buscar...";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(778, 33);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Buscar:";
            // 
            // txtNombreP
            // 
            this.txtNombreP.BorderRadius = 13;
            this.txtNombreP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreP.DefaultText = "Pais";
            this.txtNombreP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreP.Location = new System.Drawing.Point(367, 191);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.PasswordChar = '\0';
            this.txtNombreP.PlaceholderText = "Pais";
            this.txtNombreP.SelectedText = "";
            this.txtNombreP.Size = new System.Drawing.Size(175, 33);
            this.txtNombreP.TabIndex = 20;
            this.txtNombreP.Enter += new System.EventHandler(this.txtNombreP_Enter);
            this.txtNombreP.Leave += new System.EventHandler(this.txtNombreP_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(371, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Pais";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Presentation.Properties.Resources.LOGO_UDM;
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 187);
            this.panel1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(802, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCodigoPais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textcodsalida);
            this.Controls.Add(this.DvgDatos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DATOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DataGridView DvgDatos;
        private Guna.UI2.WinForms.Guna2TextBox textcodsalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textCodigoPais;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnNuevo;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreP;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button txtSalir;
        private System.Windows.Forms.Panel panel1;
    }
}

