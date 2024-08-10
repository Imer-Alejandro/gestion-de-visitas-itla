namespace CapaPresentacion
{
    partial class CrearEdificioArea
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            NombreEdificio = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            label4 = new Label();
            nombreArea = new TextBox();
            listEdificios = new ComboBox();
            label3 = new Label();
            button2 = new Button();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 80);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(414, 267);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(NombreEdificio);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(406, 239);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Crear Edificios";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(39, 161);
            button1.Name = "button1";
            button1.Size = new Size(301, 47);
            button1.TabIndex = 2;
            button1.Text = "Registrar edificio";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // NombreEdificio
            // 
            NombreEdificio.Location = new Point(39, 98);
            NombreEdificio.Name = "NombreEdificio";
            NombreEdificio.Size = new Size(301, 23);
            NombreEdificio.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 65);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre edificio";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(nombreArea);
            tabPage2.Controls.Add(listEdificios);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(button2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(406, 239);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Crear Areas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 35);
            label4.Name = "label4";
            label4.Size = new Size(145, 15);
            label4.TabIndex = 4;
            label4.Text = "Indique el edificio del area";
            // 
            // nombreArea
            // 
            nombreArea.Location = new Point(49, 121);
            nombreArea.Name = "nombreArea";
            nombreArea.Size = new Size(297, 23);
            nombreArea.TabIndex = 3;
            // 
            // listEdificios
            // 
            listEdificios.FormattingEnabled = true;
            listEdificios.Location = new Point(49, 53);
            listEdificios.Name = "listEdificios";
            listEdificios.Size = new Size(297, 23);
            listEdificios.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 103);
            label3.Name = "label3";
            label3.Size = new Size(146, 15);
            label3.TabIndex = 1;
            label3.Text = "Ingrese el nombre del area";
            // 
            // button2
            // 
            button2.BackColor = Color.YellowGreen;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(49, 176);
            button2.Name = "button2";
            button2.Size = new Size(297, 43);
            button2.TabIndex = 0;
            button2.Text = "registrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 9);
            label1.Name = "label1";
            label1.Size = new Size(216, 30);
            label1.TabIndex = 2;
            label1.Text = "Crear Edificios / Areas";
            // 
            // CrearEdificioArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 377);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "CrearEdificioArea";
            Text = "CrearEdificioArea";
            Load += CrearEdificioArea_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Button button1;
        private TextBox NombreEdificio;
        private Label label2;
        private Label label4;
        private TextBox nombreArea;
        private ComboBox listEdificios;
        private Label label3;
        private Button button2;
    }
}