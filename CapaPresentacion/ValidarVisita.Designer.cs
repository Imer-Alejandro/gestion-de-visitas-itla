namespace CapaPresentacion
{
    partial class ValidarVisita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidarVisita));
            label4 = new Label();
            listadoEdificios = new ComboBox();
            label3 = new Label();
            asuntoVisita = new TextBox();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            label2 = new Label();
            listAreaEdificios = new ComboBox();
            fechaSalida = new DateTimePicker();
            label5 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 179);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 17;
            label4.Text = "Indicar el edifico";
            // 
            // listadoEdificios
            // 
            listadoEdificios.FormattingEnabled = true;
            listadoEdificios.Location = new Point(26, 197);
            listadoEdificios.Name = "listadoEdificios";
            listadoEdificios.Size = new Size(287, 23);
            listadoEdificios.TabIndex = 16;
            listadoEdificios.SelectedIndexChanged += listEdificios_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 337);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 15;
            label3.Text = "Indicar el asunto";
            // 
            // asuntoVisita
            // 
            asuntoVisita.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            asuntoVisita.BorderStyle = BorderStyle.None;
            asuntoVisita.Location = new Point(26, 355);
            asuntoVisita.Name = "asuntoVisita";
            asuntoVisita.Size = new Size(287, 16);
            asuntoVisita.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(26, 449);
            button1.Name = "button1";
            button1.Size = new Size(287, 42);
            button1.TabIndex = 13;
            button1.Text = "validar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 114);
            label1.Name = "label1";
            label1.Size = new Size(245, 37);
            label1.TabIndex = 12;
            label1.Text = "Validacion de visita";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(69, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 99);
            panel2.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(371, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 535);
            panel1.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(26, 235);
            button2.Name = "button2";
            button2.Size = new Size(287, 32);
            button2.TabIndex = 18;
            button2.Text = "confirmar edificio";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 280);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 20;
            label2.Text = "Indicar el area";
            // 
            // listAreaEdificios
            // 
            listAreaEdificios.FormattingEnabled = true;
            listAreaEdificios.Location = new Point(26, 298);
            listAreaEdificios.Name = "listAreaEdificios";
            listAreaEdificios.Size = new Size(287, 23);
            listAreaEdificios.TabIndex = 19;
            // 
            // fechaSalida
            // 
            fechaSalida.Location = new Point(26, 408);
            fechaSalida.Name = "fechaSalida";
            fechaSalida.Size = new Size(287, 23);
            fechaSalida.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 390);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 22;
            label5.Text = "Indicar fecha salida";
            label5.Click += label5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(87, 497);
            button3.Name = "button3";
            button3.Size = new Size(167, 28);
            button3.TabIndex = 23;
            button3.Text = "confirmar salida";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ValidarVisita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 534);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(fechaSalida);
            Controls.Add(label2);
            Controls.Add(listAreaEdificios);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(listadoEdificios);
            Controls.Add(label3);
            Controls.Add(asuntoVisita);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ValidarVisita";
            Text = "ValidarVisita";
            Load += ValidarVisita_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox listadoEdificios;
        private Label label3;
        private TextBox asuntoVisita;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Button button2;
        private Label label2;
        private ComboBox listAreaEdificios;
        private DateTimePicker fechaSalida;
        private Label label5;
        private Button button3;
    }
}