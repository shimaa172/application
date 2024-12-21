namespace Documentation
{
    partial class Electrical
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
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(79, 204);
            button2.Name = "button2";
            button2.Size = new Size(410, 87);
            button2.TabIndex = 1;
            button2.Text = "NEW";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonShadow;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(647, 548);
            button3.Name = "button3";
            button3.Size = new Size(356, 64);
            button3.TabIndex = 2;
            button3.Text = "B A C K";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(688, 59);
            label1.Name = "label1";
            label1.Size = new Size(199, 54);
            label1.TabIndex = 3;
            label1.Text = "Electrical";
            label1.Click += label1_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1146, 216);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(362, 33);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Electrical
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_12_03_at_3_23_56_AM;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1658, 826);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "Electrical";
            Text = "Electrical";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Label label1;
        private ComboBox comboBox1;
    }
}