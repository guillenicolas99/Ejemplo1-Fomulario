namespace Ejemplo1_Clases
{
    partial class FrmListaProfesores
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
            this.groupBoxProfesores = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lstvProfesores = new System.Windows.Forms.DataGridView();
            this.groupBoxProfesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstvProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProfesores
            // 
            this.groupBoxProfesores.Controls.Add(this.btnCancelar);
            this.groupBoxProfesores.Controls.Add(this.lstvProfesores);
            this.groupBoxProfesores.Location = new System.Drawing.Point(124, 59);
            this.groupBoxProfesores.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxProfesores.Name = "groupBoxProfesores";
            this.groupBoxProfesores.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxProfesores.Size = new System.Drawing.Size(904, 446);
            this.groupBoxProfesores.TabIndex = 1;
            this.groupBoxProfesores.TabStop = false;
            this.groupBoxProfesores.Text = "Lista de Profesores";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(667, 375);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(184, 38);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lstvProfesores
            // 
            this.lstvProfesores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lstvProfesores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.lstvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstvProfesores.Location = new System.Drawing.Point(35, 39);
            this.lstvProfesores.Margin = new System.Windows.Forms.Padding(4);
            this.lstvProfesores.Name = "lstvProfesores";
            this.lstvProfesores.RowHeadersWidth = 51;
            this.lstvProfesores.Size = new System.Drawing.Size(817, 274);
            this.lstvProfesores.TabIndex = 0;
            this.lstvProfesores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstvProfesores_CellContentClick);
            // 
            // FrmListaProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 619);
            this.Controls.Add(this.groupBoxProfesores);
            this.Name = "FrmListaProfesores";
            this.Text = "FrmListaProfesores";
            this.Load += new System.EventHandler(this.FrmListaProfesores_Load);
            this.groupBoxProfesores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstvProfesores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProfesores;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView lstvProfesores;
    }
}