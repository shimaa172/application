namespace Documentation
{
    partial class DailyReport
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
            label1 = new Label();
            button3 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13F);
            button2.Location = new Point(116, 141);
            button2.Name = "button2";
            button2.Size = new Size(371, 84);
            button2.TabIndex = 1;
            button2.Text = "NEW";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26F);
            label1.Location = new Point(628, 32);
            label1.Name = "label1";
            label1.Size = new Size(310, 70);
            label1.TabIndex = 2;
            label1.Text = "Daily Report";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13F);
            button3.Location = new Point(644, 556);
            button3.Name = "button3";
            button3.Size = new Size(325, 64);
            button3.TabIndex = 3;
            button3.Text = "B A C K";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(987, 174);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(406, 33);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // DailyReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_12_03_at_3_23_56_AM;
            ClientSize = new Size(1627, 711);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "DailyReport";
            Text = "DailyReport";
            Load += DailyReport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label label1;
        private Button button3;
        private ComboBox comboBox1;
    }
}