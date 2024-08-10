namespace CapaPresentacion
{
    partial class panelAdmin
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
            panel1 = new Panel();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label8 = new Label();
            viewVisitas = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            countVisita = new Label();
            label2 = new Label();
            panel3 = new Panel();
            countUsuario = new Label();
            label5 = new Label();
            panel4 = new Panel();
            countAdmin = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewVisitas).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 50);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(835, 3);
            button3.Name = "button3";
            button3.Size = new Size(135, 47);
            button3.TabIndex = 14;
            button3.Text = "Cerrar session";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(669, 0);
            button1.Name = "button1";
            button1.Size = new Size(135, 50);
            button1.TabIndex = 13;
            button1.Text = "Ajustes generales";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(508, 0);
            button2.Name = "button2";
            button2.Size = new Size(135, 50);
            button2.TabIndex = 12;
            button2.Text = "Historial visitas";
            button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(214, 25);
            label8.TabIndex = 8;
            label8.Text = "Panel de administracion";
            // 
            // viewVisitas
            // 
            viewVisitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewVisitas.Location = new Point(12, 243);
            viewVisitas.Name = "viewVisitas";
            viewVisitas.Size = new Size(958, 279);
            viewVisitas.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 212);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 2;
            label1.Text = "Historial de visitas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(countVisita);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 82);
            panel2.TabIndex = 3;
            // 
            // countVisita
            // 
            countVisita.AutoSize = true;
            countVisita.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countVisita.ForeColor = SystemColors.ControlLightLight;
            countVisita.Location = new Point(13, 38);
            countVisita.Name = "countVisita";
            countVisita.Size = new Size(35, 30);
            countVisita.TabIndex = 7;
            countVisita.Text = "20";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(13, 11);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 6;
            label2.Text = "Total visitas activas";
            // 
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Controls.Add(countUsuario);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(358, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 82);
            panel3.TabIndex = 4;
            // 
            // countUsuario
            // 
            countUsuario.AutoSize = true;
            countUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countUsuario.ForeColor = SystemColors.ControlLightLight;
            countUsuario.Location = new Point(14, 38);
            countUsuario.Name = "countUsuario";
            countUsuario.Size = new Size(35, 30);
            countUsuario.TabIndex = 9;
            countUsuario.Text = "20";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(14, 11);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 8;
            label5.Text = "Total usuarios ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Chocolate;
            panel4.Controls.Add(countAdmin);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(710, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(260, 82);
            panel4.TabIndex = 5;
            // 
            // countAdmin
            // 
            countAdmin.AutoSize = true;
            countAdmin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countAdmin.ForeColor = SystemColors.ControlLightLight;
            countAdmin.Location = new Point(15, 38);
            countAdmin.Name = "countAdmin";
            countAdmin.Size = new Size(35, 30);
            countAdmin.TabIndex = 11;
            countAdmin.Text = "20";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(15, 11);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 10;
            label7.Text = "Total admins";
            // 
            // panelAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 534);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(viewVisitas);
            Controls.Add(panel1);
            Name = "panelAdmin";
            Text = "panelAdmin";
            Load += panelAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewVisitas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView viewVisitas;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label countVisita;
        private Label label2;
        private Label countUsuario;
        private Label label5;
        private Label countAdmin;
        private Label label7;
        private Label label8;
        private Button button3;
        private Button button1;
        private Button button2;
    }
}