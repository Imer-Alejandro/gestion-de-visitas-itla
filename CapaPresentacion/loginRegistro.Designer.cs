namespace CapaPresentacion
{
    partial class loginRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginRegistro));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            Correo = new TextBox();
            Nombre = new TextBox();
            button1 = new Button();
            label4 = new Label();
            Carrera = new TextBox();
            label5 = new Label();
            Clave = new TextBox();
            label6 = new Label();
            Matricula = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(385, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 527);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 112);
            label1.Name = "label1";
            label1.Size = new Size(245, 37);
            label1.TabIndex = 5;
            label1.Text = "Registro de usuario";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(64, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 108);
            panel2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 238);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 12;
            label3.Text = "Nombre completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 296);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 11;
            label2.Text = "Correo";
            // 
            // Correo
            // 
            Correo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Correo.BorderStyle = BorderStyle.None;
            Correo.Location = new Point(26, 323);
            Correo.Name = "Correo";
            Correo.Size = new Size(287, 16);
            Correo.TabIndex = 10;
            // 
            // Nombre
            // 
            Nombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Nombre.BorderStyle = BorderStyle.None;
            Nombre.Location = new Point(26, 265);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(287, 16);
            Nombre.TabIndex = 9;
            Nombre.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(26, 481);
            button1.Name = "button1";
            button1.Size = new Size(287, 35);
            button1.TabIndex = 8;
            button1.Text = "Crear usuario";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 355);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 14;
            label4.Text = "Carrera ";
            // 
            // Carrera
            // 
            Carrera.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Carrera.BorderStyle = BorderStyle.None;
            Carrera.Location = new Point(26, 386);
            Carrera.Name = "Carrera";
            Carrera.Size = new Size(287, 16);
            Carrera.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 418);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 16;
            label5.Text = "Clave";
            // 
            // Clave
            // 
            Clave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Clave.BorderStyle = BorderStyle.None;
            Clave.Location = new Point(26, 448);
            Clave.Name = "Clave";
            Clave.Size = new Size(287, 16);
            Clave.TabIndex = 15;
            Clave.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 178);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 18;
            label6.Text = "Matricula ";
            // 
            // Matricula
            // 
            Matricula.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Matricula.BorderStyle = BorderStyle.None;
            Matricula.Location = new Point(26, 205);
            Matricula.Name = "Matricula";
            Matricula.Size = new Size(287, 16);
            Matricula.TabIndex = 17;
            Matricula.TextChanged += textBox5_TextChanged;
            // 
            // loginRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 528);
            Controls.Add(label6);
            Controls.Add(Matricula);
            Controls.Add(label5);
            Controls.Add(Clave);
            Controls.Add(label4);
            Controls.Add(Carrera);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Correo);
            Controls.Add(Nombre);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "loginRegistro";
            Text = "loginRegistro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private TextBox Correo;
        private TextBox Nombre;
        private Button button1;
        private Label label4;
        private TextBox Carrera;
        private Label label5;
        private TextBox Clave;
        private Label label6;
        private TextBox Matricula;
    }
}