namespace _2doParcial_Aranza.UI.FormsInventarios
{
    partial class FrmInventario
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
            label1 = new Label();
            dataGriedInventario = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Bloque = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            btnVerInventario = new Button();
            txtIDJugador = new TextBox();
            txtIDBloque = new TextBox();
            txtCantidad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAgregarInventario = new Button();
            btnActualizarCantidad = new Button();
            txtIDInventario = new TextBox();
            label5 = new Label();
            btnEliminarInventario = new Button();
            btnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGriedInventario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(578, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 43);
            label1.TabIndex = 0;
            label1.Text = "INVENTARIO";
            // 
            // dataGriedInventario
            // 
            dataGriedInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGriedInventario.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Bloque, Cantidad });
            dataGriedInventario.Location = new Point(662, 264);
            dataGriedInventario.Margin = new Padding(4, 3, 4, 3);
            dataGriedInventario.Name = "dataGriedInventario";
            dataGriedInventario.RowHeadersWidth = 51;
            dataGriedInventario.Size = new Size(547, 199);
            dataGriedInventario.TabIndex = 1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Bloque
            // 
            Bloque.HeaderText = "Bloque";
            Bloque.MinimumWidth = 6;
            Bloque.Name = "Bloque";
            Bloque.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // btnVerInventario
            // 
            btnVerInventario.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            btnVerInventario.Location = new Point(697, 491);
            btnVerInventario.Margin = new Padding(4, 3, 4, 3);
            btnVerInventario.Name = "btnVerInventario";
            btnVerInventario.Size = new Size(204, 32);
            btnVerInventario.TabIndex = 2;
            btnVerInventario.Text = "Ver Inventario";
            btnVerInventario.UseVisualStyleBackColor = true;
            btnVerInventario.Click += btnVerInventario_Click;
            // 
            // txtIDJugador
            // 
            txtIDJugador.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            txtIDJugador.Location = new Point(150, 182);
            txtIDJugador.Margin = new Padding(4, 3, 4, 3);
            txtIDJugador.Name = "txtIDJugador";
            txtIDJugador.Size = new Size(271, 30);
            txtIDJugador.TabIndex = 3;
            // 
            // txtIDBloque
            // 
            txtIDBloque.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            txtIDBloque.Location = new Point(147, 262);
            txtIDBloque.Margin = new Padding(4, 3, 4, 3);
            txtIDBloque.Name = "txtIDBloque";
            txtIDBloque.Size = new Size(271, 30);
            txtIDBloque.TabIndex = 4;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            txtCantidad.Location = new Point(147, 340);
            txtCantidad.Margin = new Padding(4, 3, 4, 3);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(274, 30);
            txtCantidad.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            label2.Location = new Point(150, 156);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(192, 22);
            label2.TabIndex = 6;
            label2.Text = "Ingrese ID del Jugador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            label3.Location = new Point(147, 315);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(165, 22);
            label3.TabIndex = 7;
            label3.Text = "Ingrese la cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            label4.Location = new Point(147, 237);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(185, 22);
            label4.TabIndex = 8;
            label4.Text = "Ingrese ID del Bloque";
            // 
            // btnAgregarInventario
            // 
            btnAgregarInventario.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            btnAgregarInventario.Location = new Point(54, 465);
            btnAgregarInventario.Margin = new Padding(4, 3, 4, 3);
            btnAgregarInventario.Name = "btnAgregarInventario";
            btnAgregarInventario.Size = new Size(195, 44);
            btnAgregarInventario.TabIndex = 9;
            btnAgregarInventario.Text = "Agregar Inventario";
            btnAgregarInventario.UseVisualStyleBackColor = true;
            btnAgregarInventario.Click += btnAgregarInventario_Click;
            // 
            // btnActualizarCantidad
            // 
            btnActualizarCantidad.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            btnActualizarCantidad.Location = new Point(298, 465);
            btnActualizarCantidad.Margin = new Padding(4, 3, 4, 3);
            btnActualizarCantidad.Name = "btnActualizarCantidad";
            btnActualizarCantidad.Size = new Size(221, 44);
            btnActualizarCantidad.TabIndex = 10;
            btnActualizarCantidad.Text = "Actualizar Inventario";
            btnActualizarCantidad.UseVisualStyleBackColor = true;
            btnActualizarCantidad.Click += btnActualizarCantidad_Click;
            // 
            // txtIDInventario
            // 
            txtIDInventario.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            txtIDInventario.Location = new Point(867, 220);
            txtIDInventario.Margin = new Padding(4, 3, 4, 3);
            txtIDInventario.Name = "txtIDInventario";
            txtIDInventario.Size = new Size(139, 30);
            txtIDInventario.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            label5.Location = new Point(624, 223);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(235, 22);
            label5.TabIndex = 12;
            label5.Text = "Ingrese el ID del Inventario";
            // 
            // btnEliminarInventario
            // 
            btnEliminarInventario.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            btnEliminarInventario.Location = new Point(147, 562);
            btnEliminarInventario.Margin = new Padding(4, 3, 4, 3);
            btnEliminarInventario.Name = "btnEliminarInventario";
            btnEliminarInventario.Size = new Size(270, 44);
            btnEliminarInventario.TabIndex = 13;
            btnEliminarInventario.Text = "Eliminar Registro Inventario";
            btnEliminarInventario.UseVisualStyleBackColor = true;
            btnEliminarInventario.Click += btnEliminarInventario_Click;
            // 
            // btnExportar
            // 
            btnExportar.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            btnExportar.Location = new Point(988, 491);
            btnExportar.Margin = new Padding(4, 3, 4, 3);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(129, 32);
            btnExportar.TabIndex = 14;
            btnExportar.Text = "Exportar Inventario";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // FrmInventario
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.descarga;
            ClientSize = new Size(1473, 685);
            Controls.Add(btnExportar);
            Controls.Add(btnEliminarInventario);
            Controls.Add(label5);
            Controls.Add(txtIDInventario);
            Controls.Add(btnActualizarCantidad);
            Controls.Add(btnAgregarInventario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCantidad);
            Controls.Add(txtIDBloque);
            Controls.Add(txtIDJugador);
            Controls.Add(btnVerInventario);
            Controls.Add(dataGriedInventario);
            Controls.Add(label1);
            Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmInventario";
            Text = "FrmInventario";
            ((System.ComponentModel.ISupportInitialize)dataGriedInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGriedInventario;
        private Button btnVerInventario;
        private TextBox txtIDJugador;
        private TextBox txtIDBloque;
        private TextBox txtCantidad;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAgregarInventario;
        private Button btnActualizarCantidad;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Bloque;
        private DataGridViewTextBoxColumn Cantidad;
        private TextBox txtIDInventario;
        private Label label5;
        private Button btnEliminarInventario;
        private Button btnExportar;
    }
}