namespace CapaPresentacion
{
    partial class panelAjustes
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
            panel4 = new Panel();
            countAdmin = new Label();
            label7 = new Label();
            panel3 = new Panel();
            countUsuario = new Label();
            label5 = new Label();
            panel2 = new Panel();
            countVisita = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            viewVisitas = new DataGridView();
            tabPage2 = new TabPage();
            viewAdmins = new DataGridView();
            tabPage3 = new TabPage();
            viewUsuarios = new DataGridView();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            NombreUsuario = new TextBox();
            button7 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewVisitas).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewAdmins).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewUsuarios).BeginInit();
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
            panel1.Size = new Size(986, 50);
            panel1.TabIndex = 1;
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
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Desktop;
            button1.Location = new Point(669, 0);
            button1.Name = "button1";
            button1.Size = new Size(135, 50);
            button1.TabIndex = 13;
            button1.Text = "Ajustes generales";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.LightGray;
            button2.Location = new Point(508, 0);
            button2.Name = "button2";
            button2.Size = new Size(135, 50);
            button2.TabIndex = 12;
            button2.Text = "Historial visitas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            // panel4
            // 
            panel4.BackColor = Color.Chocolate;
            panel4.Controls.Add(countAdmin);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(710, 191);
            panel4.Name = "panel4";
            panel4.Size = new Size(260, 57);
            panel4.TabIndex = 8;
            panel4.Paint += panel4_Paint;
            // 
            // countAdmin
            // 
            countAdmin.AutoSize = true;
            countAdmin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countAdmin.ForeColor = SystemColors.ControlLightLight;
            countAdmin.Location = new Point(15, 26);
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
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Controls.Add(countUsuario);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(358, 191);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 57);
            panel3.TabIndex = 7;
            // 
            // countUsuario
            // 
            countUsuario.AutoSize = true;
            countUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countUsuario.ForeColor = SystemColors.ControlLightLight;
            countUsuario.Location = new Point(14, 27);
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
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(countVisita);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 191);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 57);
            panel2.TabIndex = 6;
            // 
            // countVisita
            // 
            countVisita.AutoSize = true;
            countVisita.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countVisita.ForeColor = SystemColors.ControlLightLight;
            countVisita.Location = new Point(13, 27);
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 277);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(962, 245);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(viewVisitas);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(954, 217);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Visitas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // viewVisitas
            // 
            viewVisitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewVisitas.Location = new Point(9, 6);
            viewVisitas.Name = "viewVisitas";
            viewVisitas.Size = new Size(939, 201);
            viewVisitas.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(viewAdmins);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(954, 217);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Administradores";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // viewAdmins
            // 
            viewAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewAdmins.Location = new Point(9, 6);
            viewAdmins.Name = "viewAdmins";
            viewAdmins.Size = new Size(939, 200);
            viewAdmins.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(viewUsuarios);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(954, 217);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Usuarios";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // viewUsuarios
            // 
            viewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewUsuarios.Location = new Point(9, 6);
            viewUsuarios.Name = "viewUsuarios";
            viewUsuarios.Size = new Size(939, 205);
            viewUsuarios.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkBlue;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(782, 82);
            button4.Name = "button4";
            button4.Size = new Size(188, 42);
            button4.TabIndex = 15;
            button4.Text = "Operaciones admin";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkBlue;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.WhiteSmoke;
            button5.Location = new Point(572, 82);
            button5.Name = "button5";
            button5.Size = new Size(188, 42);
            button5.TabIndex = 16;
            button5.Text = "Operaciones usuario";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkBlue;
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.WhiteSmoke;
            button6.Location = new Point(345, 82);
            button6.Name = "button6";
            button6.Size = new Size(201, 42);
            button6.TabIndex = 17;
            button6.Text = "Editar permisos areas/edificios";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // NombreUsuario
            // 
            NombreUsuario.Location = new Point(12, 94);
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.Size = new Size(178, 23);
            NombreUsuario.TabIndex = 18;
            // 
            // button7
            // 
            button7.Location = new Point(197, 94);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 19;
            button7.Text = "buscar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 20;
            label1.Text = "Buscar usuario";
            // 
            // panelAjustes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 534);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(NombreUsuario);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(tabControl1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "panelAjustes";
            Text = "panelAjustes";
            Load += panelAjustes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewVisitas).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewAdmins).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button1;
        private Button button2;
        private Label label8;
        private Panel panel4;
        private Label countAdmin;
        private Label label7;
        private Panel panel3;
        private Label countUsuario;
        private Label label5;
        private Panel panel2;
        private Label countVisita;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox NombreUsuario;
        private Button button7;
        private Label label1;
        private DataGridView viewAdmins;
        private TabPage tabPage1;
        private DataGridView viewVisitas;
        private TabPage tabPage3;
        private DataGridView viewUsuarios;
    }
}