namespace _2doParcial_Aranza.UI.FormsInventarios
{
    partial class VerJugadorInventario
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
            dataGridJugadores = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Nivel = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridJugadores).BeginInit();
            SuspendLayout();
            // 
            // dataGridJugadores
            // 
            dataGridJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridJugadores.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Nivel, FechaCreacion });
            dataGridJugadores.Location = new Point(54, 117);
            dataGridJugadores.Name = "dataGridJugadores";
            dataGridJugadores.RowHeadersWidth = 51;
            dataGridJugadores.Size = new Size(551, 188);
            dataGridJugadores.TabIndex = 0;
            dataGridJugadores.CellContentClick += dataGridJugadores_CellContentClick;
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
            FechaCreacion.HeaderText = "Fecha Creacion";
            FechaCreacion.MinimumWidth = 6;
            FechaCreacion.Name = "FechaCreacion";
            FechaCreacion.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 55);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 1;
            label1.Text = "JUGADORES - INVENTARIO";
            // 
            // VerJugadorInventario
            // 
            ClientSize = new Size(657, 322);
            Controls.Add(label1);
            Controls.Add(dataGridJugadores);
            Name = "VerJugadorInventario";
            ((System.ComponentModel.ISupportInitialize)dataGridJugadores).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DataGridView dataGridJugadores;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Nivel;
        private DataGridViewTextBoxColumn FechaCreacion;
        private Label label1;
    }
}