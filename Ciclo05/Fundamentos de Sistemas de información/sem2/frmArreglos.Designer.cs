namespace Arreglos
{
    partial class frmArreglos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCantUsuarios = new System.Windows.Forms.Label();
            this.btnMostrarUsuarios = new System.Windows.Forms.Button();
            this.lvUsuarios = new System.Windows.Forms.ListView();
            this.chNombres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chApePaterno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chApeMaterno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEdad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbOrdenarPor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOrdenarPor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbFormaOrdenamiento = new System.Windows.Forms.ComboBox();
            this.btnDefinirCantidadUsuarios = new System.Windows.Forms.Button();
            this.nudCantidadUsuarios = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lvResultado = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtValorBusqueda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudEdad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApeMaterno);
            this.groupBox1.Controls.Add(this.txtApePaterno);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(779, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del usuario";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(181, 128);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(223, 26);
            this.txtDNI.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "DNI";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(21, 128);
            this.nudEdad.Margin = new System.Windows.Forms.Padding(4);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(85, 26);
            this.nudEdad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edad";
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.Location = new System.Drawing.Point(533, 59);
            this.txtApeMaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(223, 26);
            this.txtApeMaterno.TabIndex = 5;
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.Location = new System.Drawing.Point(277, 59);
            this.txtApePaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(223, 26);
            this.txtApePaterno.TabIndex = 4;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(21, 59);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(223, 26);
            this.txtNombres.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.Location = new System.Drawing.Point(811, 128);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(171, 39);
            this.btnAgregarUsuario.TabIndex = 1;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(811, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Usuarios:";
            // 
            // lblCantUsuarios
            // 
            this.lblCantUsuarios.AutoSize = true;
            this.lblCantUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantUsuarios.Location = new System.Drawing.Point(907, 177);
            this.lblCantUsuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantUsuarios.Name = "lblCantUsuarios";
            this.lblCantUsuarios.Size = new System.Drawing.Size(18, 20);
            this.lblCantUsuarios.TabIndex = 3;
            this.lblCantUsuarios.Text = "0";
            // 
            // btnMostrarUsuarios
            // 
            this.btnMostrarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarUsuarios.Location = new System.Drawing.Point(21, 325);
            this.btnMostrarUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarUsuarios.Name = "btnMostrarUsuarios";
            this.btnMostrarUsuarios.Size = new System.Drawing.Size(160, 38);
            this.btnMostrarUsuarios.TabIndex = 4;
            this.btnMostrarUsuarios.Text = "Mostrar Usuarios";
            this.btnMostrarUsuarios.UseVisualStyleBackColor = true;
            this.btnMostrarUsuarios.Click += new System.EventHandler(this.btnMostrarUsuarios_Click);
            // 
            // lvUsuarios
            // 
            this.lvUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombres,
            this.chApePaterno,
            this.chApeMaterno,
            this.chEdad,
            this.chDNI});
            this.lvUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvUsuarios.HideSelection = false;
            this.lvUsuarios.Location = new System.Drawing.Point(21, 371);
            this.lvUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.lvUsuarios.Name = "lvUsuarios";
            this.lvUsuarios.Size = new System.Drawing.Size(884, 121);
            this.lvUsuarios.TabIndex = 5;
            this.lvUsuarios.UseCompatibleStateImageBehavior = false;
            this.lvUsuarios.View = System.Windows.Forms.View.Details;
            // 
            // chNombres
            // 
            this.chNombres.Text = "Nombres";
            this.chNombres.Width = 150;
            // 
            // chApePaterno
            // 
            this.chApePaterno.Text = "Apellido Paterno";
            this.chApePaterno.Width = 150;
            // 
            // chApeMaterno
            // 
            this.chApeMaterno.Text = "Apellido Materno";
            this.chApeMaterno.Width = 150;
            // 
            // chEdad
            // 
            this.chEdad.Text = "Edad";
            // 
            // chDNI
            // 
            this.chDNI.Text = "DNI";
            this.chDNI.Width = 100;
            // 
            // cbOrdenarPor
            // 
            this.cbOrdenarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrdenarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrdenarPor.FormattingEnabled = true;
            this.cbOrdenarPor.Items.AddRange(new object[] {
            "Edad",
            "DNI"});
            this.cbOrdenarPor.Location = new System.Drawing.Point(341, 335);
            this.cbOrdenarPor.Margin = new System.Windows.Forms.Padding(4);
            this.cbOrdenarPor.Name = "cbOrdenarPor";
            this.cbOrdenarPor.Size = new System.Drawing.Size(160, 28);
            this.cbOrdenarPor.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ordenar por:";
            // 
            // btnOrdenarPor
            // 
            this.btnOrdenarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarPor.Location = new System.Drawing.Point(779, 325);
            this.btnOrdenarPor.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdenarPor.Name = "btnOrdenarPor";
            this.btnOrdenarPor.Size = new System.Drawing.Size(149, 39);
            this.btnOrdenarPor.TabIndex = 8;
            this.btnOrdenarPor.Text = "Ordenar";
            this.btnOrdenarPor.UseVisualStyleBackColor = true;
            this.btnOrdenarPor.Click += new System.EventHandler(this.btnOrdenarPor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(544, 315);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Forma:";
            // 
            // cbFormaOrdenamiento
            // 
            this.cbFormaOrdenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaOrdenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormaOrdenamiento.FormattingEnabled = true;
            this.cbFormaOrdenamiento.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cbFormaOrdenamiento.Location = new System.Drawing.Point(544, 335);
            this.cbFormaOrdenamiento.Margin = new System.Windows.Forms.Padding(4);
            this.cbFormaOrdenamiento.Name = "cbFormaOrdenamiento";
            this.cbFormaOrdenamiento.Size = new System.Drawing.Size(201, 28);
            this.cbFormaOrdenamiento.TabIndex = 9;
            // 
            // btnDefinirCantidadUsuarios
            // 
            this.btnDefinirCantidadUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefinirCantidadUsuarios.Location = new System.Drawing.Point(149, 39);
            this.btnDefinirCantidadUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnDefinirCantidadUsuarios.Name = "btnDefinirCantidadUsuarios";
            this.btnDefinirCantidadUsuarios.Size = new System.Drawing.Size(256, 39);
            this.btnDefinirCantidadUsuarios.TabIndex = 11;
            this.btnDefinirCantidadUsuarios.Text = "Definir Cantidad Usuarios";
            this.btnDefinirCantidadUsuarios.UseVisualStyleBackColor = true;
            this.btnDefinirCantidadUsuarios.Click += new System.EventHandler(this.btnDefinirCantidadUsuarios_Click);
            // 
            // nudCantidadUsuarios
            // 
            this.nudCantidadUsuarios.Location = new System.Drawing.Point(21, 49);
            this.nudCantidadUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantidadUsuarios.Name = "nudCantidadUsuarios";
            this.nudCantidadUsuarios.Size = new System.Drawing.Size(85, 22);
            this.nudCantidadUsuarios.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cantidad de usuarios a registrar";
            // 
            // lvResultado
            // 
            this.lvResultado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvResultado.HideSelection = false;
            this.lvResultado.Location = new System.Drawing.Point(24, 568);
            this.lvResultado.Margin = new System.Windows.Forms.Padding(4);
            this.lvResultado.Name = "lvResultado";
            this.lvResultado.Size = new System.Drawing.Size(884, 176);
            this.lvResultado.TabIndex = 13;
            this.lvResultado.UseCompatibleStateImageBehavior = false;
            this.lvResultado.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombres";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellido Paterno";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellido Materno";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Edad";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DNI";
            this.columnHeader5.Width = 100;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(267, 521);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(149, 39);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtValorBusqueda
            // 
            this.txtValorBusqueda.Location = new System.Drawing.Point(21, 531);
            this.txtValorBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorBusqueda.Name = "txtValorBusqueda";
            this.txtValorBusqueda.Size = new System.Drawing.Size(223, 22);
            this.txtValorBusqueda.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 511);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Nombre";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMensaje.Location = new System.Drawing.Point(437, 49);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(415, 20);
            this.lblMensaje.TabIndex = 17;
            this.lblMensaje.Text = "Cantidad de usuarios a registrar aún no definido";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(819, 236);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 38);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmArreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 757);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtValorBusqueda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lvResultado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudCantidadUsuarios);
            this.Controls.Add(this.btnDefinirCantidadUsuarios);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbFormaOrdenamiento);
            this.Controls.Add(this.btnOrdenarPor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbOrdenarPor);
            this.Controls.Add(this.lvUsuarios);
            this.Controls.Add(this.btnMostrarUsuarios);
            this.Controls.Add(this.lblCantUsuarios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmArreglos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arreglos";
            this.Load += new System.EventHandler(this.frmArreglos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCantUsuarios;
        private System.Windows.Forms.Button btnMostrarUsuarios;
        private System.Windows.Forms.ListView lvUsuarios;
        private System.Windows.Forms.ColumnHeader chNombres;
        private System.Windows.Forms.ColumnHeader chApePaterno;
        private System.Windows.Forms.ColumnHeader chApeMaterno;
        private System.Windows.Forms.ColumnHeader chEdad;
        private System.Windows.Forms.ColumnHeader chDNI;
        private System.Windows.Forms.ComboBox cbOrdenarPor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOrdenarPor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbFormaOrdenamiento;
        private System.Windows.Forms.Button btnDefinirCantidadUsuarios;
        private System.Windows.Forms.NumericUpDown nudCantidadUsuarios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvResultado;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtValorBusqueda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

