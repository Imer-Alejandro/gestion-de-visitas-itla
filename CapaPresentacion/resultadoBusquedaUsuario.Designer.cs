namespace CapaPresentacion
{
    partial class resultadoBusquedaUsuario
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
            viewResult = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)viewResult).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(342, 30);
            label1.TabIndex = 0;
            label1.Text = "Resultados de busqueda de usuario";
            // 
            // viewResult
            // 
            viewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewResult.Location = new Point(12, 119);
            viewResult.Name = "viewResult";
            viewResult.Size = new Size(624, 150);
            viewResult.TabIndex = 1;
            // 
            // resultadoBusquedaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 307);
            Controls.Add(viewResult);
            Controls.Add(label1);
            Name = "resultadoBusquedaUsuario";
            Text = "resultadoBusquedaUsuario";
            Load += resultadoBusquedaUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)viewResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView viewResult;
    }
}