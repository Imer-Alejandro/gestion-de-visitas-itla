namespace CapaPresentacion
{
    partial class eliminarEdificioArea
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
            button3 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.DarkRed;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(42, 261);
            button3.Name = "button3";
            button3.Size = new Size(251, 43);
            button3.TabIndex = 5;
            button3.Text = "eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 28);
            label1.Name = "label1";
            label1.Size = new Size(251, 25);
            label1.TabIndex = 4;
            label1.Text = "Eliminar un Edificios o Areas";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Edificios", "Areas" });
            comboBox1.Location = new Point(42, 126);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 23);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(42, 190);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(251, 23);
            comboBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 108);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 8;
            label2.Text = "Indicar (edificio / area)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 172);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 9;
            label3.Text = "Indicar para eliminar";
            // 
            // eliminarEdificioArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 334);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(label1);
            Name = "eliminarEdificioArea";
            Text = "eliminarEdificioArea";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
    }
}