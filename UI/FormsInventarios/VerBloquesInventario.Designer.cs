namespace _2doParcial_Aranza.UI.FormsInventarios
{
    partial class VerBloquesInventario
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
            dataGriedBloqueInventario = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Raza = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGriedBloqueInventario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 30);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 0;
            label1.Text = "BLOQUES - INVENTARIO";
            // 
            // dataGriedBloqueInventario
            // 
            dataGriedBloqueInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGriedBloqueInventario.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Tipo, Raza });
            dataGriedBloqueInventario.Location = new Point(41, 63);
            dataGriedBloqueInventario.Name = "dataGriedBloqueInventario";
            dataGriedBloqueInventario.RowHeadersWidth = 51;
            dataGriedBloqueInventario.Size = new Size(548, 209);
            dataGriedBloqueInventario.TabIndex = 7;
            dataGriedBloqueInventario.CellContentClick += datosJugadores_CellContentClick;
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
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.Width = 125;
            // 
            // Raza
            // 
            Raza.HeaderText = "Raza";
            Raza.MinimumWidth = 6;
            Raza.Name = "Raza";
            Raza.Width = 125;
            // 
            // VerBloquesInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 311);
            Controls.Add(dataGriedBloqueInventario);
            Controls.Add(label1);
            Name = "VerBloquesInventario";
            Text = "VerBloquesInventario";
            ((System.ComponentModel.ISupportInitialize)dataGriedBloqueInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGriedBloqueInventario;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Raza;
    }
}