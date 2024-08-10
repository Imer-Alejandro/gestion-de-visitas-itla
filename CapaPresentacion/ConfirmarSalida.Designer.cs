namespace CapaPresentacion
{
    partial class ConfirmarSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmarSalida));
            label3 = new Label();
            codigoVisita = new TextBox();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 183);
            label3.Name = "label3";
            label3.Size = new Size(182, 15);
            label3.TabIndex = 29;
            label3.Text = "Indicar el codigo de autorización ";
            // 
            // codigoVisita
            // 
            codigoVisita.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            codigoVisita.BorderStyle = BorderStyle.None;
            codigoVisita.Location = new Point(183, 213);
            codigoVisita.Name = "codigoVisita";
            codigoVisita.Size = new Size(287, 16);
            codigoVisita.TabIndex = 28;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(183, 282);
            button1.Name = "button1";
            button1.Size = new Size(287, 47);
            button1.TabIndex = 27;
            button1.Text = "Validar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 94);
            label1.Name = "label1";
            label1.Size = new Size(211, 37);
            label1.TabIndex = 26;
            label1.Text = "Confirmar salida";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(235, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 89);
            panel2.TabIndex = 25;
            // 
            // ConfirmarSalida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 385);
            Controls.Add(label3);
            Controls.Add(codigoVisita);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "ConfirmarSalida";
            Text = "ConfirmarSalida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox codigoVisita;
        private Button button1;
        private Label label1;
        private Panel panel2;
    }
}