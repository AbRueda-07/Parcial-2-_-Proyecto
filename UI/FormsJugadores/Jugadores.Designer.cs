namespace _2doParcial_Aranza.UI.FormsJugadores
{
    partial class Jugadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jugadores));
            label1 = new Label();
            txtNombre = new TextBox();
            txtNivel = new TextBox();
            label2 = new Label();
            labelNivel = new Label();
            datosJugadores = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Nivel = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            btnVerJugadores = new Button();
            btnVerJugador = new Button();
            txtID = new TextBox();
            label3 = new Label();
            btnCrearJugador = new Button();
            btnActualizarJugador = new Button();
            btnEliminarJugador = new Button();
            ((System.ComponentModel.ISupportInitialize)datosJugadores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(421, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 35);
            label1.TabIndex = 0;
            label1.Text = "Jugadores";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            txtNombre.Location = new Point(68, 196);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(291, 30);
            txtNombre.TabIndex = 2;
            // 
            // txtNivel
            // 
            txtNivel.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            txtNivel.Location = new Point(68, 269);
            txtNivel.Margin = new Padding(4, 3, 4, 3);
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(291, 30);
            txtNivel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            label2.Location = new Point(68, 167);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 22);
            label2.TabIndex = 4;
            label2.Text = "Ingrese el Nombre";
            // 
            // labelNivel
            // 
            labelNivel.AutoSize = true;
            labelNivel.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            labelNivel.Location = new Point(68, 240);
            labelNivel.Margin = new Padding(4, 0, 4, 0);
            labelNivel.Name = "labelNivel";
            labelNivel.Size = new Size(138, 22);
            labelNivel.TabIndex = 5;
            labelNivel.Text = "Ingrese el Nivel";
            // 
            // datosJugadores
            // 
            datosJugadores.BackgroundColor = Color.DarkSeaGreen;
            datosJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datosJugadores.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Nivel, FechaCreacion });
            datosJugadores.Location = new Point(472, 206);
            datosJugadores.Margin = new Padding(4, 3, 4, 3);
            datosJugadores.Name = "datosJugadores";
            datosJugadores.RowHeadersWidth = 51;
            datosJugadores.Size = new Size(552, 230);
            datosJugadores.TabIndex = 6;
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
            // Nivel
            // 
            Nivel.HeaderText = "Nivel";
            Nivel.MinimumWidth = 6;
            Nivel.Name = "Nivel";
            Nivel.Width = 125;
            // 
            // FechaCreacion
            // 
            FechaCreacion.HeaderText = "Fecha de Creación";
            FechaCreacion.MinimumWidth = 6;
            FechaCreacion.Name = "FechaCreacion";
            FechaCreacion.Width = 125;
            // 
            // btnVerJugadores
            // 
            btnVerJugadores.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            btnVerJugadores.Location = new Point(827, 472);
            btnVerJugadores.Margin = new Padding(4, 3, 4, 3);
            btnVerJugadores.Name = "btnVerJugadores";
            btnVerJugadores.Size = new Size(174, 42);
            btnVerJugadores.TabIndex = 7;
            btnVerJugadores.Text = "Ver Jugadores";
            btnVerJugadores.UseVisualStyleBackColor = true;
            btnVerJugadores.Click += btnVerJugadores_Click_1;
            // 
            // btnVerJugador
            // 
            btnVerJugador.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            btnVerJugador.Location = new Point(508, 472);
            btnVerJugador.Margin = new Padding(4, 3, 4, 3);
            btnVerJugador.Name = "btnVerJugador";
            btnVerJugador.Size = new Size(181, 42);
            btnVerJugador.TabIndex = 8;
            btnVerJugador.Text = "Ver Jugador";
            btnVerJugador.UseVisualStyleBackColor = true;
            btnVerJugador.Click += btnVerJugador_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(744, 166);
            txtID.Margin = new Padding(4, 3, 4, 3);
            txtID.Name = "txtID";
            txtID.Size = new Size(255, 29);
            txtID.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            label3.Location = new Point(472, 167);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(217, 22);
            label3.TabIndex = 10;
            label3.Text = "Ingrese el ID del Jugador:";
            // 
            // btnCrearJugador
            // 
            btnCrearJugador.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            btnCrearJugador.Location = new Point(22, 400);
            btnCrearJugador.Margin = new Padding(4, 3, 4, 3);
            btnCrearJugador.Name = "btnCrearJugador";
            btnCrearJugador.Size = new Size(198, 39);
            btnCrearJugador.TabIndex = 11;
            btnCrearJugador.Text = "Crear Jugador";
            btnCrearJugador.UseVisualStyleBackColor = true;
            btnCrearJugador.Click += btnCrearJugador_Click;
            // 
            // btnActualizarJugador
            // 
            btnActualizarJugador.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            btnActualizarJugador.Location = new Point(22, 445);
            btnActualizarJugador.Margin = new Padding(4, 3, 4, 3);
            btnActualizarJugador.Name = "btnActualizarJugador";
            btnActualizarJugador.Size = new Size(198, 38);
            btnActualizarJugador.TabIndex = 12;
            btnActualizarJugador.Text = "Actualizar Jugador";
            btnActualizarJugador.UseVisualStyleBackColor = true;
            btnActualizarJugador.Click += btnActualizarJugador_Click;
            // 
            // btnEliminarJugador
            // 
            btnEliminarJugador.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold);
            btnEliminarJugador.Location = new Point(22, 506);
            btnEliminarJugador.Margin = new Padding(4, 3, 4, 3);
            btnEliminarJugador.Name = "btnEliminarJugador";
            btnEliminarJugador.Size = new Size(198, 36);
            btnEliminarJugador.TabIndex = 13;
            btnEliminarJugador.Text = "Eliminar Jugador";
            btnEliminarJugador.UseVisualStyleBackColor = true;
            btnEliminarJugador.Click += btnEliminarJugador_Click;
            // 
            // Jugadores
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1101, 632);
            Controls.Add(btnEliminarJugador);
            Controls.Add(btnActualizarJugador);
            Controls.Add(btnCrearJugador);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(btnVerJugador);
            Controls.Add(btnVerJugadores);
            Controls.Add(datosJugadores);
            Controls.Add(labelNivel);
            Controls.Add(label2);
            Controls.Add(txtNivel);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Jugadores";
            Text = "Jugadores";
            Load += Jugadores_Load;
            ((System.ComponentModel.ISupportInitialize)datosJugadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtNivel;
        private Label label2;
        private Label labelNivel;
        private DataGridView datosJugadores;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Nivel;
        private DataGridViewTextBoxColumn FechaCreacion;
        private Button btnVerJugadores;
        private Button btnVerJugador;
        private TextBox txtID;
        private Label label3;
        private Button btnCrearJugador;
        private Button btnActualizarJugador;
        private Button btnEliminarJugador;
    }
}